﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace dane_polimery_forms
{
    public partial class MainWindow : Form
    {
        ArrayList commands = null;
        ArrayList data;

        int frequency = 200;
        int timeSum;
        int elapsedTime;
        int singleExpTime = 0;
        int expNumber = 0;
        int dataReadCounter = 0;
        int specIntegrTime;
        int specAverage;
        int specSum;
        int specBoxcar;

        DateTime dateOfStart;
        DateTime dateOfEnd;

        public bool commandsLoaded = false;
        bool fileChosen = false;

        String filePath = null;
        XDocument doc = null;


        public MainWindow()
        {
            InitializeComponent();
            widmo.Series[0].Points.DataBindY(DataReader.GetData());
            frequencyTextBox.Text = "1";
            commandsTextBox.Enabled = false;
        }

        public void SetCommands(ArrayList _commands)
        {
            commands = _commands;
        }

        private void ButtonCommands_Click(object sender, EventArgs e)
        {
            Form command_form = new CommandForm(commands);
            commandsTextBox.ReadOnly = true;
            command_form.ShowDialog(this);
        }

        private void FrequencyTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Int32.TryParse(frequencyTextBox.Text, out frequency) == false){
                var msgbox = MessageBox.Show("Wymagana jest liczba INT.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frequencyTextBox.Text = frequency.ToString();
                return;
            }

        }

        private void ButtonOutFile_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveDialog = new SaveFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                RestoreDirectory = true,
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                FilterIndex = 1
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                saveDialog.CheckFileExists = true;
                if (System.IO.File.Exists(saveDialog.FileName))
                {
                    outfileTextBox.Text = Path.GetFileName(saveDialog.FileName);
                }
                else
                {
                    outfileTextBox.Text = "(new)" + Path.GetFileName(saveDialog.FileName);
                }
                if ((myStream = saveDialog.OpenFile()) != null)
                {
                    fileChosen = true;
                    filePath = saveDialog.FileName;
                    commentTextBox.Text += saveDialog.FileName + Environment.NewLine;
                    myStream.Close();
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false; ;
            elapsedTime += frequency;
            double progress = (double)elapsedTime * 100.0 / (double)timeSum;
            progress = progress > 100 ? 100 : progress;
            ProgressLabel.Text = "Postęp: "+(int)progress+"%";
            ExpNumberLabel.Text = "Krok nr: " + (expNumber + 1);

            doc.Root.Add(new XElement("blok",
                        new XAttribute("krok_nr",expNumber+1),
                        new XElement("czas", (DateTime.Now - dateOfStart).TotalSeconds.ToString("0.####")),
                        new XElement("przeplyw_1", ((int[])commands[expNumber])[1]),
                        new XElement("przeplyw_procent", ((int[])commands[expNumber])[2]),
                        new XElement("nr_butelki", ((int[])commands[expNumber])[3]),
                        new XElement("pomiar", string.Join(", ",DataReader.GetData()))
                    ));

            //getdata from spectrometr
            if (elapsedTime <= timeSum)
            {
                if(elapsedTime <= singleExpTime)
                {
                    timer.Enabled = true;
                }
                else
                {
                    ++expNumber;
                    singleExpTime += ((int[])commands[expNumber])[0];
                    commentTextBox.Text += "singleExpTime["+expNumber+"]: " + singleExpTime + Environment.NewLine;
                    dataReadCounter = 0;
                    timer.Enabled = true;
                }
            } else
            {
                EndOfExperiment();
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if( !(fileChosen & commandsLoaded))
            {
                var msgbox = MessageBox.Show("Wypełnij wszystkie pola w okienku","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (data != null)
            {
                data.Clear();
            }

            data = new ArrayList();
            timeSum = 0;
            elapsedTime = 0;
            dataReadCounter = 0;
            expNumber = 0;

            ProgressLabel.Visible = true;
            ExpNumberLabel.Visible = true;
            frequencyTextBox.Enabled = false;
            timer.Interval = frequency*1000;

            doc = new XDocument();
            XElement root = new XElement("eksperymenty", new XElement("komentarz", commentTextBox.Text));
            doc.Add(root);

            foreach(int[] commandLine in commands)
            {
                timeSum += commandLine[0];
            }

            singleExpTime = ((int[])commands[0])[0];
            commentTextBox.Text += "timeSUM: " + timeSum + Environment.NewLine;
            commentTextBox.Text += "singleExpTime[" + expNumber + "]: " + singleExpTime + Environment.NewLine;
            dateOfStart = DateTime.Now;
            timer.Enabled = true;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            timeSum = 0;
        }

        private void EndOfExperiment()
        {
            commentTextBox.Text += dateOfEnd = DateTime.Now;
            ProgressLabel.Visible = false;
            ExpNumberLabel.Visible = false;

            doc.Save(filePath);
            System.Diagnostics.Process.Start(filePath);
        }

        private void ButtonSpect_Click(object sender, EventArgs e)
        {
            Form spectForm = new SpectForm(ref specIntegrTime, ref specAverage, ref specSum, ref specBoxcar);
        }
    }

    public class DataReader
    {
        static int[] data = { 100, 110, 120, 130, 140, 130, 120, 110,100,90 };

        public static int[] GetData()
        {
            return data;
        }
    }
}

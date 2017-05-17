using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dane_polimery_forms
{
    public partial class CommandForm : Form
    {
        public CommandForm()
        {
            InitializeComponent();
            ButtonOk.Enabled = false;
        }

        ArrayList commands = new ArrayList();
        /*int minButelka = 1;
        int maxButelka = 4;
        int minCzas = 1;
        int maxCzas = Int32.MaxValue;
        int minPrzeplyw = 1;
        int maxPrzeplyw = Int32.MaxValue;*/
        String nazwaZestawuKomend;
        private void CommandsTextBox_TextChanged(object sender, EventArgs e)
        {
            ButtonOk.Enabled = false;
            nazwaZestawuKomend = "Własny";
        }

        private void ButtonLoadfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openfiledialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openfiledialog1.FilterIndex = 2;
            openfiledialog1.RestoreDirectory = true;

            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                commandsTextBox.Clear();
                Stream myStream = null;
                //commandsTextBox.Text = openfiledialog1.FileName;
                if ((myStream = openfiledialog1.OpenFile()) != null)
                {
                    using (myStream)
                    {
                        String line;
                        StreamReader read = new StreamReader(myStream);
                        while ((line = read.ReadLine()) != null)
                        {
                            //usuniecie spacji
                            line = string.Join("", line.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
                            Array arguments = line.Split(new Char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                            commandsTextBox.Text += line;
                            commandsTextBox.Text += Environment.NewLine;
                        }

                    }
                }
            }
            nazwaZestawuKomend = openfiledialog1.SafeFileName;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Owner).mainTextBox1.Text = nazwaZestawuKomend;
            ToolTip TP = new ToolTip();
            TP.InitialDelay = 0;
            TP.SetToolTip(((MainWindow)this.Owner).mainTextBox1, nazwaZestawuKomend);
            ((MainWindow)this.Owner).SetCommands(commands);
            this.Close();
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(commandsTextBox.Text))
            {
                var msgbox = MessageBox.Show("Wpisz komendy lub załaduj plik.","Bład",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            bool success = true; ;
            for (int i = 0;i < commandsTextBox.Lines.Length; ++i)
            {
                string line = commandsTextBox.Lines[i];
                if (line.Length == 0)
                {
                    continue;
                }

                string[] newLines = commandsTextBox.Lines;
                string[] tmp = line.Split(new Char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if(tmp.Length != 4)
                {
                    newLines[i] = "ERROR";
                    success = false;
                    commandsTextBox.Lines = newLines;
                    continue;
                }

                int[] commandLine = { 0, 0, 0, 0 };
                for (int j = 0; j < tmp.Length; ++j)
                {
                    if(Int32.TryParse(tmp[j], out commandLine[j]) == false)
                    {
                        newLines[i] = "PARSING ERROR";
                        success = false;
                        commandsTextBox.Lines = newLines;
                        break;
                    }
                }
                if (success)
                {
                    commands.Add(commandLine);
                }



            }
            if (success)
            {
                ButtonOk.Enabled = true;
            }
            
        }

        private void ButtonErLog_Click(object sender, EventArgs e)
        {
            Form error_form = new FormErrorLog();
            error_form.ShowDialog();
        }
    }
}

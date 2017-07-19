using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
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

        public int specIntegrTime, specAverage, specBoxcar, specIndex;

        Spectrometer spectrometer;

        DateTime dateOfStart;
        DateTime dateOfEnd;

        public bool commandsLoaded = false;
        bool fileChosen = false;

        String filePath = null;

        StreamWriter eofStream;
        OmniDriver.NETWrapper wrapper;
        ValvesController valvesCon;
        FlowController flowCon;
        public string FCPortName, ValvePortName;

        public MainWindow()
        {
            InitializeComponent();
            widmo.Series[0].Points.DataBindY(Spectrometer.GetDefaultData());
            frequencyTextBox.Text = "1";
            commandsTextBox.Enabled = false;
            wrapper = new OmniDriver.NETWrapper();

            //test FC
            //flowCon = new FlowController("COM4");
            //commentTextBox.Text+= Environment.NewLine + flowCon.Setpoint(1, 5500);
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

            //getdata from spectrometr

            double[] spectrumData = spectrometer.GetSpectrum();
            widmo.Series[0].Points.DataBindY(spectrumData);


            XElement currentElement = new XElement("blok",
                        new XAttribute("krok_nr", expNumber + 1),
                        new XElement("czas", (DateTime.Now - dateOfStart).TotalSeconds.ToString("0.####")),
                        new XElement("przeplyw_1", ((int[])commands[expNumber])[1]),
                        new XElement("przeplyw_procent", ((int[])commands[expNumber])[2]),
                        new XElement("nr_butelki", ((int[])commands[expNumber])[3]),
                        new XElement("pomiar", string.Join("; ", spectrumData))
                    );
            eofStream.Write(Environment.NewLine+currentElement.ToString()+Environment.NewLine);

            if (elapsedTime <= timeSum)
            {
                if(elapsedTime <= singleExpTime)
                {
                    timer.Enabled = true;
                }
                else
                {
                    ++expNumber;
                    this.ApplyCommands(expNumber);
                    commentTextBox.Text += "singleExpTime["+expNumber+"]: " + singleExpTime + " Valve: " + ((int[])commands[expNumber])[3]  +Environment.NewLine;
                    timer.Enabled = true;
                }
            } else
            {
                EndOfExperiment();
            }
        }

        private void ApplyCommands(int _expNumber)
        {
            singleExpTime += ((int[])commands[_expNumber])[0];
            int sumOfFlow = ((int[])commands[_expNumber])[1];
            float percentOfFlow = ((int[])commands[_expNumber])[2];
            commentTextBox.Text+= Environment.NewLine + flowCon.SetpointAndOpen(1, (int)(( (sumOfFlow * percentOfFlow) )/100) );
            flowCon.SetpointAndOpen(2, (int)(((sumOfFlow * (100 -percentOfFlow))) / 100));
            valvesCon.OpenValve(((int[])commands[_expNumber])[3]);
            Thread.Sleep(1000);
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
            valvesCon = new ValvesController(ValvePortName);
            flowCon = new FlowController(FCPortName);
            spectrometer = new Spectrometer(ref wrapper, specIndex, specIntegrTime, specAverage, specBoxcar);
            //clear the file
            File.Create(filePath).Close();
            eofStream = File.AppendText(filePath);
            eofStream.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>"+Environment.NewLine+ "<eksperymenty>" + Environment.NewLine + "<komentarz>"
                +Environment.NewLine+commentTextBox.Text+"</komentarz> ");

            data = new ArrayList();
            timeSum = 0;
            elapsedTime = 0;
            expNumber = 0;

            ProgressLabel.Visible = true;
            ExpNumberLabel.Visible = true;
            frequencyTextBox.Enabled = false;
            timer.Interval = frequency*1000;

            foreach(int[] commandLine in commands)
            {
                timeSum += commandLine[0];
            }

            singleExpTime = 0;
            this.ApplyCommands(0);
            commentTextBox.Text += "timeSUM: " + timeSum + Environment.NewLine;
            commentTextBox.Text += "singleExpTime[" + expNumber + "]: " + singleExpTime + " Valve: " + ((int[])commands[expNumber])[3] + Environment.NewLine;
            dateOfStart = DateTime.Now;
            timer.Enabled = true;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            timeSum = 0;
        }

        private void EndOfExperiment()
        {
            valvesCon.CloseValves();
            Thread.Sleep(1000);
            valvesCon.Close();
            flowCon.Close();
            commentTextBox.Text += dateOfEnd = DateTime.Now;
            ProgressLabel.Visible = false;
            ExpNumberLabel.Visible = false;
            eofStream.Write("</eksperymenty>");
            eofStream.Close();
            System.Diagnostics.Process.Start(filePath);
        }

        private void ButtonSpect_Click(object sender, EventArgs e)
        {
            Form spectForm = null;
            DialogResult result = MessageBox.Show("Load default options?", "Spectrometer Form", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                spectForm = new SpectForm(ref wrapper,true);
            } else if (result == DialogResult.No)
            {
                spectForm = new SpectForm(ref wrapper, false);
            }
            
            spectForm.ShowDialog(this);
        }
    }

    public class Spectrometer
    {
        int integrTime, average, boxcar;
        OmniDriver.NETWrapper wrapper;
        int index = 0;
        public Spectrometer(ref OmniDriver.NETWrapper _wrapper, int _specIndex, int _integrTime,int _average, int _Boxcar)
        {
            wrapper = _wrapper;
            integrTime = _integrTime;
            average = _average;
            boxcar = _Boxcar;
            index = _specIndex;
            //w microsekundach
            wrapper.setIntegrationTime(index, integrTime * 1000);
            wrapper.setScansToAverage(index, average);
            wrapper.setBoxcarWidth(index, boxcar);
        }

        public double[] GetSpectrum()
        {
            return wrapper.getSpectrum(index);
        }

        static int[] defaultData = { 100, 110, 120, 130, 140, 130, 120, 110,100,90 };

        public static int[] GetDefaultData()
        {
            return defaultData;
        }
    }

}

public class ValvesController
{
    SerialPort serial;

    public ValvesController (String _portName)
    {
        serial = new SerialPort(_portName, 9600, Parity.None, 8, StopBits.One);
    }

    public ValvesController(String _portName, int _baudRate, Parity _parityBit, int _dataBits, StopBits _stopBits)
    {
        serial = new SerialPort(_portName,_baudRate,_parityBit,_dataBits,_stopBits);
    }

    byte[] GetBytes(string data)
    {
        return Encoding.ASCII.GetBytes(data);
    }

    public string SendAndReceive(string _data)
    {
        byte[] data = this.GetBytes(_data);
        serial.Write(data, 0, data.Length);
        Thread.Sleep(500);
        return serial.ReadExisting();
    }

    public void OpenValve(int ValveNumber)
    {
        if (!serial.IsOpen)
        {
            this.Open();
        }
        int valve = (int)Math.Pow(2, ValveNumber - 1);

        SendAndReceive("@10S0" + valve + valve + "3#");
    }

    public void CloseValves()
    {
        if (!serial.IsOpen)
        {
            this.Open();
        }
        SendAndReceive("@10S0000#");
    }

    public void Open()
    {
        serial.Open();
    }

    public void Close()
    {
        serial.Close();
    }
}

public class FlowController
{
    SerialPort serial;

    public FlowController(String _portName)
    {
        serial = new SerialPort(_portName, 9600, Parity.Odd, 7, StopBits.One);
    }

    public FlowController(String _portName, int _baudRate, Parity _parityBit, int _dataBits, StopBits _stopBits)
    {
        serial = new SerialPort(_portName, _baudRate, _parityBit, _dataBits, _stopBits);
    }

    byte[] GetBytes(string data)
    {
        return Encoding.ASCII.GetBytes(data);
    }

    public string SetpointAndOpen(int SetpointNumber,int value)
    {
        if (!serial.IsOpen)
        {
            this.Open();
        }
        byte[] data = this.GetBytes("SP" + SetpointNumber + ","+value + "\r");
        serial.Write(data,0,data.Length);
        Thread.Sleep(2000);
        Debug.Write("Setpoint number: "+SetpointNumber+" value: "+value+Environment.NewLine);
        //read?
        /*byte[] data2 = this.GetBytes("VL"+(SetpointNumber-1)+",ON\r");
        serial.Write(data2, 0, data2.Length);
        Thread.Sleep(2000);
        //wyczytaj rzeczywisty przeplyw
        //  "?VL\r"  - a moze "?VL1"\r"
        byte[] readData = this.GetBytes("?VL"+(SetpointNumber-1)+"\r");
        serial.Write(readData,0,readData.Length);
        Thread.Sleep(2000);
        return serial.ReadExisting();*/
        return "asd";
    }

    public string Setpoint(int SetpointNumber, int value)
    {
        if (!serial.IsOpen)
        {
            this.Open();
        }
        byte[] data = this.GetBytes("SP" + SetpointNumber + "," + value + "\r");
        serial.Write(data, 0, data.Length);
        Thread.Sleep(2000);
        byte[] data2 = this.GetBytes("?SP" + SetpointNumber + "\r");
        serial.Write(data2, 0, data2.Length);
        Thread.Sleep(2000);
        return serial.ReadExisting();
    }

    public void Open()
    {
        serial.Open();
    }

    public void Close()
    {
        serial.Close();
    }
}
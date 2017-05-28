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
        public CommandForm(ArrayList _commands)
        {
            InitializeComponent();
            ButtonOk.Enabled = false;
            ButtonErLog.Enabled = false;
            if (_commands != null)
            {
                foreach (int[] line in _commands)
                {
                    line[0]/= 1000;
                    commandsTextBox.Text += string.Join(";", line) + ";" + Environment.NewLine;
                    line[0] *= 1000;
                }
            }
        }

        Form error_form;
        ArrayList commands = new ArrayList();
        List<Tuple<int, String>> errors = new List<Tuple<int, string>>();
        /*
        int maxButelka = 4;
        int minCzas = 1;
        int maxCzas = Int32.MaxValue;
        int minPrzeplyw = 1;
        int maxPrzeplyw = Int32.MaxValue;*/
        String nazwaZestawuKomend;

        private void CommandsTextBox_TextChanged(object sender, EventArgs e)
        {
            ButtonOk.Enabled = false;
            ButtonErLog.Enabled = false;
            nazwaZestawuKomend = "Własny";
        }

        private void ButtonLoadfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                commandsTextBox.Clear();
                Stream myStream = null;
                //commandsTextBox.Text = openfiledialog1.FileName;
                if ((myStream = openFileDialog.OpenFile()) != null)
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
            nazwaZestawuKomend = openFileDialog.SafeFileName;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (error_form != null)
            {
                if (error_form.Visible)
                {
                    error_form.Close();
                }
            }

            foreach(int[] arg in commands)
            {
                arg[0] *= 1000;
            }

            ((MainWindow)this.Owner).commandsTextBox.Text = nazwaZestawuKomend;
            ((MainWindow)this.Owner).commandsLoaded = true;
            ToolTip TP = new ToolTip()
            {
                InitialDelay = 0
            };
            TP.SetToolTip(((MainWindow)this.Owner).commandsTextBox, nazwaZestawuKomend);
            ((MainWindow)this.Owner).SetCommands(commands);
            this.Close();
        }

        private void LineToRed(int lineNum)
        {
            int first = commandsTextBox.GetFirstCharIndexFromLine(lineNum);
            int last = commandsTextBox.GetFirstCharIndexFromLine(lineNum+1);
            if ( last == -1 )
            {
                last = commandsTextBox.TextLength;
            }
            commandsTextBox.Select(first, last-first);
            commandsTextBox.SelectionColor = Color.Red;
            commandsTextBox.DeselectAll();
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            errors.Clear();
            if (string.IsNullOrWhiteSpace(commandsTextBox.Text))
            {
                var msgbox = MessageBox.Show("Wpisz komendy lub załaduj plik.","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

                string[] tmp = line.Split(new Char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if(tmp.Length != 4)
                {
                    success = false;
                    LineToRed(i);
                    errors.Add(Tuple.Create(i, "Zła liczba argumentów."));
                    continue;
                }

                int[] commandLine = { 0, 0, 0, 0 };
                for (int j = 0; j < tmp.Length; ++j)
                {
                    if(Int32.TryParse(tmp[j], out commandLine[j]) == false)
                    {
                        //newLines[i] = "PARSING ERROR";
                        LineToRed(i);
                        errors.Add(Tuple.Create(i,"Błąd parsowania argumentu( "+tmp[j]+" ) do Int32."));
                        success = false;
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
            } else
            {
                ButtonErLog.Enabled = true;
            }
            
        }

        private void ButtonErLog_Click(object sender, EventArgs e)
        {
            if(error_form != null)
            {
                if (error_form.Visible)
                {
                    error_form.Close();
                }
            }
            
            error_form = new FormErrorLog(errors);
            error_form.Show();
        }
    }
}

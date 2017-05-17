using System;
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

namespace dane_polimery_forms
{
    public partial class MainWindow : Form
    {
        ArrayList commands;

        public MainWindow()
        {
            InitializeComponent();
            var data = new DataReader();
            widmo.Series[0].Points.DataBindY(data.data);
        }

        public void SetCommands(ArrayList _commands)
        {
            commands = _commands;
        }

        private void ButtonCommands_Click_1(object sender, EventArgs e)
        {
            Form command_form = new CommandForm();
            mainTextBox1.ReadOnly = true;
            command_form.ShowDialog(this);
        }
    }

    public class DataReader
    {
        public int[] data = { 100, 110, 120, 130, 140, 130, 120, 110,100,90 };
    }
}

using System;
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
    

    public partial class SpectForm : Form
    {
        String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Spectrometer Options";
        int tmpIndex = 0,tmpIntegrTime = 1, tmpAverage = 1, tmpSum = 1, tmpBoxcar = 1;

        public SpectForm(ref OmniDriver.NETWrapper wrapper, bool loadDefaults)
        {
            wrapper.openAllSpectrometers();
            InitializeComponent();
            for (int i = 0; i < wrapper.getNumberOfSpectrometersFound(); ++i)
            {
                indexComboBox.Items.Add(wrapper.getSerialNumber(i) + "(Index: " + i + ")");
            }

            //wczytaj default
            if (loadDefaults)
            {
                XDocument doc = XDocument.Load(path + "\\default.xml");
                var options = doc.Root;
                indexComboBox.SelectedIndex = Int32.Parse(options.Element("Index").Value);
                IntegrTTextBox.Text = (string)options.Element("Integration_Time").Value;
                AverageTTextBox.Text = (string)options.Element("Average").Value;
                SumTextBox.Text = (string)options.Element("Sum").Value;
                BoxcarWidthTextBox.Text = (string)options.Element("Boxcar_Width").Value;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tmpIndex = indexComboBox.SelectedIndex;
        }

        private void IntegrTTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Int32.TryParse(IntegrTTextBox.Text, out tmpIntegrTime) == false)
            {
                //error
            }
        }

        private void AverageTTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(AverageTTextBox.Text, out tmpAverage) == false)
            {
                //error
            }
        }

        private void SetDefaultButton_Click(object sender, EventArgs e)
        {
            XDocument doc = new XDocument(new XElement("SpectrometerOptions",
                new XElement("Index",tmpIndex),
                new XElement("Integration_Time",tmpIntegrTime),
                new XElement("Average",tmpAverage),
                new XElement("Sum",tmpSum),
                new XElement("Boxcar_Width",tmpBoxcar)
                ));
            ;
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            doc.Save(path+"\\default.xml");
            MessageBox.Show("Set default options!","Set Default", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SumTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(SumTextBox.Text, out tmpSum) == false)
            {
                //error
            }
        }

        private void BoxcarWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(BoxcarWidthTextBox.Text, out tmpBoxcar) == false)
            {
                //error
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ((MainWindow)this.Owner).specIndex = tmpIndex;
            ((MainWindow)this.Owner).specIntegrTime = tmpIntegrTime;
            ((MainWindow)this.Owner).specAverage = tmpAverage;
            ((MainWindow)this.Owner).specSum = tmpSum;
            ((MainWindow)this.Owner).specBoxcar = tmpBoxcar;
            this.Close();
        }
    }
}

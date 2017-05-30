using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dane_polimery_forms
{
    public partial class SpectForm : Form
    {
        public SpectForm(ref int specIntegrTime, ref int specAverage, ref int specSum, ref int specBoxcar)
        {
            InitializeComponent();
        }

        private void IntegrTTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AverageTTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxcarWidthTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

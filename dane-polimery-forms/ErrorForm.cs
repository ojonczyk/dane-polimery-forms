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
    public partial class FormErrorLog : Form
    {
        List<Tuple<int, String>> errors;
        public FormErrorLog(List<Tuple<int, String>> _errors)
        {
            InitializeComponent();
            errors = _errors;
            ErrorGrid.DataSource = _errors;
            ErrorGrid.Columns.GetFirstColumn(DataGridViewElementStates.Visible).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ErrorGrid.Columns.GetFirstColumn(DataGridViewElementStates.Visible).HeaderText = "Linia";
            ErrorGrid.Columns.GetLastColumn(DataGridViewElementStates.Visible,DataGridViewElementStates.None).HeaderText = "Komentarz";
            ErrorGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

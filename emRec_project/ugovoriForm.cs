using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace emRec_project
{
    public partial class ugovoriForm : Form
    {
        public ugovoriForm()
        {
            InitializeComponent();
        }

        private void tblPulsiciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPulsiciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pulsDBDataSet);

        }

        private void ugovoriForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pulsDBDataSet.tblPulsici' table. You can move, or remove it, as needed.
            this.tblPulsiciTableAdapter.Fill(this.pulsDBDataSet.tblPulsici);

        }
    }
}

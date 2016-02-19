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
    public partial class projektiForm : Form
    {
        public projektiForm()
        {
            InitializeComponent();
        }

        private void tblProjektiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProjektiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pulsDBDataSet);

        }

        private void projektiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pulsDBDataSet.tblProjekti' table. You can move, or remove it, as needed.
            this.tblProjektiTableAdapter.Fill(this.pulsDBDataSet.tblProjekti);

        }
    }
}

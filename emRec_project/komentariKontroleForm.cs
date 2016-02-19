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
    public partial class komentariKontroleForm : Form
    {
        public komentariKontroleForm()
        {
            InitializeComponent();
        }

        private void tblImportKomentariBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblImportKomentariBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pulsDBDataSet);

        }

        private void komentariKontroleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pulsDBDataSet.tblImportKomentari' table. You can move, or remove it, as needed.
            this.tblImportKomentariTableAdapter.Fill(this.pulsDBDataSet.tblImportKomentari);

        }
    }
}

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
    public partial class statistikaForm : Form
    {
        public statistikaForm()
        {
            InitializeComponent();
        }

        private void statistikaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pulsDBDataSet.tblImportStatistics' table. You can move, or remove it, as needed.
            this.tblImportStatisticsTableAdapter.Fill(this.pulsDBDataSet.tblImportStatistics);

        }

    }
}

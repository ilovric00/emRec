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
    public partial class kompletnaStatistikaForm : Form
    {
        public kompletnaStatistikaForm()
        {
            InitializeComponent();
        }

        private void kompletnaStatistikaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pulsDBDataSet.Query_StatistikaKomentari' table. You can move, or remove it, as needed.
            this.query_StatistikaKomentariTableAdapter.Fill(this.pulsDBDataSet.Query_StatistikaKomentari);

        }
    }
}

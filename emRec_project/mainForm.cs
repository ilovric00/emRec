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
    public partial class mainForm : Form
    {
        string user;
        public mainForm(string User)
        {
            InitializeComponent();
            user = User;
            lblPrijavljeniKao.Text = "Prijavljeni ste kao " + user + "!";

            user = user.ToLower();
            if(user!="admin")
            {
                zaposleniciToolStripMenuItem.Visible = false;
                financijeToolStripMenuItem.Visible = false;
                administracijaToolStripMenuItem.Visible = false;
                cATIKontrolaToolStripMenuItem.Visible = false;
                projektiToolStripMenuItem.Visible = false;
            }     
        }
        
        
        private void anketariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zaposleniciForm f2 = new zaposleniciForm();
            f2.ShowDialog();     
        }

        private void projektiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projektiForm f3 = new projektiForm();
            f3.ShowDialog();
        }

        private void komentariKontroleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            komentariKontroleForm f4 = new komentariKontroleForm();
            f4.ShowDialog(); 
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statistikaForm f5 = new statistikaForm();
            f5.ShowDialog();
        }

        private void ugovoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ugovoriForm f6 = new ugovoriForm();
                f6.ShowDialog();
        }

        private void kompletnaStatistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importExcelForm f7 = new importExcelForm();
            f7.ShowDialog();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odjavljujem profil " + user);
            user = "";
            this.Hide();
            loginForm login = new loginForm();
            login.ShowDialog();
            this.Close();
        }

        private void smjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anketaForm af = new anketaForm();
            af.ShowDialog();
        }

    }
}

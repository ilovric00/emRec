namespace emRec_project
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anketariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.organizacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATIKontrolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komentariKontroleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompletnaStatistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.financijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugovoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrijavljeniKao = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniciToolStripMenuItem,
            this.toolStripSeparator1,
            this.organizacijaToolStripMenuItem,
            this.toolStripSeparator2,
            this.financijeToolStripMenuItem,
            this.toolStripSeparator3,
            this.administracijaToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.MinimumSize = new System.Drawing.Size(0, 30);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(828, 30);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anketariToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Image = global::emRec_project.Properties.Resources.account;
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // anketariToolStripMenuItem
            // 
            this.anketariToolStripMenuItem.Image = global::emRec_project.Properties.Resources.anketarIcon;
            this.anketariToolStripMenuItem.Name = "anketariToolStripMenuItem";
            this.anketariToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.anketariToolStripMenuItem.Text = "Anketari";
            this.anketariToolStripMenuItem.Click += new System.EventHandler(this.anketariToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // organizacijaToolStripMenuItem
            // 
            this.organizacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smjeneToolStripMenuItem,
            this.cATIKontrolaToolStripMenuItem,
            this.projektiToolStripMenuItem});
            this.organizacijaToolStripMenuItem.Image = global::emRec_project.Properties.Resources.Directory;
            this.organizacijaToolStripMenuItem.Name = "organizacijaToolStripMenuItem";
            this.organizacijaToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.organizacijaToolStripMenuItem.Text = "Organizacija";
            // 
            // smjeneToolStripMenuItem
            // 
            this.smjeneToolStripMenuItem.Image = global::emRec_project.Properties.Resources.smjeneIcon;
            this.smjeneToolStripMenuItem.Name = "smjeneToolStripMenuItem";
            this.smjeneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.smjeneToolStripMenuItem.Text = "Anketa";
            this.smjeneToolStripMenuItem.Click += new System.EventHandler(this.smjeneToolStripMenuItem_Click);
            // 
            // cATIKontrolaToolStripMenuItem
            // 
            this.cATIKontrolaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.komentariKontroleToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.kompletnaStatistikaToolStripMenuItem});
            this.cATIKontrolaToolStripMenuItem.Image = global::emRec_project.Properties.Resources.supervisor;
            this.cATIKontrolaToolStripMenuItem.Name = "cATIKontrolaToolStripMenuItem";
            this.cATIKontrolaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cATIKontrolaToolStripMenuItem.Text = "CATI kontrola";
            // 
            // komentariKontroleToolStripMenuItem
            // 
            this.komentariKontroleToolStripMenuItem.Image = global::emRec_project.Properties.Resources.commentIcon;
            this.komentariKontroleToolStripMenuItem.Name = "komentariKontroleToolStripMenuItem";
            this.komentariKontroleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.komentariKontroleToolStripMenuItem.Text = "Komentari kontrole";
            this.komentariKontroleToolStripMenuItem.Click += new System.EventHandler(this.komentariKontroleToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Image = global::emRec_project.Properties.Resources.chart;
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // kompletnaStatistikaToolStripMenuItem
            // 
            this.kompletnaStatistikaToolStripMenuItem.Image = global::emRec_project.Properties.Resources.fullStatistics;
            this.kompletnaStatistikaToolStripMenuItem.Name = "kompletnaStatistikaToolStripMenuItem";
            this.kompletnaStatistikaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.kompletnaStatistikaToolStripMenuItem.Text = "Kompletna statistika";
            this.kompletnaStatistikaToolStripMenuItem.Click += new System.EventHandler(this.kompletnaStatistikaToolStripMenuItem_Click);
            // 
            // projektiToolStripMenuItem
            // 
            this.projektiToolStripMenuItem.Image = global::emRec_project.Properties.Resources.projectIcon;
            this.projektiToolStripMenuItem.Name = "projektiToolStripMenuItem";
            this.projektiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.projektiToolStripMenuItem.Text = "Projekti";
            this.projektiToolStripMenuItem.Click += new System.EventHandler(this.projektiToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // financijeToolStripMenuItem
            // 
            this.financijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledRadaToolStripMenuItem,
            this.ugovoriToolStripMenuItem});
            this.financijeToolStripMenuItem.Image = global::emRec_project.Properties.Resources.financeIcon;
            this.financijeToolStripMenuItem.Name = "financijeToolStripMenuItem";
            this.financijeToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.financijeToolStripMenuItem.Text = "Financije";
            // 
            // pregledRadaToolStripMenuItem
            // 
            this.pregledRadaToolStripMenuItem.Image = global::emRec_project.Properties.Resources.clock;
            this.pregledRadaToolStripMenuItem.Name = "pregledRadaToolStripMenuItem";
            this.pregledRadaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pregledRadaToolStripMenuItem.Text = "Pregled rada";
            // 
            // ugovoriToolStripMenuItem
            // 
            this.ugovoriToolStripMenuItem.Image = global::emRec_project.Properties.Resources.contact;
            this.ugovoriToolStripMenuItem.Name = "ugovoriToolStripMenuItem";
            this.ugovoriToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ugovoriToolStripMenuItem.Text = "Ugovori";
            this.ugovoriToolStripMenuItem.Click += new System.EventHandler(this.ugovoriToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.Image = global::emRec_project.Properties.Resources.settingsIcon;
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.administracijaToolStripMenuItem.Text = "Administracija";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.odjavaToolStripMenuItem.Image = global::emRec_project.Properties.Resources.delete;
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // lblPrijavljeniKao
            // 
            this.lblPrijavljeniKao.AutoSize = true;
            this.lblPrijavljeniKao.Location = new System.Drawing.Point(610, 9);
            this.lblPrijavljeniKao.Name = "lblPrijavljeniKao";
            this.lblPrijavljeniKao.Size = new System.Drawing.Size(51, 13);
            this.lblPrijavljeniKao.TabIndex = 1;
            this.lblPrijavljeniKao.Text = "Prijavljeni";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 411);
            this.Controls.Add(this.lblPrijavljeniKao);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emRec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem organizacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATIKontrolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komentariKontroleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem financijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem anketariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledRadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugovoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompletnaStatistikaToolStripMenuItem;
        private System.Windows.Forms.Label lblPrijavljeniKao;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
    }
}
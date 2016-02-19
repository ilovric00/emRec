namespace emRec_project
{
    partial class importExcelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(importExcelForm));
            this.bttnOdaberiStatistika = new System.Windows.Forms.Button();
            this.bttnUcitaj = new System.Windows.Forms.Button();
            this.txtboxPathStatistika = new System.Windows.Forms.TextBox();
            this.groupBoxImport = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPathKomentari = new System.Windows.Forms.TextBox();
            this.bttnOdaberiKomentari = new System.Windows.Forms.Button();
            this.groupBoxImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnOdaberiStatistika
            // 
            this.bttnOdaberiStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnOdaberiStatistika.Location = new System.Drawing.Point(397, 84);
            this.bttnOdaberiStatistika.Name = "bttnOdaberiStatistika";
            this.bttnOdaberiStatistika.Size = new System.Drawing.Size(75, 23);
            this.bttnOdaberiStatistika.TabIndex = 0;
            this.bttnOdaberiStatistika.Text = "Odaberi:";
            this.bttnOdaberiStatistika.UseVisualStyleBackColor = true;
            this.bttnOdaberiStatistika.Click += new System.EventHandler(this.bttnOdaberiStatistika_Click);
            // 
            // bttnUcitaj
            // 
            this.bttnUcitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnUcitaj.Image = global::emRec_project.Properties.Resources.excelIcon;
            this.bttnUcitaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnUcitaj.Location = new System.Drawing.Point(183, 125);
            this.bttnUcitaj.Name = "bttnUcitaj";
            this.bttnUcitaj.Size = new System.Drawing.Size(152, 41);
            this.bttnUcitaj.TabIndex = 1;
            this.bttnUcitaj.Text = "Učitaj";
            this.bttnUcitaj.UseVisualStyleBackColor = true;
            this.bttnUcitaj.Click += new System.EventHandler(this.bttnUcitaj_Click);
            // 
            // txtboxPathStatistika
            // 
            this.txtboxPathStatistika.Location = new System.Drawing.Point(140, 87);
            this.txtboxPathStatistika.Name = "txtboxPathStatistika";
            this.txtboxPathStatistika.Size = new System.Drawing.Size(236, 20);
            this.txtboxPathStatistika.TabIndex = 2;
            // 
            // groupBoxImport
            // 
            this.groupBoxImport.Controls.Add(this.label2);
            this.groupBoxImport.Controls.Add(this.label1);
            this.groupBoxImport.Controls.Add(this.textBoxPathKomentari);
            this.groupBoxImport.Controls.Add(this.bttnOdaberiKomentari);
            this.groupBoxImport.Controls.Add(this.bttnOdaberiStatistika);
            this.groupBoxImport.Controls.Add(this.bttnUcitaj);
            this.groupBoxImport.Controls.Add(this.txtboxPathStatistika);
            this.groupBoxImport.Location = new System.Drawing.Point(12, 12);
            this.groupBoxImport.Name = "groupBoxImport";
            this.groupBoxImport.Size = new System.Drawing.Size(492, 180);
            this.groupBoxImport.TabIndex = 4;
            this.groupBoxImport.TabStop = false;
            this.groupBoxImport.Text = "Import Excel File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(69, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Statistika:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Komentari kontole:";
            // 
            // textBoxPathKomentari
            // 
            this.textBoxPathKomentari.Location = new System.Drawing.Point(140, 45);
            this.textBoxPathKomentari.Name = "textBoxPathKomentari";
            this.textBoxPathKomentari.Size = new System.Drawing.Size(236, 20);
            this.textBoxPathKomentari.TabIndex = 4;
            // 
            // bttnOdaberiKomentari
            // 
            this.bttnOdaberiKomentari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnOdaberiKomentari.Location = new System.Drawing.Point(397, 42);
            this.bttnOdaberiKomentari.Name = "bttnOdaberiKomentari";
            this.bttnOdaberiKomentari.Size = new System.Drawing.Size(75, 23);
            this.bttnOdaberiKomentari.TabIndex = 3;
            this.bttnOdaberiKomentari.Text = "Odaberi";
            this.bttnOdaberiKomentari.UseVisualStyleBackColor = true;
            this.bttnOdaberiKomentari.Click += new System.EventHandler(this.bttnOdaberiKomentari_Click);
            // 
            // importExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 204);
            this.Controls.Add(this.groupBoxImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "importExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emRec - [import file]";
            this.groupBoxImport.ResumeLayout(false);
            this.groupBoxImport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnOdaberiStatistika;
        private System.Windows.Forms.Button bttnUcitaj;
        private System.Windows.Forms.TextBox txtboxPathStatistika;
        private System.Windows.Forms.GroupBox groupBoxImport;
        private System.Windows.Forms.TextBox textBoxPathKomentari;
        private System.Windows.Forms.Button bttnOdaberiKomentari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
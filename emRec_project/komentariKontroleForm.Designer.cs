namespace emRec_project
{
    partial class komentariKontroleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(komentariKontroleForm));
            this.pulsDBDataSet = new emRec_project.PulsDBDataSet();
            this.tblImportKomentariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblImportKomentariTableAdapter = new emRec_project.PulsDBDataSetTableAdapters.tblImportKomentariTableAdapter();
            this.tableAdapterManager = new emRec_project.PulsDBDataSetTableAdapters.TableAdapterManager();
            this.tblImportKomentariBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblImportKomentariDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pulsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportKomentariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportKomentariBindingNavigator)).BeginInit();
            this.tblImportKomentariBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportKomentariDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pulsDBDataSet
            // 
            this.pulsDBDataSet.DataSetName = "PulsDBDataSet";
            this.pulsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblImportKomentariBindingSource
            // 
            this.tblImportKomentariBindingSource.DataMember = "tblImportKomentari";
            this.tblImportKomentariBindingSource.DataSource = this.pulsDBDataSet;
            // 
            // tblImportKomentariTableAdapter
            // 
            this.tblImportKomentariTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblImportKomentariTableAdapter = this.tblImportKomentariTableAdapter;
            this.tableAdapterManager.tblImportStatisticsTableAdapter = null;
            this.tableAdapterManager.tblProjektiTableAdapter = null;
            this.tableAdapterManager.tblPulsiciTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = emRec_project.PulsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblImportKomentariBindingNavigator
            // 
            this.tblImportKomentariBindingNavigator.AddNewItem = null;
            this.tblImportKomentariBindingNavigator.BindingSource = this.tblImportKomentariBindingSource;
            this.tblImportKomentariBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblImportKomentariBindingNavigator.DeleteItem = null;
            this.tblImportKomentariBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tblImportKomentariBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblImportKomentariBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblImportKomentariBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblImportKomentariBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblImportKomentariBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblImportKomentariBindingNavigator.Name = "tblImportKomentariBindingNavigator";
            this.tblImportKomentariBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblImportKomentariBindingNavigator.Size = new System.Drawing.Size(760, 25);
            this.tblImportKomentariBindingNavigator.TabIndex = 0;
            this.tblImportKomentariBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblImportKomentariDataGridView
            // 
            this.tblImportKomentariDataGridView.AllowUserToAddRows = false;
            this.tblImportKomentariDataGridView.AllowUserToDeleteRows = false;
            this.tblImportKomentariDataGridView.AutoGenerateColumns = false;
            this.tblImportKomentariDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblImportKomentariDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tblImportKomentariDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblImportKomentariDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.tblImportKomentariDataGridView.DataSource = this.tblImportKomentariBindingSource;
            this.tblImportKomentariDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblImportKomentariDataGridView.GridColor = System.Drawing.Color.White;
            this.tblImportKomentariDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tblImportKomentariDataGridView.Name = "tblImportKomentariDataGridView";
            this.tblImportKomentariDataGridView.ReadOnly = true;
            this.tblImportKomentariDataGridView.Size = new System.Drawing.Size(760, 335);
            this.tblImportKomentariDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Prezime i ime";
            this.dataGridViewTextBoxColumn1.HeaderText = "Prezime i ime";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kontrola";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kontrola";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ocjena";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ocjena";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Komentar";
            this.dataGridViewTextBoxColumn5.HeaderText = "Komentar";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Project ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Project ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Project";
            this.dataGridViewTextBoxColumn7.HeaderText = "Project";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Val";
            this.dataGridViewTextBoxColumn8.HeaderText = "Val";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Val_ime";
            this.dataGridViewTextBoxColumn9.HeaderText = "Val_ime";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // komentariKontroleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 360);
            this.Controls.Add(this.tblImportKomentariDataGridView);
            this.Controls.Add(this.tblImportKomentariBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "komentariKontroleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emRec -[komentari kontrole]";
            this.Load += new System.EventHandler(this.komentariKontroleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pulsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportKomentariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportKomentariBindingNavigator)).EndInit();
            this.tblImportKomentariBindingNavigator.ResumeLayout(false);
            this.tblImportKomentariBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportKomentariDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PulsDBDataSet pulsDBDataSet;
        public System.Windows.Forms.BindingSource tblImportKomentariBindingSource;
        public PulsDBDataSetTableAdapters.tblImportKomentariTableAdapter tblImportKomentariTableAdapter;
        public PulsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingNavigator tblImportKomentariBindingNavigator;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        public System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.DataGridView tblImportKomentariDataGridView;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
namespace emRec_project
{
    partial class statistikaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statistikaForm));
            this.pulsDBDataSet = new emRec_project.PulsDBDataSet();
            this.tblImportStatisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblImportStatisticsTableAdapter = new emRec_project.PulsDBDataSetTableAdapters.tblImportStatisticsTableAdapter();
            this.tableAdapterManager = new emRec_project.PulsDBDataSetTableAdapters.TableAdapterManager();
            this.tblImportStatisticsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblImportStatisticsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pulsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportStatisticsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportStatisticsBindingNavigator)).BeginInit();
            this.tblImportStatisticsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportStatisticsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pulsDBDataSet
            // 
            this.pulsDBDataSet.DataSetName = "PulsDBDataSet";
            this.pulsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblImportStatisticsBindingSource
            // 
            this.tblImportStatisticsBindingSource.DataMember = "tblImportStatistics";
            this.tblImportStatisticsBindingSource.DataSource = this.pulsDBDataSet;
            // 
            // tblImportStatisticsTableAdapter
            // 
            this.tblImportStatisticsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblAnketaTableAdapter = null;
            this.tableAdapterManager.tblImportKomentariTableAdapter = null;
            this.tableAdapterManager.tblImportStatisticsTableAdapter = this.tblImportStatisticsTableAdapter;
            this.tableAdapterManager.tblProjektiTableAdapter = null;
            this.tableAdapterManager.tblPulsiciTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = emRec_project.PulsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblImportStatisticsBindingNavigator
            // 
            this.tblImportStatisticsBindingNavigator.AddNewItem = null;
            this.tblImportStatisticsBindingNavigator.BindingSource = this.tblImportStatisticsBindingSource;
            this.tblImportStatisticsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblImportStatisticsBindingNavigator.DeleteItem = null;
            this.tblImportStatisticsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tblImportStatisticsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblImportStatisticsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblImportStatisticsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblImportStatisticsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblImportStatisticsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblImportStatisticsBindingNavigator.Name = "tblImportStatisticsBindingNavigator";
            this.tblImportStatisticsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblImportStatisticsBindingNavigator.Size = new System.Drawing.Size(727, 25);
            this.tblImportStatisticsBindingNavigator.TabIndex = 0;
            this.tblImportStatisticsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblImportStatisticsDataGridView
            // 
            this.tblImportStatisticsDataGridView.AllowUserToAddRows = false;
            this.tblImportStatisticsDataGridView.AllowUserToDeleteRows = false;
            this.tblImportStatisticsDataGridView.AutoGenerateColumns = false;
            this.tblImportStatisticsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tblImportStatisticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblImportStatisticsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tblImportStatisticsDataGridView.DataSource = this.tblImportStatisticsBindingSource;
            this.tblImportStatisticsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblImportStatisticsDataGridView.GridColor = System.Drawing.Color.White;
            this.tblImportStatisticsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tblImportStatisticsDataGridView.Name = "tblImportStatisticsDataGridView";
            this.tblImportStatisticsDataGridView.ReadOnly = true;
            this.tblImportStatisticsDataGridView.Size = new System.Drawing.Size(727, 422);
            this.tblImportStatisticsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pulsic";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pulsic";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime i ime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime i ime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "res/h";
            this.dataGridViewTextBoxColumn4.HeaderText = "res/h";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "poz/h";
            this.dataGridViewTextBoxColumn5.HeaderText = "poz/h";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "klasa";
            this.dataGridViewTextBoxColumn6.HeaderText = "klasa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "vrijeme";
            this.dataGridViewTextBoxColumn7.HeaderText = "vrijeme";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "resp";
            this.dataGridViewTextBoxColumn8.HeaderText = "resp";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // statistikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 447);
            this.Controls.Add(this.tblImportStatisticsDataGridView);
            this.Controls.Add(this.tblImportStatisticsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "statistikaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emRec - [statistika]";
            this.Load += new System.EventHandler(this.statistikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pulsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportStatisticsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportStatisticsBindingNavigator)).EndInit();
            this.tblImportStatisticsBindingNavigator.ResumeLayout(false);
            this.tblImportStatisticsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblImportStatisticsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PulsDBDataSet pulsDBDataSet;
        public System.Windows.Forms.BindingSource tblImportStatisticsBindingSource;
        public PulsDBDataSetTableAdapters.tblImportStatisticsTableAdapter tblImportStatisticsTableAdapter;
        public PulsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingNavigator tblImportStatisticsBindingNavigator;
        public System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        public System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        public System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.DataGridView tblImportStatisticsDataGridView;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;


    }
}
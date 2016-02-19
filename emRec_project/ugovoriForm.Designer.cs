namespace emRec_project
{
    partial class ugovoriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ugovoriForm));
            this.pulsDBDataSet = new emRec_project.PulsDBDataSet();
            this.tblPulsiciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPulsiciTableAdapter = new emRec_project.PulsDBDataSetTableAdapters.tblPulsiciTableAdapter();
            this.tableAdapterManager = new emRec_project.PulsDBDataSetTableAdapters.TableAdapterManager();
            this.tblPulsiciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblPulsiciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblPulsiciDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pulsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPulsiciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPulsiciBindingNavigator)).BeginInit();
            this.tblPulsiciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPulsiciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pulsDBDataSet
            // 
            this.pulsDBDataSet.DataSetName = "PulsDBDataSet";
            this.pulsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPulsiciBindingSource
            // 
            this.tblPulsiciBindingSource.DataMember = "tblPulsici";
            this.tblPulsiciBindingSource.DataSource = this.pulsDBDataSet;
            // 
            // tblPulsiciTableAdapter
            // 
            this.tblPulsiciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblImportKomentariTableAdapter = null;
            this.tableAdapterManager.tblImportStatisticsTableAdapter = null;
            this.tableAdapterManager.tblProjektiTableAdapter = null;
            this.tableAdapterManager.tblPulsiciTableAdapter = this.tblPulsiciTableAdapter;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = emRec_project.PulsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblPulsiciBindingNavigator
            // 
            this.tblPulsiciBindingNavigator.AddNewItem = null;
            this.tblPulsiciBindingNavigator.BindingSource = this.tblPulsiciBindingSource;
            this.tblPulsiciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblPulsiciBindingNavigator.DeleteItem = null;
            this.tblPulsiciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tblPulsiciBindingNavigatorSaveItem});
            this.tblPulsiciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblPulsiciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblPulsiciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblPulsiciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblPulsiciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblPulsiciBindingNavigator.Name = "tblPulsiciBindingNavigator";
            this.tblPulsiciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblPulsiciBindingNavigator.Size = new System.Drawing.Size(374, 25);
            this.tblPulsiciBindingNavigator.TabIndex = 0;
            this.tblPulsiciBindingNavigator.Text = "bindingNavigator1";
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
            // tblPulsiciBindingNavigatorSaveItem
            // 
            this.tblPulsiciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblPulsiciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblPulsiciBindingNavigatorSaveItem.Image")));
            this.tblPulsiciBindingNavigatorSaveItem.Name = "tblPulsiciBindingNavigatorSaveItem";
            this.tblPulsiciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblPulsiciBindingNavigatorSaveItem.Text = "Save Data";
            this.tblPulsiciBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblPulsiciBindingNavigatorSaveItem_Click);
            // 
            // tblPulsiciDataGridView
            // 
            this.tblPulsiciDataGridView.AutoGenerateColumns = false;
            this.tblPulsiciDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblPulsiciDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tblPulsiciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPulsiciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.tblPulsiciDataGridView.DataSource = this.tblPulsiciBindingSource;
            this.tblPulsiciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPulsiciDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tblPulsiciDataGridView.Name = "tblPulsiciDataGridView";
            this.tblPulsiciDataGridView.Size = new System.Drawing.Size(374, 377);
            this.tblPulsiciDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Pulsic";
            this.dataGridViewTextBoxColumn10.HeaderText = "Pulsic";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ugovor";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ugovor";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // ugovoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 402);
            this.Controls.Add(this.tblPulsiciDataGridView);
            this.Controls.Add(this.tblPulsiciBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(390, 440);
            this.Name = "ugovoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emRec- [ugovori]";
            this.Load += new System.EventHandler(this.ugovoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pulsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPulsiciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPulsiciBindingNavigator)).EndInit();
            this.tblPulsiciBindingNavigator.ResumeLayout(false);
            this.tblPulsiciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPulsiciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PulsDBDataSet pulsDBDataSet;
        private System.Windows.Forms.BindingSource tblPulsiciBindingSource;
        private PulsDBDataSetTableAdapters.tblPulsiciTableAdapter tblPulsiciTableAdapter;
        private PulsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblPulsiciBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblPulsiciBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblPulsiciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
namespace emRec_project
{
    partial class projektiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projektiForm));
            this.pulsDBDataSet = new emRec_project.PulsDBDataSet();
            this.tblProjektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProjektiTableAdapter = new emRec_project.PulsDBDataSetTableAdapters.tblProjektiTableAdapter();
            this.tableAdapterManager = new emRec_project.PulsDBDataSetTableAdapters.TableAdapterManager();
            this.tblProjektiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblProjektiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblProjektiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pulsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjektiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjektiBindingNavigator)).BeginInit();
            this.tblProjektiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjektiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pulsDBDataSet
            // 
            this.pulsDBDataSet.DataSetName = "PulsDBDataSet";
            this.pulsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProjektiBindingSource
            // 
            this.tblProjektiBindingSource.DataMember = "tblProjekti";
            this.tblProjektiBindingSource.DataSource = this.pulsDBDataSet;
            // 
            // tblProjektiTableAdapter
            // 
            this.tblProjektiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblImportKomentariTableAdapter = null;
            this.tableAdapterManager.tblImportStatisticsTableAdapter = null;
            this.tableAdapterManager.tblProjektiTableAdapter = this.tblProjektiTableAdapter;
            this.tableAdapterManager.tblPulsiciTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = emRec_project.PulsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblProjektiBindingNavigator
            // 
            this.tblProjektiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblProjektiBindingNavigator.BindingSource = this.tblProjektiBindingSource;
            this.tblProjektiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblProjektiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblProjektiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblProjektiBindingNavigatorSaveItem});
            this.tblProjektiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblProjektiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblProjektiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblProjektiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblProjektiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblProjektiBindingNavigator.Name = "tblProjektiBindingNavigator";
            this.tblProjektiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblProjektiBindingNavigator.Size = new System.Drawing.Size(394, 25);
            this.tblProjektiBindingNavigator.TabIndex = 0;
            this.tblProjektiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // tblProjektiBindingNavigatorSaveItem
            // 
            this.tblProjektiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblProjektiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblProjektiBindingNavigatorSaveItem.Image")));
            this.tblProjektiBindingNavigatorSaveItem.Name = "tblProjektiBindingNavigatorSaveItem";
            this.tblProjektiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblProjektiBindingNavigatorSaveItem.Text = "Save Data";
            this.tblProjektiBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblProjektiBindingNavigatorSaveItem_Click);
            // 
            // tblProjektiDataGridView
            // 
            this.tblProjektiDataGridView.AutoGenerateColumns = false;
            this.tblProjektiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblProjektiDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tblProjektiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProjektiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.tblProjektiDataGridView.DataSource = this.tblProjektiBindingSource;
            this.tblProjektiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProjektiDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tblProjektiDataGridView.Name = "tblProjektiDataGridView";
            this.tblProjektiDataGridView.Size = new System.Drawing.Size(394, 317);
            this.tblProjektiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Project ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Broj projekta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "Project ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Project";
            this.dataGridViewTextBoxColumn2.HeaderText = "Project";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // projektiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 342);
            this.Controls.Add(this.tblProjektiDataGridView);
            this.Controls.Add(this.tblProjektiBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(410, 380);
            this.Name = "projektiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emRec - [projekti]";
            this.Load += new System.EventHandler(this.projektiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pulsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjektiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjektiBindingNavigator)).EndInit();
            this.tblProjektiBindingNavigator.ResumeLayout(false);
            this.tblProjektiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjektiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PulsDBDataSet pulsDBDataSet;
        private System.Windows.Forms.BindingSource tblProjektiBindingSource;
        private PulsDBDataSetTableAdapters.tblProjektiTableAdapter tblProjektiTableAdapter;
        private PulsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblProjektiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblProjektiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblProjektiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
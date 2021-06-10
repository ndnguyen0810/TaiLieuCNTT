namespace Lab07
{
    partial class frmKetQua
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
            System.Windows.Forms.Label dIEMLabel;
            System.Windows.Forms.Label mASOLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetQua));
            this.lab07DataSet = new Lab07.Lab07DataSet();
            this.kETQUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kETQUATableAdapter = new Lab07.Lab07DataSetTableAdapters.KETQUATableAdapter();
            this.tableAdapterManager = new Lab07.Lab07DataSetTableAdapters.TableAdapterManager();
            this.kETQUABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.kETQUABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dIEMTextBox = new System.Windows.Forms.TextBox();
            this.kETQUADataGridView = new System.Windows.Forms.DataGridView();
            this.mASOComboBox = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAMHComboBox = new System.Windows.Forms.ComboBox();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new Lab07.Lab07DataSetTableAdapters.SINHVIENTableAdapter();
            this.mONTableAdapter = new Lab07.Lab07DataSetTableAdapters.MONTableAdapter();
            this.tENMHComboBox = new System.Windows.Forms.ComboBox();
            this.hOTENComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dIEMLabel = new System.Windows.Forms.Label();
            mASOLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lab07DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kETQUABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kETQUABindingNavigator)).BeginInit();
            this.kETQUABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kETQUADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dIEMLabel
            // 
            dIEMLabel.AutoSize = true;
            dIEMLabel.Location = new System.Drawing.Point(59, 152);
            dIEMLabel.Name = "dIEMLabel";
            dIEMLabel.Size = new System.Drawing.Size(54, 24);
            dIEMLabel.TabIndex = 5;
            dIEMLabel.Text = "Điểm";
            // 
            // mASOLabel
            // 
            mASOLabel.AutoSize = true;
            mASOLabel.Location = new System.Drawing.Point(63, 59);
            mASOLabel.Name = "mASOLabel";
            mASOLabel.Size = new System.Drawing.Size(64, 24);
            mASOLabel.TabIndex = 7;
            mASOLabel.Text = "Mã Số";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(59, 106);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(71, 24);
            mAMHLabel.TabIndex = 8;
            mAMHLabel.Text = "Mã MH";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(272, 106);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(84, 24);
            tENMHLabel.TabIndex = 9;
            tENMHLabel.Text = "TENMH:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(273, 59);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(83, 24);
            hOTENLabel.TabIndex = 10;
            hOTENLabel.Text = "HOTEN:";
            // 
            // lab07DataSet
            // 
            this.lab07DataSet.DataSetName = "Lab07DataSet";
            this.lab07DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kETQUABindingSource
            // 
            this.kETQUABindingSource.DataMember = "KETQUA";
            this.kETQUABindingSource.DataSource = this.lab07DataSet;
            // 
            // kETQUATableAdapter
            // 
            this.kETQUATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KETQUATableAdapter = this.kETQUATableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab07.Lab07DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kETQUABindingNavigator
            // 
            this.kETQUABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kETQUABindingNavigator.BindingSource = this.kETQUABindingSource;
            this.kETQUABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kETQUABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kETQUABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kETQUABindingNavigatorSaveItem});
            this.kETQUABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kETQUABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kETQUABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kETQUABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kETQUABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kETQUABindingNavigator.Name = "kETQUABindingNavigator";
            this.kETQUABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kETQUABindingNavigator.Size = new System.Drawing.Size(602, 25);
            this.kETQUABindingNavigator.TabIndex = 0;
            this.kETQUABindingNavigator.Text = "bindingNavigator1";
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
            // kETQUABindingNavigatorSaveItem
            // 
            this.kETQUABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kETQUABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kETQUABindingNavigatorSaveItem.Image")));
            this.kETQUABindingNavigatorSaveItem.Name = "kETQUABindingNavigatorSaveItem";
            this.kETQUABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kETQUABindingNavigatorSaveItem.Text = "Save Data";
            this.kETQUABindingNavigatorSaveItem.Click += new System.EventHandler(this.kETQUABindingNavigatorSaveItem_Click);
            // 
            // dIEMTextBox
            // 
            this.dIEMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kETQUABindingSource, "DIEM", true));
            this.dIEMTextBox.Location = new System.Drawing.Point(139, 149);
            this.dIEMTextBox.Name = "dIEMTextBox";
            this.dIEMTextBox.Size = new System.Drawing.Size(121, 29);
            this.dIEMTextBox.TabIndex = 6;
            // 
            // kETQUADataGridView
            // 
            this.kETQUADataGridView.AutoGenerateColumns = false;
            this.kETQUADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kETQUADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kETQUADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.kETQUADataGridView.DataSource = this.kETQUABindingSource;
            this.kETQUADataGridView.Location = new System.Drawing.Point(0, 223);
            this.kETQUADataGridView.Name = "kETQUADataGridView";
            this.kETQUADataGridView.Size = new System.Drawing.Size(582, 260);
            this.kETQUADataGridView.TabIndex = 7;
            this.kETQUADataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kETQUADataGridView_CellContentClick);
            // 
            // mASOComboBox
            // 
            this.mASOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kETQUABindingSource, "MASO", true));
            this.mASOComboBox.DataSource = this.sINHVIENBindingSource;
            this.mASOComboBox.DisplayMember = "MASO";
            this.mASOComboBox.FormattingEnabled = true;
            this.mASOComboBox.Location = new System.Drawing.Point(140, 56);
            this.mASOComboBox.Name = "mASOComboBox";
            this.mASOComboBox.Size = new System.Drawing.Size(121, 32);
            this.mASOComboBox.TabIndex = 8;
            this.mASOComboBox.ValueMember = "HOTEN";
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.lab07DataSet;
            // 
            // mAMHComboBox
            // 
            this.mAMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kETQUABindingSource, "MAMH", true));
            this.mAMHComboBox.DataSource = this.mONBindingSource;
            this.mAMHComboBox.DisplayMember = "TENMH";
            this.mAMHComboBox.FormattingEnabled = true;
            this.mAMHComboBox.Location = new System.Drawing.Point(139, 103);
            this.mAMHComboBox.Name = "mAMHComboBox";
            this.mAMHComboBox.Size = new System.Drawing.Size(121, 32);
            this.mAMHComboBox.TabIndex = 9;
            this.mAMHComboBox.ValueMember = "MAMH";
            // 
            // mONBindingSource
            // 
            this.mONBindingSource.DataMember = "MON";
            this.mONBindingSource.DataSource = this.lab07DataSet;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // tENMHComboBox
            // 
            this.tENMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONBindingSource, "TENMH", true));
            this.tENMHComboBox.DataSource = this.mONBindingSource;
            this.tENMHComboBox.DisplayMember = "TENMH";
            this.tENMHComboBox.FormattingEnabled = true;
            this.tENMHComboBox.Location = new System.Drawing.Point(362, 103);
            this.tENMHComboBox.Name = "tENMHComboBox";
            this.tENMHComboBox.Size = new System.Drawing.Size(193, 32);
            this.tENMHComboBox.TabIndex = 10;
            // 
            // hOTENComboBox
            // 
            this.hOTENComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "HOTEN", true));
            this.hOTENComboBox.DataSource = this.sINHVIENBindingSource;
            this.hOTENComboBox.DisplayMember = "HOTEN";
            this.hOTENComboBox.FormattingEnabled = true;
            this.hOTENComboBox.Location = new System.Drawing.Point(362, 56);
            this.hOTENComboBox.Name = "hOTENComboBox";
            this.hOTENComboBox.Size = new System.Drawing.Size(193, 32);
            this.hOTENComboBox.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã MH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIEM";
            this.dataGridViewTextBoxColumn3.HeaderText = "Điểm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 503);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.hOTENComboBox);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.tENMHComboBox);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.mAMHComboBox);
            this.Controls.Add(mASOLabel);
            this.Controls.Add(this.mASOComboBox);
            this.Controls.Add(this.kETQUADataGridView);
            this.Controls.Add(dIEMLabel);
            this.Controls.Add(this.dIEMTextBox);
            this.Controls.Add(this.kETQUABindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKetQua";
            this.Text = "frmKetQua";
            this.Load += new System.EventHandler(this.frmKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab07DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kETQUABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kETQUABindingNavigator)).EndInit();
            this.kETQUABindingNavigator.ResumeLayout(false);
            this.kETQUABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kETQUADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab07DataSet lab07DataSet;
        private System.Windows.Forms.BindingSource kETQUABindingSource;
        private Lab07DataSetTableAdapters.KETQUATableAdapter kETQUATableAdapter;
        private Lab07DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kETQUABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kETQUABindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dIEMTextBox;
        private System.Windows.Forms.DataGridView kETQUADataGridView;
        private System.Windows.Forms.ComboBox mASOComboBox;
        private System.Windows.Forms.ComboBox mAMHComboBox;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private Lab07DataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private Lab07DataSetTableAdapters.MONTableAdapter mONTableAdapter;
        private System.Windows.Forms.ComboBox tENMHComboBox;
        private System.Windows.Forms.ComboBox hOTENComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
namespace WinFormUI
{
    partial class frmAdminFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminFood));
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.mnsFood = new System.Windows.Forms.MenuStrip();
            this.tsmMealType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvMealView = new System.Windows.Forms.DataGridView();
            this.Aktif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlData = new System.Windows.Forms.Panel();
            this.mnsFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealView)).BeginInit();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(16, 28);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(226, 28);
            this.cmbCategory.TabIndex = 1;
            // 
            // mnsFood
            // 
            this.mnsFood.BackColor = System.Drawing.Color.Transparent;
            this.mnsFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnsFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnsFood.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnsFood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMealType,
            this.tsmCategory});
            this.mnsFood.Location = new System.Drawing.Point(0, 0);
            this.mnsFood.Name = "mnsFood";
            this.mnsFood.Size = new System.Drawing.Size(813, 24);
            this.mnsFood.TabIndex = 3;
            this.mnsFood.Text = "menuStrip1";
            // 
            // tsmMealType
            // 
            this.tsmMealType.Name = "tsmMealType";
            this.tsmMealType.Size = new System.Drawing.Size(98, 20);
            this.tsmMealType.Text = "Öğün Düzenle";
            this.tsmMealType.Click += new System.EventHandler(this.tsmMealType_Click);
            // 
            // tsmCategory
            // 
            this.tsmCategory.Name = "tsmCategory";
            this.tsmCategory.Size = new System.Drawing.Size(114, 20);
            this.tsmCategory.Text = "Kategori Düzenle";
            this.tsmCategory.Click += new System.EventHandler(this.tsmCategory_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(248, 28);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(85, 29);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(339, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 29);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(617, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 29);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Seçimi Düzenle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(504, 28);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(107, 29);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Yeni Ekle";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::WinFormUI.Properties.Resources.minus;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(759, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // dgvMealView
            // 
            this.dgvMealView.AllowUserToAddRows = false;
            this.dgvMealView.AllowUserToDeleteRows = false;
            this.dgvMealView.AllowUserToOrderColumns = true;
            this.dgvMealView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvMealView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMealView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMealView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aktif,
            this.clmCategory,
            this.clmFood,
            this.clmCalorie,
            this.clmImg,
            this.clmId});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMealView.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMealView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealView.Location = new System.Drawing.Point(0, 0);
            this.dgvMealView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMealView.MultiSelect = false;
            this.dgvMealView.Name = "dgvMealView";
            this.dgvMealView.ReadOnly = true;
            this.dgvMealView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Format = "N1";
            dataGridViewCellStyle10.NullValue = "1";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMealView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMealView.RowHeadersVisible = false;
            this.dgvMealView.RowHeadersWidth = 40;
            this.dgvMealView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMealView.RowTemplate.Height = 100;
            this.dgvMealView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMealView.Size = new System.Drawing.Size(813, 355);
            this.dgvMealView.TabIndex = 5;
            this.dgvMealView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvMealView_CellPainting);
            this.dgvMealView.SelectionChanged += new System.EventHandler(this.dgvMealView_SelectionChanged);
            // 
            // Aktif
            // 
            this.Aktif.Frozen = true;
            this.Aktif.HeaderText = "Aktif";
            this.Aktif.Name = "Aktif";
            this.Aktif.ReadOnly = true;
            this.Aktif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aktif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Aktif.Width = 50;
            // 
            // clmCategory
            // 
            this.clmCategory.Frozen = true;
            this.clmCategory.HeaderText = "Kategori";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            this.clmCategory.Width = 200;
            // 
            // clmFood
            // 
            this.clmFood.Frozen = true;
            this.clmFood.HeaderText = "Yemek";
            this.clmFood.Name = "clmFood";
            this.clmFood.ReadOnly = true;
            this.clmFood.Width = 240;
            // 
            // clmCalorie
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            this.clmCalorie.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmCalorie.Frozen = true;
            this.clmCalorie.HeaderText = "Birim Kalori";
            this.clmCalorie.Name = "clmCalorie";
            this.clmCalorie.ReadOnly = true;
            this.clmCalorie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCalorie.Width = 120;
            // 
            // clmImg
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            this.clmImg.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmImg.Frozen = true;
            this.clmImg.HeaderText = "Resim";
            this.clmImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmImg.Name = "clmImg";
            this.clmImg.ReadOnly = true;
            this.clmImg.Width = 200;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // pnlData
            // 
            this.pnlData.AutoScroll = true;
            this.pnlData.Controls.Add(this.dgvMealView);
            this.pnlData.Location = new System.Drawing.Point(0, 75);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(813, 355);
            this.pnlData.TabIndex = 7;
            this.pnlData.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlData_Scroll);
            // 
            // frmAdminFood
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 430);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.mnsFood);
            this.Controls.Add(this.pnlData);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnsFood;
            this.MaximumSize = new System.Drawing.Size(813, 430);
            this.MinimumSize = new System.Drawing.Size(813, 430);
            this.Name = "frmAdminFood";
            this.Text = "frmAdminFood";
            this.mnsFood.ResumeLayout(false);
            this.mnsFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealView)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbCategory;
        private MenuStrip mnsFood;
        private ToolStripMenuItem tsmMealType;
        private ToolStripMenuItem tsmCategory;
        private Button btnFilter;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAddNew;
        private Button btnDelete;
        private DataGridView dgvMealView;
        private DataGridViewCheckBoxColumn Aktif;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmFood;
        private DataGridViewTextBoxColumn clmCalorie;
        private DataGridViewImageColumn clmImg;
        private DataGridViewTextBoxColumn clmId;
        private Panel pnlData;
    }
}
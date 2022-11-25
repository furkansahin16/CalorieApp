namespace WinFormUI
{
    partial class frmAddMeal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.cmbMealCategory = new System.Windows.Forms.ComboBox();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.lblDataGridView = new System.Windows.Forms.Label();
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            this.lstMeal = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.btnAddMealType = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nmdPortion = new System.Windows.Forms.NumericUpDown();
            this.lblGram = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCalorieCal = new System.Windows.Forms.Label();
            this.lblMealType = new System.Windows.Forms.Label();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdPortion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(267, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(161, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "ÖĞÜN EKLE";
            // 
            // cmbMealType
            // 
            this.cmbMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Location = new System.Drawing.Point(12, 59);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(192, 28);
            this.cmbMealType.TabIndex = 1;
            // 
            // cmbMealCategory
            // 
            this.cmbMealCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealCategory.FormattingEnabled = true;
            this.cmbMealCategory.Location = new System.Drawing.Point(12, 129);
            this.cmbMealCategory.Name = "cmbMealCategory";
            this.cmbMealCategory.Size = new System.Drawing.Size(157, 28);
            this.cmbMealCategory.TabIndex = 3;
            this.cmbMealCategory.SelectedIndexChanged += new System.EventHandler(this.cmbMealCategory_SelectedIndexChanged);
            // 
            // cmbFood
            // 
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(185, 129);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(157, 28);
            this.cmbFood.TabIndex = 4;
            this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.cmbFood_SelectedIndexChanged);
            this.cmbFood.SelectedValueChanged += new System.EventHandler(this.nmdPortion_ValueChanged);
            // 
            // lblDataGridView
            // 
            this.lblDataGridView.AutoSize = true;
            this.lblDataGridView.BackColor = System.Drawing.Color.Transparent;
            this.lblDataGridView.ForeColor = System.Drawing.Color.Black;
            this.lblDataGridView.Location = new System.Drawing.Point(264, 170);
            this.lblDataGridView.Name = "lblDataGridView";
            this.lblDataGridView.Size = new System.Drawing.Size(160, 20);
            this.lblDataGridView.TabIndex = 0;
            this.lblDataGridView.Text = "GÜNLÜK ÖĞÜNLER";
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.AllowUserToAddRows = false;
            this.dgvDailyReport.AllowUserToDeleteRows = false;
            this.dgvDailyReport.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvDailyReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailyReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvDailyReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailyReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCategory,
            this.clmFood,
            this.clmImg,
            this.clmPiece,
            this.clmCalorie,
            this.clmId});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDailyReport.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDailyReport.Location = new System.Drawing.Point(155, 207);
            this.dgvDailyReport.MultiSelect = false;
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.ReadOnly = true;
            this.dgvDailyReport.RowHeadersVisible = false;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.dgvDailyReport.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDailyReport.RowTemplate.Height = 40;
            this.dgvDailyReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDailyReport.Size = new System.Drawing.Size(501, 220);
            this.dgvDailyReport.TabIndex = 3;
            this.dgvDailyReport.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDailyReport_CellPainting);
            this.dgvDailyReport.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDailyReport_DataError);
            // 
            // lstMeal
            // 
            this.lstMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lstMeal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstMeal.ForeColor = System.Drawing.Color.White;
            this.lstMeal.FormattingEnabled = true;
            this.lstMeal.ItemHeight = 20;
            this.lstMeal.Location = new System.Drawing.Point(12, 207);
            this.lstMeal.Name = "lstMeal";
            this.lstMeal.Size = new System.Drawing.Size(128, 220);
            this.lstMeal.TabIndex = 4;
            this.lstMeal.SelectedIndexChanged += new System.EventHandler(this.lstMeal_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::WinFormUI.Properties.Resources.plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(563, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.BackColor = System.Drawing.Color.Transparent;
            this.pbProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbProduct.Location = new System.Drawing.Point(573, 24);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(82, 82);
            this.pbProduct.TabIndex = 5;
            this.pbProduct.TabStop = false;
            // 
            // btnAddMealType
            // 
            this.btnAddMealType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddMealType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMealType.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddMealType.FlatAppearance.BorderSize = 0;
            this.btnAddMealType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAddMealType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddMealType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMealType.ForeColor = System.Drawing.Color.White;
            this.btnAddMealType.Location = new System.Drawing.Point(217, 59);
            this.btnAddMealType.Name = "btnAddMealType";
            this.btnAddMealType.Size = new System.Drawing.Size(72, 29);
            this.btnAddMealType.TabIndex = 2;
            this.btnAddMealType.Text = "EKLE";
            this.btnAddMealType.UseVisualStyleBackColor = false;
            this.btnAddMealType.Click += new System.EventHandler(this.btnAddMealType_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::WinFormUI.Properties.Resources.minus;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(617, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nmdPortion
            // 
            this.nmdPortion.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmdPortion.Location = new System.Drawing.Point(362, 131);
            this.nmdPortion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmdPortion.Name = "nmdPortion";
            this.nmdPortion.Size = new System.Drawing.Size(85, 26);
            this.nmdPortion.TabIndex = 5;
            this.nmdPortion.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmdPortion.ValueChanged += new System.EventHandler(this.nmdPortion_ValueChanged);
            // 
            // lblGram
            // 
            this.lblGram.AutoSize = true;
            this.lblGram.BackColor = System.Drawing.Color.Transparent;
            this.lblGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGram.ForeColor = System.Drawing.Color.Black;
            this.lblGram.Location = new System.Drawing.Point(360, 109);
            this.lblGram.Name = "lblGram";
            this.lblGram.Size = new System.Drawing.Size(46, 16);
            this.lblGram.TabIndex = 0;
            this.lblGram.Text = "Gram :";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.Transparent;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFood.ForeColor = System.Drawing.Color.Black;
            this.lblFood.Location = new System.Drawing.Point(185, 109);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(56, 16);
            this.lblFood.TabIndex = 0;
            this.lblFood.Text = "Yemek :";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(12, 109);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(60, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori:";
            // 
            // lblCalorieCal
            // 
            this.lblCalorieCal.AutoSize = true;
            this.lblCalorieCal.BackColor = System.Drawing.Color.Transparent;
            this.lblCalorieCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalorieCal.ForeColor = System.Drawing.Color.Black;
            this.lblCalorieCal.Location = new System.Drawing.Point(453, 136);
            this.lblCalorieCal.Name = "lblCalorieCal";
            this.lblCalorieCal.Size = new System.Drawing.Size(51, 16);
            this.lblCalorieCal.TabIndex = 0;
            this.lblCalorieCal.Text = "0 Kalori";
            // 
            // lblMealType
            // 
            this.lblMealType.AutoSize = true;
            this.lblMealType.BackColor = System.Drawing.Color.Transparent;
            this.lblMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMealType.ForeColor = System.Drawing.Color.Black;
            this.lblMealType.Location = new System.Drawing.Point(12, 39);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(45, 16);
            this.lblMealType.TabIndex = 0;
            this.lblMealType.Text = "Öğün :";
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Kategori";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            this.clmCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCategory.Width = 120;
            // 
            // clmFood
            // 
            this.clmFood.HeaderText = "Yemek";
            this.clmFood.Name = "clmFood";
            this.clmFood.ReadOnly = true;
            this.clmFood.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmFood.Width = 150;
            // 
            // clmImg
            // 
            this.clmImg.HeaderText = "Resim";
            this.clmImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.clmImg.Name = "clmImg";
            this.clmImg.ReadOnly = true;
            // 
            // clmPiece
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.clmPiece.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmPiece.HeaderText = "Gram";
            this.clmPiece.Name = "clmPiece";
            this.clmPiece.ReadOnly = true;
            this.clmPiece.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPiece.Width = 65;
            // 
            // clmCalorie
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.clmCalorie.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmCalorie.HeaderText = "Kalori";
            this.clmCalorie.Name = "clmCalorie";
            this.clmCalorie.ReadOnly = true;
            this.clmCalorie.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCalorie.Width = 65;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // frmAddMeal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.nmdPortion);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.lstMeal);
            this.Controls.Add(this.dgvDailyReport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddMealType);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.cmbMealCategory);
            this.Controls.Add(this.cmbMealType);
            this.Controls.Add(this.lblMealType);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblCalorieCal);
            this.Controls.Add(this.lblGram);
            this.Controls.Add(this.lblDataGridView);
            this.Controls.Add(this.lblHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(675, 450);
            this.MinimumSize = new System.Drawing.Size(675, 450);
            this.Name = "frmAddMeal";
            this.Text = "ÖĞÜN EKLE";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdPortion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHeader;
        private ComboBox cmbMealType;
        private ComboBox cmbMealCategory;
        private ComboBox cmbFood;
        private Label lblDataGridView;
        private DataGridView dgvDailyReport;
        private ListBox lstMeal;
        private Button btnAdd;
        private PictureBox pbProduct;
        private Button btnAddMealType;
        private Button btnDelete;
        private NumericUpDown nmdPortion;
        private Label lblGram;
        private Label lblFood;
        private Label lblCategory;
        private Label lblCalorieCal;
        private Label lblMealType;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmFood;
        private DataGridViewImageColumn clmImg;
        private DataGridViewTextBoxColumn clmPiece;
        private DataGridViewTextBoxColumn clmCalorie;
        private DataGridViewTextBoxColumn clmId;
    }
}
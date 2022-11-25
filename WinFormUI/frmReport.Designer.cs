namespace WinFormUI
{
    partial class frmReport
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
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.dgvMealView = new System.Windows.Forms.DataGridView();
            this.clmCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDailyCalorie = new System.Windows.Forms.Label();
            this.lblCalorieValue = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lstMealType = new System.Windows.Forms.ListBox();
            this.lblMealCalorie = new System.Windows.Forms.Label();
            this.lblMealCalorieValue = new System.Windows.Forms.Label();
            this.btnDeleteMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDay
            // 
            this.dtpDay.CalendarForeColor = System.Drawing.SystemColors.Window;
            this.dtpDay.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.dtpDay.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.dtpDay.CalendarTrailingForeColor = System.Drawing.SystemColors.Window;
            this.dtpDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDay.Location = new System.Drawing.Point(35, 29);
            this.dtpDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(210, 26);
            this.dtpDay.TabIndex = 1;
            // 
            // dgvMealView
            // 
            this.dgvMealView.AllowUserToAddRows = false;
            this.dgvMealView.AllowUserToDeleteRows = false;
            this.dgvMealView.AllowUserToOrderColumns = true;
            this.dgvMealView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMealView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvMealView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMealView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMealView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCategory,
            this.clmFood,
            this.clmImg,
            this.clmPiece,
            this.clmCalorie,
            this.clmID});
            this.dgvMealView.Location = new System.Drawing.Point(196, 80);
            this.dgvMealView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMealView.MultiSelect = false;
            this.dgvMealView.Name = "dgvMealView";
            this.dgvMealView.ReadOnly = true;
            this.dgvMealView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = "1";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMealView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMealView.RowHeadersVisible = false;
            this.dgvMealView.RowHeadersWidth = 40;
            this.dgvMealView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMealView.RowTemplate.Height = 40;
            this.dgvMealView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMealView.Size = new System.Drawing.Size(441, 300);
            this.dgvMealView.TabIndex = 3;
            this.dgvMealView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvMealView_CellPainting);
            // 
            // clmCategory
            // 
            this.clmCategory.HeaderText = "Kategori";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            // 
            // clmFood
            // 
            this.clmFood.HeaderText = "Yemek";
            this.clmFood.Name = "clmFood";
            this.clmFood.ReadOnly = true;
            this.clmFood.Width = 130;
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
            this.clmPiece.HeaderText = "Gram";
            this.clmPiece.Name = "clmPiece";
            this.clmPiece.ReadOnly = true;
            this.clmPiece.Width = 55;
            // 
            // clmCalorie
            // 
            this.clmCalorie.HeaderText = "Kalori";
            this.clmCalorie.Name = "clmCalorie";
            this.clmCalorie.ReadOnly = true;
            this.clmCalorie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCalorie.Width = 55;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            // 
            // lblDailyCalorie
            // 
            this.lblDailyCalorie.AutoSize = true;
            this.lblDailyCalorie.BackColor = System.Drawing.Color.Transparent;
            this.lblDailyCalorie.Location = new System.Drawing.Point(34, 415);
            this.lblDailyCalorie.Name = "lblDailyCalorie";
            this.lblDailyCalorie.Size = new System.Drawing.Size(167, 20);
            this.lblDailyCalorie.TabIndex = 2;
            this.lblDailyCalorie.Text = "Günlük Toplam Kalori :";
            // 
            // lblCalorieValue
            // 
            this.lblCalorieValue.AutoSize = true;
            this.lblCalorieValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCalorieValue.Location = new System.Drawing.Point(222, 411);
            this.lblCalorieValue.Name = "lblCalorieValue";
            this.lblCalorieValue.Size = new System.Drawing.Size(0, 20);
            this.lblCalorieValue.TabIndex = 2;
            // 
            // btnGetReport
            // 
            this.btnGetReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGetReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGetReport.FlatAppearance.BorderSize = 0;
            this.btnGetReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGetReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGetReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetReport.ForeColor = System.Drawing.Color.White;
            this.btnGetReport.Location = new System.Drawing.Point(279, 29);
            this.btnGetReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(83, 27);
            this.btnGetReport.TabIndex = 2;
            this.btnGetReport.Text = "Raporla";
            this.btnGetReport.UseVisualStyleBackColor = false;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(313, 400);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Düzenle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(541, 400);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(5, 4, 3, 4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(96, 35);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Yemek Sil";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lstMealType
            // 
            this.lstMealType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lstMealType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstMealType.ForeColor = System.Drawing.Color.White;
            this.lstMealType.FormattingEnabled = true;
            this.lstMealType.ItemHeight = 20;
            this.lstMealType.Location = new System.Drawing.Point(35, 80);
            this.lstMealType.Name = "lstMealType";
            this.lstMealType.Size = new System.Drawing.Size(144, 300);
            this.lstMealType.TabIndex = 6;
            this.lstMealType.SelectedIndexChanged += new System.EventHandler(this.lstMealType_SelectedIndexChanged);
            // 
            // lblMealCalorie
            // 
            this.lblMealCalorie.AutoSize = true;
            this.lblMealCalorie.BackColor = System.Drawing.Color.Transparent;
            this.lblMealCalorie.Location = new System.Drawing.Point(34, 391);
            this.lblMealCalorie.Name = "lblMealCalorie";
            this.lblMealCalorie.Size = new System.Drawing.Size(155, 20);
            this.lblMealCalorie.TabIndex = 2;
            this.lblMealCalorie.Text = "Öğün Toplam Kalori :";
            // 
            // lblMealCalorieValue
            // 
            this.lblMealCalorieValue.AutoSize = true;
            this.lblMealCalorieValue.BackColor = System.Drawing.Color.Transparent;
            this.lblMealCalorieValue.Location = new System.Drawing.Point(222, 387);
            this.lblMealCalorieValue.Name = "lblMealCalorieValue";
            this.lblMealCalorieValue.Size = new System.Drawing.Size(0, 20);
            this.lblMealCalorieValue.TabIndex = 2;
            // 
            // btnDeleteMeal
            // 
            this.btnDeleteMeal.BackColor = System.Drawing.Color.Red;
            this.btnDeleteMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMeal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteMeal.FlatAppearance.BorderSize = 0;
            this.btnDeleteMeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDeleteMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDeleteMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteMeal.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMeal.Location = new System.Drawing.Point(427, 400);
            this.btnDeleteMeal.Margin = new System.Windows.Forms.Padding(5, 4, 3, 4);
            this.btnDeleteMeal.Name = "btnDeleteMeal";
            this.btnDeleteMeal.Size = new System.Drawing.Size(96, 35);
            this.btnDeleteMeal.TabIndex = 5;
            this.btnDeleteMeal.Text = "Öğün Sil";
            this.btnDeleteMeal.UseVisualStyleBackColor = false;
            this.btnDeleteMeal.Click += new System.EventHandler(this.btnDeleteMeal_Click);
            // 
            // frmReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.lstMealType);
            this.Controls.Add(this.btnDeleteMeal);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.lblMealCalorieValue);
            this.Controls.Add(this.lblCalorieValue);
            this.Controls.Add(this.lblMealCalorie);
            this.Controls.Add(this.lblDailyCalorie);
            this.Controls.Add(this.dgvMealView);
            this.Controls.Add(this.dtpDay);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(675, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(675, 450);
            this.Name = "frmReport";
            this.Text = "frmReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpDay;
        private DataGridView dgvMealView;
        private Label lblDailyCalorie;
        private Label lblCalorieValue;
        private Button btnGetReport;
        private Button btnUpdate;
        private Button btnDeleteProduct;
        private ListBox lstMealType;
        private Label lblMealCalorie;
        private Label lblMealCalorieValue;
        private Button btnDeleteMeal;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmFood;
        private DataGridViewImageColumn clmImg;
        private DataGridViewTextBoxColumn clmPiece;
        private DataGridViewTextBoxColumn clmCalorie;
        private DataGridViewTextBoxColumn clmID;
    }
}
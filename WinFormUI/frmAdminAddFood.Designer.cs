namespace WinFormUI
{
    partial class frmAdminAddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminAddFood));
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.nmdUnitCalorie = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdUnitCalorie)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(33, 72);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.PlaceholderText = "Yemek Adı";
            this.txtFoodName.Size = new System.Drawing.Size(268, 26);
            this.txtFoodName.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(33, 27);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(268, 28);
            this.cmbCategory.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(112, 247);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImg.ForeColor = System.Drawing.Color.White;
            this.btnImg.Location = new System.Drawing.Point(174, 189);
            this.btnImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(127, 39);
            this.btnImg.TabIndex = 2;
            this.btnImg.Text = "Resim Ekle";
            this.btnImg.UseVisualStyleBackColor = false;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.Transparent;
            this.pbProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProductImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbProductImage.Location = new System.Drawing.Point(33, 153);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(75, 75);
            this.pbProductImage.TabIndex = 4;
            this.pbProductImage.TabStop = false;
            // 
            // nmdUnitCalorie
            // 
            this.nmdUnitCalorie.DecimalPlaces = 2;
            this.nmdUnitCalorie.Location = new System.Drawing.Point(33, 113);
            this.nmdUnitCalorie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nmdUnitCalorie.Name = "nmdUnitCalorie";
            this.nmdUnitCalorie.Size = new System.Drawing.Size(270, 26);
            this.nmdUnitCalorie.TabIndex = 5;
            // 
            // frmAdminAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(338, 302);
            this.Controls.Add(this.nmdUnitCalorie);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtFoodName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(354, 341);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(354, 341);
            this.Name = "frmAdminAddFood";
            this.Text = "RUFİT - Yemek Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdUnitCalorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFoodName;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private Button btnImg;
        private PictureBox pbProductImage;
        private NumericUpDown nmdUnitCalorie;
    }
}
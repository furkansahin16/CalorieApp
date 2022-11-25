namespace WinFormUI
{
    partial class frmAdminUpdateFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminUpdateFood));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.nmdUnitCalorie = new System.Windows.Forms.NumericUpDown();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdUnitCalorie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(101, 264);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.Transparent;
            this.pbProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProductImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbProductImage.Location = new System.Drawing.Point(27, 160);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(80, 80);
            this.pbProductImage.TabIndex = 8;
            this.pbProductImage.TabStop = false;
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImg.ForeColor = System.Drawing.Color.White;
            this.btnImg.Location = new System.Drawing.Point(146, 200);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(123, 40);
            this.btnImg.TabIndex = 7;
            this.btnImg.Text = "Resmi Değiştir";
            this.btnImg.UseVisualStyleBackColor = false;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // nmdUnitCalorie
            // 
            this.nmdUnitCalorie.DecimalPlaces = 2;
            this.nmdUnitCalorie.Location = new System.Drawing.Point(27, 117);
            this.nmdUnitCalorie.Name = "nmdUnitCalorie";
            this.nmdUnitCalorie.Size = new System.Drawing.Size(240, 26);
            this.nmdUnitCalorie.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(27, 69);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "Yemek";
            this.txtProductName.Size = new System.Drawing.Size(238, 26);
            this.txtProductName.TabIndex = 10;
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(27, 23);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PlaceholderText = "Kategori";
            this.txtCategory.Size = new System.Drawing.Size(238, 26);
            this.txtCategory.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(187, 160);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Aktif Mi";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // frmAdminUpdateFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(298, 322);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.nmdUnitCalorie);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnUpdate);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(314, 361);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(314, 361);
            this.Name = "frmAdminUpdateFood";
            this.Text = "RUFİT - Yemek Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdUnitCalorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private PictureBox pbProductImage;
        private Button btnImg;
        private NumericUpDown nmdUnitCalorie;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private CheckBox checkBox1;
    }
}
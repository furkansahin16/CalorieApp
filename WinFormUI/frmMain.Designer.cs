namespace WinFormUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnUpdateMeal = new System.Windows.Forms.Button();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.pnlNavItems = new System.Windows.Forms.Panel();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavigation.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.pnlNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNavigation.Controls.Add(this.lblAppName);
            this.pnlNavigation.Controls.Add(this.pictureBox1);
            this.pnlNavigation.Controls.Add(this.btnClose);
            this.pnlNavigation.Controls.Add(this.btnAccount);
            this.pnlNavigation.Controls.Add(this.btnUpdateMeal);
            this.pnlNavigation.Controls.Add(this.btnAddMeal);
            this.pnlNavigation.Controls.Add(this.btnMainPage);
            this.pnlNavigation.Controls.Add(this.lblCurrentDate);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(275, 450);
            this.pnlNavigation.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.ForeColor = System.Drawing.Color.Chocolate;
            this.lblAppName.Location = new System.Drawing.Point(95, 82);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(99, 33);
            this.lblAppName.TabIndex = 7;
            this.lblAppName.Text = "RUFiT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormUI.Properties.Resources.MainLogo;
            this.pictureBox1.InitialImage = global::WinFormUI.Properties.Resources.MainLogo;
            this.pictureBox1.Location = new System.Drawing.Point(100, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(90, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Çıkış";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(48, 302);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(182, 45);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Tag = "4";
            this.btnAccount.Text = "Hesap";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnNavigation_Click);
            // 
            // btnUpdateMeal
            // 
            this.btnUpdateMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdateMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMeal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdateMeal.FlatAppearance.BorderSize = 0;
            this.btnUpdateMeal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnUpdateMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdateMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateMeal.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMeal.Location = new System.Drawing.Point(48, 244);
            this.btnUpdateMeal.Name = "btnUpdateMeal";
            this.btnUpdateMeal.Size = new System.Drawing.Size(182, 45);
            this.btnUpdateMeal.TabIndex = 3;
            this.btnUpdateMeal.Tag = "3";
            this.btnUpdateMeal.Text = "Öğün İşlemleri";
            this.btnUpdateMeal.UseVisualStyleBackColor = false;
            this.btnUpdateMeal.Click += new System.EventHandler(this.btnNavigation_Click);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMeal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddMeal.FlatAppearance.BorderSize = 0;
            this.btnAddMeal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAddMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMeal.ForeColor = System.Drawing.Color.White;
            this.btnAddMeal.Location = new System.Drawing.Point(48, 186);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(182, 45);
            this.btnAddMeal.TabIndex = 2;
            this.btnAddMeal.Tag = "2";
            this.btnAddMeal.Text = "Öğün Ekle";
            this.btnAddMeal.UseVisualStyleBackColor = false;
            this.btnAddMeal.Click += new System.EventHandler(this.btnNavigation_Click);
            // 
            // btnMainPage
            // 
            this.btnMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMainPage.FlatAppearance.BorderSize = 0;
            this.btnMainPage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnMainPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainPage.ForeColor = System.Drawing.Color.White;
            this.btnMainPage.Location = new System.Drawing.Point(48, 128);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(182, 45);
            this.btnMainPage.TabIndex = 1;
            this.btnMainPage.Tag = "1";
            this.btnMainPage.Text = "Ana Sayfa";
            this.btnMainPage.UseVisualStyleBackColor = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnNavigation_Click);
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentDate.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentDate.Location = new System.Drawing.Point(12, 423);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(41, 15);
            this.lblCurrentDate.TabIndex = 0;
            this.lblCurrentDate.Text = "Tarih :";
            // 
            // pnlNavItems
            // 
            this.pnlNavItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavItems.Location = new System.Drawing.Point(275, 0);
            this.pnlNavItems.Name = "pnlNavItems";
            this.pnlNavItems.Size = new System.Drawing.Size(675, 450);
            this.pnlNavItems.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.pnlNavItems);
            this.Controls.Add(this.pnlNavigation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(966, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(966, 489);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RUFIT";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmMain_HelpButtonClicked);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlNavigation;
        private Button btnClose;
        private Button btnAccount;
        private Button btnUpdateMeal;
        private Button btnAddMeal;
        private Button btnMainPage;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button7;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Panel pnlNavItems;
        private Label lblCurrentDate;
        private Label lblAppName;
        private PictureBox pictureBox1;
    }
}
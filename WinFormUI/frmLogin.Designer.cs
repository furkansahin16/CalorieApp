namespace WinFormUI
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.llbSignUp = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.chkRememberMe);
            this.panel1.Controls.Add(this.llbSignUp);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblAppName);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblMain);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 378);
            this.panel1.TabIndex = 0;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Location = new System.Drawing.Point(40, 263);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(102, 25);
            this.chkRememberMe.TabIndex = 3;
            this.chkRememberMe.Text = "Beni Hatırla";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // llbSignUp
            // 
            this.llbSignUp.AutoSize = true;
            this.llbSignUp.Location = new System.Drawing.Point(162, 264);
            this.llbSignUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbSignUp.Name = "llbSignUp";
            this.llbSignUp.Size = new System.Drawing.Size(59, 21);
            this.llbSignUp.TabIndex = 4;
            this.llbSignUp.TabStop = true;
            this.llbSignUp.Text = "Kayıt Ol";
            this.llbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignUp_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(92, 302);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(77, 37);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.ForeColor = System.Drawing.Color.Black;
            this.lblAppName.Location = new System.Drawing.Point(59, 72);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(144, 31);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "KALORİ TAKİP";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("ISOCPEUR", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(101, 20);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(61, 31);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "LOGO";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 197);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(40, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(40, 127);
            this.lblMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(92, 21);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "E-mail Adresi";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 223);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(181, 27);
            this.txtPassword.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(40, 153);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(181, 27);
            this.txtMail.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(263, 378);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalori Takip";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private LinkLabel llbSignUp;
        private Button btnLogin;
        private Label lblAppName;
        private Label lblLogo;
        private Label lblPassword;
        private Label lblMain;
        private TextBox txtPassword;
        private TextBox txtMail;
        private CheckBox chkRememberMe;
    }
}
namespace WinFormUI
{
    partial class frmAccount
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
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.Transparent;
            this.pnlSignUp.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.pnlSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSignUp.Controls.Add(this.btnUpdate);
            this.pnlSignUp.Controls.Add(this.lblPassword2);
            this.pnlSignUp.Controls.Add(this.lblMail);
            this.pnlSignUp.Controls.Add(this.lblCurrentPassword);
            this.pnlSignUp.Controls.Add(this.lblPassword);
            this.pnlSignUp.Controls.Add(this.txtMail);
            this.pnlSignUp.Controls.Add(this.txtPassword2);
            this.pnlSignUp.Controls.Add(this.txtCurrentPassword);
            this.pnlSignUp.Controls.Add(this.txtPassword);
            this.pnlSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSignUp.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlSignUp.Location = new System.Drawing.Point(0, 0);
            this.pnlSignUp.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(650, 450);
            this.pnlSignUp.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(231, 315);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 48);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Şifreyi Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(172, 231);
            this.lblPassword2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(87, 21);
            this.lblPassword2.TabIndex = 1;
            this.lblPassword2.Text = "Şifre Tekrar";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.Black;
            this.lblMail.Location = new System.Drawing.Point(172, 69);
            this.lblMail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(92, 21);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "E-mail Adresi";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(172, 123);
            this.lblCurrentPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(88, 21);
            this.lblCurrentPassword.TabIndex = 1;
            this.lblCurrentPassword.Text = "Mevcut Şifre";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(172, 177);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(40, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(172, 93);
            this.txtMail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(300, 27);
            this.txtMail.TabIndex = 1;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(172, 255);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(300, 27);
            this.txtPassword2.TabIndex = 4;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(172, 147);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(300, 27);
            this.txtCurrentPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(172, 201);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // frmAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSignUp);
            this.Font = new System.Drawing.Font("ISOCTEUR", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAccount";
            this.ShowIcon = false;
            this.Text = "Hesap Ayarları";
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlSignUp;
        private Button btnUpdate;
        private Label lblMail;
        private Label lblPassword2;
        private Label lblPassword;
        private TextBox txtPassword2;
        private TextBox txtPassword;
        private Label lblCurrentPassword;
        private TextBox txtCurrentPassword;
        private TextBox txtMail;
    }
}
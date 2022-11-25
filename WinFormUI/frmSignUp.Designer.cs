namespace WinFormUI
{
    partial class frmSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("ISOCPEUR", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(86, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 50);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Kayıt Ol";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword2.Location = new System.Drawing.Point(40, 217);
            this.lblPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(87, 21);
            this.lblPassword2.TabIndex = 7;
            this.lblPassword2.Text = "Şifre Tekrar";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Location = new System.Drawing.Point(40, 31);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(92, 21);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "E-mail Adresi";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthDate.Location = new System.Drawing.Point(40, 93);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(88, 21);
            this.lblBirthDate.TabIndex = 9;
            this.lblBirthDate.Text = "Doğum Tarihi";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(40, 155);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(40, 21);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Şifre";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(40, 59);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(234, 27);
            this.txtMail.TabIndex = 1;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(40, 245);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(234, 27);
            this.txtPassword2.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 183);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(234, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(40, 121);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(232, 27);
            this.dtpBirthDate.TabIndex = 2;
            // 
            // frmSignUp
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(316, 358);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSignUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private Label lblPassword2;
        private Label lblMail;
        private Label lblBirthDate;
        private Label lblPassword;
        private TextBox txtMail;
        private TextBox txtPassword2;
        private TextBox txtPassword;
        private DateTimePicker dtpBirthDate;
    }
}
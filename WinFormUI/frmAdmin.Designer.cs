﻿namespace WinFormUI
{
    partial class frmAdmin
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
            this.btnCRUD = new System.Windows.Forms.Button();
            this.flpNavBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.flpNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCRUD
            // 
            this.btnCRUD.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCRUD.Location = new System.Drawing.Point(3, 4);
            this.btnCRUD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCRUD.Name = "btnCRUD";
            this.btnCRUD.Size = new System.Drawing.Size(400, 40);
            this.btnCRUD.TabIndex = 1;
            this.btnCRUD.Text = "Düzenleme";
            this.btnCRUD.UseVisualStyleBackColor = true;
            this.btnCRUD.Click += new System.EventHandler(this.btnCRUD_Click);
            // 
            // flpNavBar
            // 
            this.flpNavBar.BackColor = System.Drawing.Color.Transparent;
            this.flpNavBar.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.flpNavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpNavBar.Controls.Add(this.btnCRUD);
            this.flpNavBar.Controls.Add(this.btnReport);
            this.flpNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpNavBar.Location = new System.Drawing.Point(0, 0);
            this.flpNavBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpNavBar.Name = "flpNavBar";
            this.flpNavBar.Size = new System.Drawing.Size(813, 40);
            this.flpNavBar.TabIndex = 2;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(409, 4);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(400, 40);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Raporlama";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 40);
            this.pnlMain.MaximumSize = new System.Drawing.Size(813, 430);
            this.pnlMain.MinimumSize = new System.Drawing.Size(813, 430);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(813, 430);
            this.pnlMain.TabIndex = 3;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 470);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.flpNavBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("ISOCPEUR", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(829, 509);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(829, 509);
            this.Name = "frmAdmin";
            this.ShowIcon = false;
            this.Text = "Admin Paneli";
            this.flpNavBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCRUD;
        private FlowLayoutPanel flpNavBar;
        private Button btnReport;
        private Panel pnlMain;
    }
}
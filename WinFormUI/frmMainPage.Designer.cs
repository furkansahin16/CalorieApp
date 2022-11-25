namespace WinFormUI
{
    partial class frmMainPage
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
            this.pnlMainPage = new System.Windows.Forms.Panel();
            this.llbWebPage = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lswLastFoods = new System.Windows.Forms.ListView();
            this.clmFood = new System.Windows.Forms.ColumnHeader();
            this.clmFoodName = new System.Windows.Forms.ColumnHeader();
            this.clmPortion = new System.Windows.Forms.ColumnHeader();
            this.clmCalorie = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLastMealDate = new System.Windows.Forms.Label();
            this.lblLastMealName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDailyReport = new System.Windows.Forms.Label();
            this.lblDailyReportTotalCalorie = new System.Windows.Forms.Label();
            this.lblDailyReportFoodCount = new System.Windows.Forms.Label();
            this.lblDailyReportDay = new System.Windows.Forms.Label();
            this.lblDailyReportMealCount = new System.Windows.Forms.Label();
            this.pnlMainPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainPage.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.pnlMainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainPage.Controls.Add(this.llbWebPage);
            this.pnlMainPage.Controls.Add(this.lblHeader);
            this.pnlMainPage.Controls.Add(this.panel3);
            this.pnlMainPage.Controls.Add(this.panel2);
            this.pnlMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPage.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPage.MaximumSize = new System.Drawing.Size(675, 450);
            this.pnlMainPage.MinimumSize = new System.Drawing.Size(675, 450);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Size = new System.Drawing.Size(675, 450);
            this.pnlMainPage.TabIndex = 0;
            // 
            // llbWebPage
            // 
            this.llbWebPage.AutoSize = true;
            this.llbWebPage.BackColor = System.Drawing.Color.Transparent;
            this.llbWebPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbWebPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llbWebPage.Location = new System.Drawing.Point(102, 72);
            this.llbWebPage.Name = "llbWebPage";
            this.llbWebPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.llbWebPage.Size = new System.Drawing.Size(454, 48);
            this.llbWebPage.TabIndex = 1;
            this.llbWebPage.TabStop = true;
            this.llbWebPage.Text = "UYGULAMA HAKKINDA DETAYLI BİLGİ ALMAK İÇİN\r\nWEB SAYFAMIZI ZİYARET EDİNİZ";
            this.llbWebPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbWebPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbWebPage_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(186, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(303, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "RUFİT\'E HOŞ GELDİNİZ.";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lswLastFoods);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblLastMealDate);
            this.panel3.Controls.Add(this.lblLastMealName);
            this.panel3.Location = new System.Drawing.Point(0, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 305);
            this.panel3.TabIndex = 3;
            // 
            // lswLastFoods
            // 
            this.lswLastFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lswLastFoods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lswLastFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFood,
            this.clmFoodName,
            this.clmPortion,
            this.clmCalorie});
            this.lswLastFoods.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lswLastFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lswLastFoods.ForeColor = System.Drawing.Color.White;
            this.lswLastFoods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lswLastFoods.Location = new System.Drawing.Point(0, 109);
            this.lswLastFoods.MultiSelect = false;
            this.lswLastFoods.Name = "lswLastFoods";
            this.lswLastFoods.Size = new System.Drawing.Size(327, 192);
            this.lswLastFoods.TabIndex = 3;
            this.lswLastFoods.UseCompatibleStateImageBehavior = false;
            this.lswLastFoods.View = System.Windows.Forms.View.Details;
            // 
            // clmFood
            // 
            this.clmFood.Text = "Kategori";
            this.clmFood.Width = 80;
            // 
            // clmFoodName
            // 
            this.clmFoodName.Text = "Yemek";
            this.clmFoodName.Width = 115;
            // 
            // clmPortion
            // 
            this.clmPortion.Text = "Porsiyon";
            this.clmPortion.Width = 65;
            // 
            // clmCalorie
            // 
            this.clmCalorie.Text = "Kalori";
            this.clmCalorie.Width = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label3.Size = new System.Drawing.Size(197, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "SON EKLENEN ÖĞÜN";
            // 
            // lblLastMealDate
            // 
            this.lblLastMealDate.AutoSize = true;
            this.lblLastMealDate.BackColor = System.Drawing.Color.Transparent;
            this.lblLastMealDate.ForeColor = System.Drawing.Color.Black;
            this.lblLastMealDate.Location = new System.Drawing.Point(10, 37);
            this.lblLastMealDate.Name = "lblLastMealDate";
            this.lblLastMealDate.Size = new System.Drawing.Size(66, 20);
            this.lblLastMealDate.TabIndex = 0;
            this.lblLastMealDate.Text = "TARİH :";
            // 
            // lblLastMealName
            // 
            this.lblLastMealName.AutoSize = true;
            this.lblLastMealName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastMealName.ForeColor = System.Drawing.Color.Black;
            this.lblLastMealName.Location = new System.Drawing.Point(10, 73);
            this.lblLastMealName.Name = "lblLastMealName";
            this.lblLastMealName.Size = new System.Drawing.Size(65, 20);
            this.lblLastMealName.TabIndex = 0;
            this.lblLastMealName.Text = "ÖĞÜN :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDailyReport);
            this.panel2.Controls.Add(this.lblDailyReportTotalCalorie);
            this.panel2.Controls.Add(this.lblDailyReportFoodCount);
            this.panel2.Controls.Add(this.lblDailyReportDay);
            this.panel2.Controls.Add(this.lblDailyReportMealCount);
            this.panel2.Location = new System.Drawing.Point(344, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 305);
            this.panel2.TabIndex = 3;
            // 
            // lblDailyReport
            // 
            this.lblDailyReport.AutoSize = true;
            this.lblDailyReport.BackColor = System.Drawing.Color.Transparent;
            this.lblDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDailyReport.ForeColor = System.Drawing.Color.Black;
            this.lblDailyReport.Location = new System.Drawing.Point(0, 0);
            this.lblDailyReport.Name = "lblDailyReport";
            this.lblDailyReport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDailyReport.Size = new System.Drawing.Size(157, 30);
            this.lblDailyReport.TabIndex = 0;
            this.lblDailyReport.Text = "GÜNLÜK RAPOR";
            // 
            // lblDailyReportTotalCalorie
            // 
            this.lblDailyReportTotalCalorie.AutoSize = true;
            this.lblDailyReportTotalCalorie.BackColor = System.Drawing.Color.Transparent;
            this.lblDailyReportTotalCalorie.ForeColor = System.Drawing.Color.Black;
            this.lblDailyReportTotalCalorie.Location = new System.Drawing.Point(13, 132);
            this.lblDailyReportTotalCalorie.Name = "lblDailyReportTotalCalorie";
            this.lblDailyReportTotalCalorie.Size = new System.Drawing.Size(144, 20);
            this.lblDailyReportTotalCalorie.TabIndex = 0;
            this.lblDailyReportTotalCalorie.Text = "TOPLAM KALORİ :";
            // 
            // lblDailyReportFoodCount
            // 
            this.lblDailyReportFoodCount.AutoSize = true;
            this.lblDailyReportFoodCount.BackColor = System.Drawing.Color.Transparent;
            this.lblDailyReportFoodCount.ForeColor = System.Drawing.Color.Black;
            this.lblDailyReportFoodCount.Location = new System.Drawing.Point(13, 100);
            this.lblDailyReportFoodCount.Name = "lblDailyReportFoodCount";
            this.lblDailyReportFoodCount.Size = new System.Drawing.Size(131, 20);
            this.lblDailyReportFoodCount.TabIndex = 0;
            this.lblDailyReportFoodCount.Text = "YEMEK SAYISI :";
            // 
            // lblDailyReportDay
            // 
            this.lblDailyReportDay.AutoSize = true;
            this.lblDailyReportDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDailyReportDay.ForeColor = System.Drawing.Color.Black;
            this.lblDailyReportDay.Location = new System.Drawing.Point(13, 37);
            this.lblDailyReportDay.Name = "lblDailyReportDay";
            this.lblDailyReportDay.Size = new System.Drawing.Size(53, 20);
            this.lblDailyReportDay.TabIndex = 0;
            this.lblDailyReportDay.Text = "GÜN :";
            // 
            // lblDailyReportMealCount
            // 
            this.lblDailyReportMealCount.AutoSize = true;
            this.lblDailyReportMealCount.BackColor = System.Drawing.Color.Transparent;
            this.lblDailyReportMealCount.ForeColor = System.Drawing.Color.Black;
            this.lblDailyReportMealCount.Location = new System.Drawing.Point(13, 68);
            this.lblDailyReportMealCount.Name = "lblDailyReportMealCount";
            this.lblDailyReportMealCount.Size = new System.Drawing.Size(123, 20);
            this.lblDailyReportMealCount.TabIndex = 0;
            this.lblDailyReportMealCount.Text = "ÖĞÜN SAYISI :";
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.pnlMainPage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(675, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(675, 450);
            this.Name = "frmMainPage";
            this.Text = "frmMainPage";
            this.pnlMainPage.ResumeLayout(false);
            this.pnlMainPage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMainPage;
        private Label lblHeader;
        private LinkLabel llbWebPage;
        private Label lblDailyReportMealCount;
        private Label lblLastMealName;
        private Label lblDailyReportDay;
        private Label lblLastMealDate;
        private Label label3;
        private Label lblDailyReport;
        private Label lblDailyReportTotalCalorie;
        private Panel panel3;
        private Panel panel2;
        private ListView lswLastFoods;
        private ColumnHeader clmFood;
        private ColumnHeader clmFoodName;
        private ColumnHeader clmPortion;
        private ColumnHeader clmCalorie;
        private Label lblDailyReportFoodCount;
    }
}
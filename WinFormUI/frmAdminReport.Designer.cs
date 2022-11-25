namespace WinFormUI
{
    partial class frmAdminReport
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
            this.lvTotal = new System.Windows.Forms.ListView();
            this.clmProduct = new System.Windows.Forms.ColumnHeader();
            this.clmPiece = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvTotalByMeal = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lvTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(408, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 430);
            this.panel1.TabIndex = 4;
            // 
            // lvTotal
            // 
            this.lvTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lvTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmProduct,
            this.clmPiece});
            this.lvTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvTotal.ForeColor = System.Drawing.Color.White;
            this.lvTotal.Location = new System.Drawing.Point(33, 67);
            this.lvTotal.Name = "lvTotal";
            this.lvTotal.Size = new System.Drawing.Size(345, 325);
            this.lvTotal.TabIndex = 4;
            this.lvTotal.UseCompatibleStateImageBehavior = false;
            this.lvTotal.View = System.Windows.Forms.View.Details;
            // 
            // clmProduct
            // 
            this.clmProduct.Text = "Yemek";
            this.clmProduct.Width = 200;
            // 
            // clmPiece
            // 
            this.clmPiece.Text = "Adet";
            this.clmPiece.Width = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toplamda en çok hangi ürün";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğün Bazlı Yemek Listesi";
            // 
            // cmbMealType
            // 
            this.cmbMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Location = new System.Drawing.Point(65, 67);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(257, 28);
            this.cmbMealType.TabIndex = 4;
            this.cmbMealType.SelectedIndexChanged += new System.EventHandler(this.cmbMealType_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WinFormUI.Properties.Resources.background;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lvTotalByMeal);
            this.panel2.Controls.Add(this.cmbMealType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 430);
            this.panel2.TabIndex = 5;
            // 
            // lvTotalByMeal
            // 
            this.lvTotalByMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.lvTotalByMeal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvTotalByMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvTotalByMeal.ForeColor = System.Drawing.Color.White;
            this.lvTotalByMeal.Location = new System.Drawing.Point(25, 148);
            this.lvTotalByMeal.Name = "lvTotalByMeal";
            this.lvTotalByMeal.Size = new System.Drawing.Size(344, 244);
            this.lvTotalByMeal.TabIndex = 5;
            this.lvTotalByMeal.UseCompatibleStateImageBehavior = false;
            this.lvTotalByMeal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Yemek";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.Width = 140;
            // 
            // frmAdminReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 430);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdminReport";
            this.Text = "frmAdminReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label3;
        private ListView lvTotal;
        private ColumnHeader clmProduct;
        private ColumnHeader clmPiece;
        private Label label1;
        private ComboBox cmbMealType;
        private Panel panel2;
        private ListView lvTotalByMeal;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
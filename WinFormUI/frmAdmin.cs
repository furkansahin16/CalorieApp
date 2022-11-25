using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class frmAdmin : Form
    {
        frmAdminFood _frmAdminFood;
        frmAdminReport _frmAdminReport;
        public frmAdmin()
        {
            InitializeComponent();
            _frmAdminFood = new()
            {
                MdiParent = this
            }; 
            _frmAdminReport = new()
            {
                MdiParent = this
            };

        }
        private void btnCRUD_Click(object sender, EventArgs e)
        {      
            pnlMain.Controls.Clear();
            _frmAdminFood.Show();
            pnlMain.Controls.Add(_frmAdminFood);
            _frmAdminFood.Dock = DockStyle.Fill;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            _frmAdminReport.Show();
            pnlMain.Controls.Add(_frmAdminReport);
            _frmAdminReport.Dock = DockStyle.Fill;
        }
    }
}

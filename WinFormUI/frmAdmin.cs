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
            OpenForm(_frmAdminFood);
        }
        private void btnCRUD_Click(object sender, EventArgs e)
        {
            OpenForm(_frmAdminFood);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenForm(_frmAdminReport);
        }

        private void OpenForm<T>(T frm) where T : Form, new()
        {
            frm = new()
            {
                MdiParent = this
            };
            pnlMain.Controls.Clear();
            frm.Show();
            pnlMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case (Keys.Control | Keys.D1): OpenForm(_frmAdminFood); break;
                case (Keys.Control | Keys.D2): OpenForm(_frmAdminReport); break;
                default: break;
            }
        }

        private void frmMain_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show(
                "Düzenleme => Ctrl + 1\n" +
                "Raporlama => Ctrl + 2\n" +
                "Çıkış => Alt + F4", "Kısayollar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

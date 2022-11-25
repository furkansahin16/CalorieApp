using Business.HelperClasses;
using Entities.VMs.UserVMs;

namespace WinFormUI
{
    public partial class frmMain : Form
    {
        frmMainPage _frmMainPage;
        frmAddMeal _frmAddMeal;
        frmReport _frmReport;
        frmAccount _frmAccount;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CheckOpen(_frmMainPage);
            lblCurrentDate.Text = "Tarih : " + DateTime.Now.ToString("D");
            lblActiveUser.Text = "Kullanýcý : " + CurrentUser.UserName;
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag)
            {
                case "1": CheckOpen(_frmMainPage); break;
                case "2": CheckOpen(_frmAddMeal); break;
                case "3": CheckOpen(_frmReport); break;
                case "4": CheckOpen(_frmAccount); break;
                default:break;
            }
        }
        private void CheckOpen<T>(T frm) where T : Form, new()
        {
            frm = new()
            {
                MdiParent = this
            };
            frm.Show();
            pnlNavItems.Controls.Clear();
            pnlNavItems.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
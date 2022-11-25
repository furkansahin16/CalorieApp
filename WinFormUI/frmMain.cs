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
            OpenForm(_frmMainPage);
            lblCurrentDate.Text = "Tarih : " + DateTime.Now.ToString("D");
            this.Text += " - " + CurrentUser.UserName;
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag)
            {
                case "1": OpenForm(_frmMainPage); break;
                case "2": OpenForm(_frmAddMeal); break;
                case "3": OpenForm(_frmReport); break;
                case "4": OpenForm(_frmAccount); break;
                default:break;
            }
        }
        private void OpenForm<T>(T frm) where T : Form, new()
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

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case (Keys.Control | Keys.D1): OpenForm(_frmMainPage);break;
                case (Keys.Control | Keys.D2): OpenForm(_frmAddMeal);break;
                case (Keys.Control | Keys.D3): OpenForm(_frmReport); break;
                case (Keys.Control | Keys.D4): OpenForm(_frmAccount); break;
                default:break;
            }
        }

        private void frmMain_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show(
                "Anasayfa => Ctrl + 1\n" +
                "Öðün Ekle => Ctrl + 2\n" +
                "Öðün Ýþlemleri => Ctrl + 3\n" +
                "Hesap => Ctrl + 4\n" +
                "Çýkýþ => Alt + F4","Kýsayollar",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
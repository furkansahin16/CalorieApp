using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Business.HelperClasses;
using Entities.Dtos;

namespace WinFormUI
{
    public partial class frmAccount : Form
    {
        IUserService _userService;
        public frmAccount()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            txtMail.Enabled = false;
            txtMail.Text = CurrentUser.UserName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Girilen şifreler birbiriyle aynı değil.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            try
            {
                UserChangePasswordDTO newUserData = new UserChangePasswordDTO()
                {
                    UserName = txtMail.Text,
                    OldPassword = txtCurrentPassword.Text,
                    NewPassword = txtPassword.Text,
                };

                _userService.ChangePassword(newUserData);
                MessageBox.Show("Şifre başarıyla değiştirildi.","Şifre Değiştirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

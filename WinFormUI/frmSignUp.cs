using Business.Abstract;
using Business.DependencyResolver.Autofac;
using Entities.Dtos.Users;
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
    public partial class frmSignUp : Form
    {
        IUserService _userService;
        public frmSignUp()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != txtPassword2.Text) throw new Exception("Şifreler aynı değil");
                UserCreateDTO newUser = new()
                {
                    UserName = txtMail.Text,
                    Password = txtPassword2.Text,
                    BirthDate = dtpBirthDate.Value
                };
                _userService.Register(newUser);
                MessageBox.Show($"{txtMail.Text} kaydı başarıyla tamamlandı.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}

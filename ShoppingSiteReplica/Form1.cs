using ShoppingSiteReplica.Domain;
using ShoppinSiteReplica.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingSiteReplica
{
    public partial class Login : Form
    {
        IUserService lgnService = ServiceActivator.Get<IUserService>();
        public Login()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            UserSearch userLogin = new UserSearch();
            userLogin.Email = textBox_Email.Text;
            userLogin.Password = textBox_Password.Text;
            FUsers allUSersForm = new FUsers();
            bool isLogin = lgnService.Login(userLogin);
            if (isLogin)
            {
                FCategories fCategories = new FCategories();
                fCategories.ShowDialog();
            }
            
            else
                MessageBox.Show("Email or password is incorrect");
        }

        
    }
}

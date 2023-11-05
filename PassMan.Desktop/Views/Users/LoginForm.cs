using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassMan.Desktop.Views.Users
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        public bool login()
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            var dbContext = Program.GetDbContext();
            if (!dbContext.loginUser(username, password))
            {
                return false;
            }

            return true;
        }
    }
}

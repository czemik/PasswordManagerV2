using PassMan.Core.Models;
using PassMan.Core;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            register();
        }

        private void register()
        {
            string username = usernameTxt.Text;
            string email = emailTxt.Text;
            string firstname = firstnameTxt.Text;
            string lastname = lastnameTxt.Text;
            string password = passwordTxt.Text;
            string passwordAgain = passwordAgainTxt.Text;

            if (username == "" || email == "" || firstname == "" || lastname == "")
            {
                return;
            }
            if (password == "" || password != passwordAgain)
            {
                return;
            }

            var dbContext = Program.GetDbContext();

            User user = new();
            user.Username = username;
            user.Email = email;
            user.Firstname = firstname;
            user.Lastname = lastname;
            user.Password = Encrypter.Encrypt(email, password);

            dbContext.registerUser(user);
        }
    }
}
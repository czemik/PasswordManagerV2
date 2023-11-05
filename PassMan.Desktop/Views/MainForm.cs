using PassMan.Core.DB;
using PassMan.Core.Utils;
using PassMan.Core.Models;
using PassMan.Desktop.Views.Users;
using PassMan.Desktop.Views.Vaults;
using System.Diagnostics;

namespace Mobiles.Desktop.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoginForm form = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None
            };
            RootPanel.Controls.Add(form);
            form.Show();
        }

        private void ClearRootControls()
        {
            foreach (var control in RootPanel.Controls)
            {
                (control as Form)?.Close();
            }
            RootPanel.Controls.Clear();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.LoggedInUser == null)
            {
                return;
            }
            
            ClearRootControls();
            VaultsForm form = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None
            };
            RootPanel.Controls.Add(form);
            form.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRootControls();
            LoginForm form = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None
            };
            RootPanel.Controls.Add(form);
            form.Show();
        }

        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearRootControls();
            RegisterForm form = new()
            {
                AutoSize = true,
                Dock = DockStyle.Fill,
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None
            };
            RootPanel.Controls.Add(form);
            form.Show();
        }
    }
}

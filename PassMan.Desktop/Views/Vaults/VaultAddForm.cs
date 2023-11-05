using PassMan.Core;
using PassMan.Core.Models;

namespace PassMan.Desktop.Views.Vaults
{
    public partial class VaultAddForm : Form
    {
        private readonly int? EditId;
        public Vault? vault { get; private set; }

        public VaultAddForm(Vault? vault = null)
        {
            EditId = vault?.Id;
            InitializeComponent();
            if (vault != null)
            {
                InitEditMode(vault);
            }
        }

        private void InitEditMode(Vault vault)
        {
            Text = $"Editing vault with id: {vault.Id}";
            TitleLabel.Text = "Edit Vault";
            usernameTxt.Text = vault.Username;
            passwordTxt.Text = vault.Password;
            websiteTxt.Text = vault.Website;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var vault = new Vault
            {
                Id = EditId,
                UserId = User.LoggedInUser!.Username,
                Username = usernameTxt.Text,
                Password = Encrypter.Encrypt(User.LoggedInUser.Email, passwordTxt.Text),
                Website = websiteTxt.Text,
            };
            this.vault = vault;
        }
    }
}

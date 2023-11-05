using Microsoft.EntityFrameworkCore;
using PassMan.Core;
using PassMan.Core.DB;
using PassMan.Core.Models;
using System.Windows.Forms;

namespace PassMan.Desktop.Views.Vaults
{
    public partial class VaultsForm : Form
    {
        private readonly PasswordManagerDbContext _context;
        private readonly BindingSource _bindingSource = new();

        public VaultsForm()
        {
            _context = Program.GetDbContext();
            InitializeComponent();
            _context.Vault.Load();
            refreshGridView();

        }

        private void refreshGridView()
        {
            var list = _context.Vault.Where(el => el.UserId == User.LoggedInUser!.Username).ToList();
            var listCopy = list.ConvertAll(x => new Vault(x));
            foreach (var element in listCopy)
            {
                element.Password = Encrypter.Decrypt(User.LoggedInUser.Email, element.Password);
            }
            _bindingSource.DataSource = listCopy;
            VaultDataGridView.DataSource = _bindingSource;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosing(e);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using VaultAddForm form = new();
            var dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK && form.vault != null)
            {
                _context.Add(form.vault);
                _context.SaveChanges();
                refreshGridView();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (VaultDataGridView.CurrentRow == null)
            {
                return;
            }

            if (VaultDataGridView.CurrentRow.DataBoundItem is not Vault item)
            {
                MessageBox.Show("Select a row to edit first!", "Empty selection", MessageBoxButtons.OK);
                return;
            }
            using VaultAddForm form = new(item);
            var dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK && form.vault != null && _context.Vault.Find(item.Id) is Vault dbItem)
            {
                _context.Vault.Entry(dbItem).CurrentValues.SetValues(form.vault);
                _context.SaveChanges();
                refreshGridView();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (VaultDataGridView.CurrentRow == null)
            {
                return;
            }

            if (VaultDataGridView.CurrentRow.DataBoundItem is not Vault item)
            {
                MessageBox.Show("Select a row to delete first!", "Empty selection", MessageBoxButtons.OK);
                return;
            }
            _context.deleteVault(item);
            refreshGridView();
            
        }
    }
}

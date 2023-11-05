namespace PassMan.Desktop.Views.Vaults
{
    partial class VaultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.usersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeTrackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaultDbContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.VaultDataGridView = new System.Windows.Forms.DataGridView();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vaultDbContextBindingSource)).BeginInit();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VaultDataGridView)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersDataGridViewTextBoxColumn
            // 
            this.usersDataGridViewTextBoxColumn.Name = "usersDataGridViewTextBoxColumn";
            // 
            // vaultDataGridViewTextBoxColumn
            // 
            this.vaultDataGridViewTextBoxColumn.Name = "vaultDataGridViewTextBoxColumn";
            // 
            // databaseDataGridViewTextBoxColumn
            // 
            this.databaseDataGridViewTextBoxColumn.Name = "databaseDataGridViewTextBoxColumn";
            // 
            // changeTrackerDataGridViewTextBoxColumn
            // 
            this.changeTrackerDataGridViewTextBoxColumn.Name = "changeTrackerDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // contextIdDataGridViewTextBoxColumn
            // 
            this.contextIdDataGridViewTextBoxColumn.Name = "contextIdDataGridViewTextBoxColumn";
            // 
            // vaultDbContextBindingSource
            // 
            this.vaultDbContextBindingSource.DataSource = typeof(PassMan.Core.Models.Vault);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.VaultDataGridView, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.ControlPanel, 0, 1);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.22222F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.777778F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(800, 453);
            this.TableLayoutPanel.TabIndex = 4;
            // 
            // VaultDataGridView
            // 
            this.VaultDataGridView.AllowUserToAddRows = false;
            this.VaultDataGridView.AutoGenerateColumns = false;
            this.VaultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VaultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VaultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passwordDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn});
            this.VaultDataGridView.DataSource = this.vaultDbContextBindingSource;
            this.VaultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VaultDataGridView.Location = new System.Drawing.Point(3, 3);
            this.VaultDataGridView.Name = "VaultDataGridView";
            this.VaultDataGridView.ReadOnly = true;
            this.VaultDataGridView.RowTemplate.Height = 25;
            this.VaultDataGridView.Size = new System.Drawing.Size(794, 411);
            this.VaultDataGridView.TabIndex = 0;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            this.websiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.DeleteBtn);
            this.ControlPanel.Controls.Add(this.EditButton);
            this.ControlPanel.Controls.Add(this.AddButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(3, 420);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(794, 30);
            this.ControlPanel.TabIndex = 3;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(530, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(624, 4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(716, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "New";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // VaultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "VaultsForm";
            this.Text = "CpuReadForm";
            ((System.ComponentModel.ISupportInitialize)(this.vaultDbContextBindingSource)).EndInit();
            this.TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VaultDataGridView)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource vaultDbContextBindingSource;
        private TableLayoutPanel TableLayoutPanel;
        private DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vaultDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contextIdDataGridViewTextBoxColumn;
        private DataGridView VaultDataGridView;
        private Panel ControlPanel;
        private Button EditButton;
        private Button AddButton;
        private DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn vaultDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn contextIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private Button DeleteBtn;
    }
}
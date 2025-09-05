using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsContactManager
{
    public partial class MainForm : Form
    {
        private readonly ContactService service = new ContactService();
        private BindingList<Contact> contacts = new BindingList<Contact>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            contacts = new BindingList<Contact>(service.Load());
            gridContacts.AutoGenerateColumns = true;
            gridContacts.DataSource = contacts;
        }

        private bool ValidateInput(out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(txtName.Text)) { error = "Name is required."; return false; }
            var phone = txtPhone.Text.Trim();
            if (phone.Length < 9 || !Regex.IsMatch(phone, "^[0-9]+$")) { error = "Phone must be numeric and ≥ 9 digits."; return false; }
            var email = txtEmail.Text.Trim();
            if (!string.IsNullOrWhiteSpace(email) && !Regex.IsMatch(email, @"^\S+@\S+\.\S+$")) { error = "Email format is invalid."; return false; }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out var err)) { MessageBox.Show(err); return; }
            contacts.Add(new Contact
            {
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim()
            });
            service.Save(contacts.ToList());
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridContacts.CurrentRow == null) { MessageBox.Show("Select a contact to update."); return; }
            if (!ValidateInput(out var err)) { MessageBox.Show(err); return; }
            if (gridContacts.CurrentRow.DataBoundItem is Contact c)
            {
                c.Name = txtName.Text.Trim();
                c.Phone = txtPhone.Text.Trim();
                c.Email = txtEmail.Text.Trim();
                c.Address = txtAddress.Text.Trim();
                gridContacts.Refresh();
                service.Save(contacts.ToList());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridContacts.CurrentRow == null) { MessageBox.Show("Select a contact to delete."); return; }
            if (gridContacts.CurrentRow.DataBoundItem is Contact c)
            {
                if (MessageBox.Show("Delete this contact?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    contacts.Remove(c);
                    service.Save(contacts.ToList());
                    ClearInputs();
                }
            }
        }

        private void gridContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (gridContacts.CurrentRow?.DataBoundItem is Contact c)
            {
                txtName.Text = c.Name;
                txtPhone.Text = c.Phone;
                txtEmail.Text = c.Email;
                txtAddress.Text = c.Address;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var key = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(key)) { gridContacts.DataSource = contacts; return; }
            var filtered = contacts.Where(c => (c.Name ?? "").ToLower().Contains(key) || (c.Phone ?? "").ToLower().Contains(key)).ToList();
            gridContacts.DataSource = new BindingList<Contact>(filtered);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            gridContacts.DataSource = contacts;
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInputs();

        private void btnExport_Click(object sender, EventArgs e)
        {
            service.ExportCsv(contacts.ToList());
            MessageBox.Show("Exported to contacts.csv");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var imported = service.ImportCsv();
            if (imported.Any())
            {
                contacts = new BindingList<Contact>(imported);
                gridContacts.DataSource = contacts;
                service.Save(contacts.ToList());
                MessageBox.Show("Imported from contacts.csv");
            }
            else MessageBox.Show("contacts.csv not found or empty.");
        }

        private void ClearInputs()
        {
            txtName.Clear(); txtPhone.Clear(); txtEmail.Clear(); txtAddress.Clear();
            txtName.Focus();
        }
    }
}

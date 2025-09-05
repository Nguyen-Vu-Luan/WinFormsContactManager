namespace WinFormsContactManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRightButtons;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView gridContacts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panelRightButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.gridContacts = new System.Windows.Forms.DataGridView();
            this.tlpMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRightButtons.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.panelTop, 0, 0);
            this.tlpMain.Controls.Add(this.panelSearch, 0, 1);
            this.tlpMain.Controls.Add(this.gridContacts, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(960, 640);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelLeft);
            this.panelTop.Controls.Add(this.panelRightButtons);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 160;
            this.panelTop.Padding = new System.Windows.Forms.Padding(10);
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelLeft.Controls.Add(this.txtAddress);
            this.panelLeft.Controls.Add(this.lblAddress);
            this.panelLeft.Controls.Add(this.txtEmail);
            this.panelLeft.Controls.Add(this.lblEmail);
            this.panelLeft.Controls.Add(this.txtPhone);
            this.panelLeft.Controls.Add(this.lblPhone);
            this.panelLeft.Controls.Add(this.txtName);
            this.panelLeft.Controls.Add(this.lblName);
            // 
            // Labels & inputs
            // 
            this.lblName.Text = "Name";
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 12);
            this.txtName.Location = new System.Drawing.Point(100, 10);
            this.txtName.Width = 600;

            this.lblPhone.Text = "Phone";
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 45);
            this.txtPhone.Location = new System.Drawing.Point(100, 43);
            this.txtPhone.Width = 600;

            this.lblEmail.Text = "Email";
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 78);
            this.txtEmail.Location = new System.Drawing.Point(100, 76);
            this.txtEmail.Width = 600;

            this.lblAddress.Text = "Address";
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 111);
            this.txtAddress.Location = new System.Drawing.Point(100, 109);
            this.txtAddress.Width = 600;
            // 
            // panelRightButtons
            // 
            this.panelRightButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightButtons.Width = 200;
            this.panelRightButtons.Padding = new System.Windows.Forms.Padding(10);

            // Add
            this.btnAdd.Text = "Add";
            this.btnAdd.Dock = DockStyle.Top;
            this.btnAdd.Height = 32;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Update
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Dock = DockStyle.Top;
            this.btnUpdate.Height = 32;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // Delete
            this.btnDelete.Text = "Delete";
            this.btnDelete.Dock = DockStyle.Top;
            this.btnDelete.Height = 32;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // Clear
            this.btnClear.Text = "Clear";
            this.btnClear.Dock = DockStyle.Top;
            this.btnClear.Height = 32;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Thêm nút vào panel theo thứ tự
            this.panelRightButtons.Controls.Add(this.btnClear);
            this.panelRightButtons.Controls.Add(this.btnDelete);
            this.panelRightButtons.Controls.Add(this.btnUpdate);
            this.panelRightButtons.Controls.Add(this.btnAdd);
            // 
            // panelSearch
            // 
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Height = 50;
            this.panelSearch.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelSearch.Controls.Add(this.btnImport);
            this.panelSearch.Controls.Add(this.btnExport);
            this.panelSearch.Controls.Add(this.btnReset);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSearch);

            this.txtSearch.PlaceholderText = "Tìm theo tên hoặc số điện thoại...";
            this.txtSearch.Location = new System.Drawing.Point(10, 12);
            this.txtSearch.Width = 520;

            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(540, 10);
            this.btnSearch.Width = 90; this.btnSearch.Height = 28;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnReset.Text = "Reset";
            this.btnReset.Location = new System.Drawing.Point(640, 10);
            this.btnReset.Width = 90; this.btnReset.Height = 28;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.btnExport.Text = "Export CSV";
            this.btnExport.Location = new System.Drawing.Point(740, 10);
            this.btnExport.Width = 90; this.btnExport.Height = 28;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            this.btnImport.Text = "Import CSV";
            this.btnImport.Location = new System.Drawing.Point(840, 10);
            this.btnImport.Width = 90; this.btnImport.Height = 28;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // gridContacts
            // 
            this.gridContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridContacts.MultiSelect = false;
            this.gridContacts.ReadOnly = false;
            this.gridContacts.RowHeadersVisible = false;
            this.gridContacts.SelectionChanged += new System.EventHandler(this.gridContacts_SelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MainForm";
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRightButtons.ResumeLayout(false); this.panelRightButtons.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

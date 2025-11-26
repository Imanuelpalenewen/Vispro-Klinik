using System;
using System.Windows.Forms;

namespace KlinikApotekApp
{
    public partial class FormAdminDashboard : Form
    {
        // Menyimpan ID user yang sedang login
        public int LoggedUserId { get; set; }

        public FormAdminDashboard()
        {
            InitializeComponent();
        }

        // Open FormManagePasien inside panelContainer
        private void btnManagePasien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormManagePasien());
        }

        private void btnManageObat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormManageObat());
        }

        private void btnManageResep_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormManageResep());
        }

        private void btnManageTransaksi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormManageTransaksi());
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormManageUsers());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Utility to open child forms in panelContainer
        private void OpenChildForm(Form child)
        {
            try
            {
                this.panelContainer.Controls.Clear();
                child.TopLevel = false;
                child.FormBorderStyle = FormBorderStyle.None;
                child.Dock = DockStyle.Fill;
                this.panelContainer.Controls.Add(child);
                child.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka form: " + ex.Message);
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace KlinikApotekApp
{
    public partial class FormApotekerDashboard : Form
    {
        public int LoggedUserId { get; set; }

        public FormApotekerDashboard()
        {
            InitializeComponent();
        }

        private void btnViewObat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormViewObat());
        }

        private void btnInputTransaksi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInputTransaksi());
        }

        private void btnViewResep_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormViewResep());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KlinikApotekApp
{
    public partial class FormManageUsers : Form
    {
        public FormManageUsers()
        {
            InitializeComponent();
            LoadData();
            ClearInputs();
        }

        private void LoadData()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, username, role FROM users ORDER BY id DESC";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvUsers.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load users: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbRole.SelectedIndex = -1;
            txtUsername.Tag = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUsername.Text.Trim();
                string pass = txtPassword.Text.Trim();
                string role = cbRole.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Isi semua field.");
                    return;
                }

                string sql = "INSERT INTO users (username, password, role) VALUES (@u, @p, @r)";
                int rows = Database.ExecuteNonQuery(sql,
                    new MySqlParameter("@u", user),
                    new MySqlParameter("@p", pass), // plain text for simplicity
                    new MySqlParameter("@r", role)
                );
                if (rows > 0)
                {
                    MessageBox.Show("User berhasil ditambahkan.");
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah user: " + ex.Message);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsers.Rows.Count > 0)
            {
                var row = dgvUsers.Rows[e.RowIndex];
                txtUsername.Tag = row.Cells["id"].Value;
                txtUsername.Text = row.Cells["username"].Value.ToString();
                cbRole.SelectedItem = row.Cells["role"].Value.ToString();
                txtPassword.Text = ""; // tidak menampilkan password
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Tag == null)
                {
                    MessageBox.Show("Pilih user terlebih dahulu.");
                    return;
                }
                int id = Convert.ToInt32(txtUsername.Tag);
                string user = txtUsername.Text.Trim();
                string pass = txtPassword.Text.Trim();
                string role = cbRole.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Username dan role wajib diisi.");
                    return;
                }

                string sql;
                if (!string.IsNullOrEmpty(pass))
                {
                    sql = "UPDATE users SET username=@u, password=@p, role=@r WHERE id=@id";
                }
                else
                {
                    sql = "UPDATE users SET username=@u, role=@r WHERE id=@id";
                }

                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", user);
                        cmd.Parameters.AddWithValue("@r", role);
                        cmd.Parameters.AddWithValue("@id", id);
                        if (!string.IsNullOrEmpty(pass)) cmd.Parameters.AddWithValue("@p", pass);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Berhasil update user.");
                            LoadData();
                            ClearInputs();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update user: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Tag == null)
                {
                    MessageBox.Show("Pilih user terlebih dahulu.");
                    return;
                }
                int id = Convert.ToInt32(txtUsername.Tag);
                var confirm = MessageBox.Show("Yakin hapus user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string sql = "DELETE FROM users WHERE id=@id";
                    int rows = Database.ExecuteNonQuery(sql, new MySqlParameter("@id", id));
                    if (rows > 0)
                    {
                        MessageBox.Show("User dihapus.");
                        LoadData();
                        ClearInputs();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal hapus user: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}

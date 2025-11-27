using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KlinikApotekApp
{
    public partial class FormLogin : Form
    {
        // Konstruktor
        public FormLogin()
        {
            InitializeComponent();
        }

        // Event handler tombol Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler tombol Login — melakukan verifikasi user di tabel users
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Isi username dan password.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, username, role FROM users WHERE username = @u AND password = @p LIMIT 1";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password); // NOTE: password stored plain text for simplicity; production: hashing
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["role"].ToString();
                                int userId = Convert.ToInt32(reader["id"]);

                                // Routing berdasarkan role
                                if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                {
                                    var admin = new FormAdminDashboard();
                                    admin.LoggedUserId = userId;
                                    this.Hide();
                                    admin.ShowDialog();
                                    this.Show();
                                }
                                else if (role.Equals("Apoteker", StringComparison.OrdinalIgnoreCase))
                                {
                                    var apo = new FormApotekerDashboard();
                                    apo.LoggedUserId = userId;
                                    this.Hide();
                                    apo.ShowDialog();
                                    this.Show();
                                }
                                else if (role.Equals("User", StringComparison.OrdinalIgnoreCase))
                                {
                                    var user = new FormDashboardUser();
                                    user.LoggedUserId = userId;
                                    this.Hide();
                                    user.ShowDialog();
                                    this.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Role user tidak dikenali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                
                                // Clear password setelah login
                                txtPassword.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Username atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var formRegister = new FormRegisterUser();
            this.Hide();
            if (formRegister.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Registrasi berhasil! Silakan login.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Show();
        }
    }
}

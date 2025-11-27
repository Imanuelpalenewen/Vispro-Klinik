using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KlinikApotekApp
{
    public partial class FormRegisterUser : Form
    {
        public FormRegisterUser()
        {
            InitializeComponent();
            
            // Set password character
            txtPassword.PasswordChar = '●';
            
            // Wire event handlers
            btnRegister.Click += btnRegister_Click;
            btnBackToLogin.Click += btnBackToLogin_Click;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                string namaLengkap = txtNamaLengkap.Text.Trim();
                string umurText = txtUmur.Text.Trim();
                string nohp = txtNoHP.Text.Trim();
                string alamat = txtAlamat.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Validasi tidak boleh kosong
                if (string.IsNullOrEmpty(namaLengkap))
                {
                    MessageBox.Show("Nama lengkap tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNamaLengkap.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(umurText))
                {
                    MessageBox.Show("Umur tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUmur.Focus();
                    return;
                }

                int umur = 0;
                if (!int.TryParse(umurText, out umur) || umur <= 0)
                {
                    MessageBox.Show("Umur harus berupa angka positif.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUmur.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(nohp))
                {
                    MessageBox.Show("Nomor HP tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoHP.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(alamat))
                {
                    MessageBox.Show("Alamat tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAlamat.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Username tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                if (password.Length < 6)
                {
                    MessageBox.Show("Password minimal 6 karakter.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                // Cek username duplikat
                if (IsUsernameTaken(username))
                {
                    MessageBox.Show("Username sudah digunakan. Silakan pilih username lain.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                // Proses registrasi
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insert ke tabel pasien
                            string sqlPasien = "INSERT INTO pasien (nama, umur, nohp, alamat) VALUES (@nama, @umur, @nohp, @alamat)";
                            long pasienId = 0;

                            using (var cmdPasien = new MySqlCommand(sqlPasien, conn, transaction))
                            {
                                cmdPasien.Parameters.AddWithValue("@nama", namaLengkap);
                                cmdPasien.Parameters.AddWithValue("@umur", umur);
                                cmdPasien.Parameters.AddWithValue("@nohp", nohp);
                                cmdPasien.Parameters.AddWithValue("@alamat", alamat);
                                cmdPasien.ExecuteNonQuery();
                                pasienId = cmdPasien.LastInsertedId;
                            }

                            // 2. Insert ke tabel users
                            string sqlUser = "INSERT INTO users (username, password, role, pasien_id) VALUES (@username, @password, @role, @pasienId)";
                            using (var cmdUser = new MySqlCommand(sqlUser, conn, transaction))
                            {
                                cmdUser.Parameters.AddWithValue("@username", username);
                                cmdUser.Parameters.AddWithValue("@password", password);
                                cmdUser.Parameters.AddWithValue("@role", "User");
                                cmdUser.Parameters.AddWithValue("@pasienId", pasienId);
                                cmdUser.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            // Show success message dan auto close
                            MessageBox.Show(
                                "Registrasi berhasil!\n\nSilakan login dengan:\nUsername: " + username + "\n\nForm akan ditutup dan kembali ke halaman login.", 
                                "Registrasi Berhasil", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information
                            );

                            // Set DialogResult dan close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception("Gagal menyimpan data: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsUsernameTaken(string username)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM users WHERE username = @username";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal cek username: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Batalkan registrasi dan kembali ke halaman login?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

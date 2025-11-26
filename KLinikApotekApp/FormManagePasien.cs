using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KlinikApotekApp
{
    public partial class FormManagePasien : Form
    {
        public FormManagePasien()
        {
            InitializeComponent();
            LoadData();
            ClearInputs();
        }

        // Muat data pasien ke DataGridView
        private void LoadData()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, nama, umur, alamat, nohp FROM pasien ORDER BY id DESC";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvPasien.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data pasien: " + ex.Message);
            }
        }

        // Clear input fields
        private void ClearInputs()
        {
            txtNama.Text = "";
            txtUmur.Text = "";
            txtAlamat.Text = "";
            txtNoHP.Text = "";
            txtNama.Tag = null; // gunakan Tag untuk menyimpan id saat update
        }

        // Tambah pasien
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = txtNama.Text.Trim();
                int umur = 0;
                int.TryParse(txtUmur.Text.Trim(), out umur);
                string alamat = txtAlamat.Text.Trim();
                string nohp = txtNoHP.Text.Trim();

                if (string.IsNullOrEmpty(nama))
                {
                    MessageBox.Show("Nama tidak boleh kosong.");
                    return;
                }

                string sql = "INSERT INTO pasien (nama, umur, alamat, nohp) VALUES (@nama, @umur, @alamat, @nohp)";
                int rows = Database.ExecuteNonQuery(sql,
                    new MySqlParameter("@nama", nama),
                    new MySqlParameter("@umur", umur),
                    new MySqlParameter("@alamat", alamat),
                    new MySqlParameter("@nohp", nohp)
                );

                if (rows > 0)
                {
                    MessageBox.Show("Pasien ditambahkan.");
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah pasien: " + ex.Message);
            }
        }

        // Ketika baris dipilih, isi input untuk update
        private void dgvPasien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPasien.Rows.Count > 0)
            {
                var row = dgvPasien.Rows[e.RowIndex];
                txtNama.Tag = row.Cells["id"].Value;
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtUmur.Text = row.Cells["umur"].Value.ToString();
                txtAlamat.Text = row.Cells["alamat"].Value.ToString();
                txtNoHP.Text = row.Cells["nohp"].Value.ToString();
            }
        }

        // Update pasien
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Tag == null)
                {
                    MessageBox.Show("Pilih pasien terlebih dahulu.");
                    return;
                }

                int id = Convert.ToInt32(txtNama.Tag);
                string nama = txtNama.Text.Trim();
                int umur = 0; int.TryParse(txtUmur.Text.Trim(), out umur);
                string alamat = txtAlamat.Text.Trim();
                string nohp = txtNoHP.Text.Trim();

                string sql = "UPDATE pasien SET nama=@nama, umur=@umur, alamat=@alamat, nohp=@nohp WHERE id=@id";
                int rows = Database.ExecuteNonQuery(sql,
                    new MySqlParameter("@nama", nama),
                    new MySqlParameter("@umur", umur),
                    new MySqlParameter("@alamat", alamat),
                    new MySqlParameter("@nohp", nohp),
                    new MySqlParameter("@id", id)
                );

                if (rows > 0)
                {
                    MessageBox.Show("Berhasil update pasien.");
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update pasien: " + ex.Message);
            }
        }

        // Hapus pasien
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Tag == null)
                {
                    MessageBox.Show("Pilih pasien terlebih dahulu.");
                    return;
                }
                int id = Convert.ToInt32(txtNama.Tag);
                var confirm = MessageBox.Show("Yakin hapus pasien ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string sql = "DELETE FROM pasien WHERE id=@id";
                    int rows = Database.ExecuteNonQuery(sql, new MySqlParameter("@id", id));
                    if (rows > 0)
                    {
                        MessageBox.Show("Berhasil dihapus.");
                        LoadData();
                        ClearInputs();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal hapus pasien: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}

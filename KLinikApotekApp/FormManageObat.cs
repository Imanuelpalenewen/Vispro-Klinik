using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KlinikApotekApp
{
    public partial class FormManageObat : Form
    {
        public FormManageObat()
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
                    string sql = "SELECT id, nama, stok, harga, deskripsi FROM obat ORDER BY id DESC";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvObat.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data obat: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtNama.Text = "";
            txtStok.Text = "0";
            txtHarga.Text = "0";
            txtDeskripsi.Text = "";
            txtNama.Tag = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = txtNama.Text.Trim();
                int stok = 0; int.TryParse(txtStok.Text.Trim(), out stok);
                decimal harga = 0; decimal.TryParse(txtHarga.Text.Trim(), out harga);
                string deskripsi = txtDeskripsi.Text.Trim();

                if (string.IsNullOrEmpty(nama))
                {
                    MessageBox.Show("Nama obat wajib diisi.");
                    return;
                }

                string sql = "INSERT INTO obat (nama, stok, harga, deskripsi) VALUES (@nama, @stok, @harga, @deskripsi)";
                int rows = Database.ExecuteNonQuery(sql,
                    new MySqlParameter("@nama", nama),
                    new MySqlParameter("@stok", stok),
                    new MySqlParameter("@harga", harga),
                    new MySqlParameter("@deskripsi", deskripsi)
                );

                if (rows > 0)
                {
                    MessageBox.Show("Obat ditambahkan.");
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah obat: " + ex.Message);
            }
        }

        private void dgvObat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvObat.Rows.Count > 0)
            {
                var row = dgvObat.Rows[e.RowIndex];
                txtNama.Tag = row.Cells["id"].Value;
                txtNama.Text = row.Cells["nama"].Value.ToString();
                txtStok.Text = row.Cells["stok"].Value.ToString();
                txtHarga.Text = row.Cells["harga"].Value.ToString();
                txtDeskripsi.Text = row.Cells["deskripsi"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Tag == null)
                {
                    MessageBox.Show("Pilih obat terlebih dahulu.");
                    return;
                }
                int id = Convert.ToInt32(txtNama.Tag);
                string nama = txtNama.Text.Trim();
                int stok = 0; int.TryParse(txtStok.Text.Trim(), out stok);
                decimal harga = 0; decimal.TryParse(txtHarga.Text.Trim(), out harga);
                string deskripsi = txtDeskripsi.Text.Trim();

                string sql = "UPDATE obat SET nama=@nama, stok=@stok, harga=@harga, deskripsi=@deskripsi WHERE id=@id";
                int rows = Database.ExecuteNonQuery(sql,
                    new MySqlParameter("@nama", nama),
                    new MySqlParameter("@stok", stok),
                    new MySqlParameter("@harga", harga),
                    new MySqlParameter("@deskripsi", deskripsi),
                    new MySqlParameter("@id", id)
                );

                if (rows > 0)
                {
                    MessageBox.Show("Berhasil update obat.");
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update obat: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Tag == null)
                {
                    MessageBox.Show("Pilih obat terlebih dahulu.");
                    return;
                }
                int id = Convert.ToInt32(txtNama.Tag);
                var confirm = MessageBox.Show("Yakin hapus obat ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string sql = "DELETE FROM obat WHERE id=@id";
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
                MessageBox.Show("Gagal hapus obat: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}

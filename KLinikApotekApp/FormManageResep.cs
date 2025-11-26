using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KlinikApotekApp
{
    public partial class FormManageResep : Form
    {
        public FormManageResep()
        {
            InitializeComponent();
            LoadComboPasien();
            LoadComboObat();
            LoadData();
            ClearInputs();
        }

        private void LoadComboPasien()
        {
            try
            {
                cbPasien.Items.Clear();
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, nama FROM pasien ORDER BY nama";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbPasien.Items.Add(new ComboboxItem(reader["nama"].ToString(), reader["id"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load pasien: " + ex.Message);
            }
        }

        private void LoadComboObat()
        {
            try
            {
                cbObat.Items.Clear();
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, nama FROM obat ORDER BY nama";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbObat.Items.Add(new ComboboxItem(reader["nama"].ToString(), reader["id"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load obat: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT r.id, p.nama as pasien, o.nama as obat, r.dosis, r.aturan 
                                   FROM resep r
                                   LEFT JOIN pasien p ON r.pasien_id = p.id
                                   LEFT JOIN obat o ON r.obat_id = o.id
                                   ORDER BY r.id DESC";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvResep.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load resep: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            cbPasien.SelectedIndex = -1;
            cbObat.SelectedIndex = -1;
            txtDosis.Text = "";
            txtAturan.Text = "";
            cbPasien.Tag = null; // gunakan Tag untuk menyimpan id resep saat update
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPasien.SelectedItem == null || cbObat.SelectedItem == null)
                {
                    MessageBox.Show("Pilih pasien dan obat.");
                    return;
                }
                var pasienItem = cbPasien.SelectedItem as ComboboxItem;
                var obatItem = cbObat.SelectedItem as ComboboxItem;
                int pasienId = Convert.ToInt32(pasienItem.Value);
                int obatId = Convert.ToInt32(obatItem.Value);
                string dosis = txtDosis.Text.Trim();
                string aturan = txtAturan.Text.Trim();

                string sql = "INSERT INTO resep (pasien_id, obat_id, dosis, aturan) VALUES (@p, @o, @d, @a)";
                int rows = Database.ExecuteNonQuery(sql,
                    new MySqlParameter("@p", pasienId),
                    new MySqlParameter("@o", obatId),
                    new MySqlParameter("@d", dosis),
                    new MySqlParameter("@a", aturan)
                );

                if (rows > 0)
                {
                    MessageBox.Show("Resep ditambahkan.");
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah resep: " + ex.Message);
            }
        }

        private void dgvResep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvResep.Rows.Count > 0)
            {
                var row = dgvResep.Rows[e.RowIndex];
                cbPasien.Tag = row.Cells["id"].Value;
                string pasien = row.Cells["pasien"].Value.ToString();
                string obat = row.Cells["obat"].Value.ToString();
                // Select pasien and obat in combobox
                SelectComboByText(cbPasien, pasien);
                SelectComboByText(cbObat, obat);
                txtDosis.Text = row.Cells["dosis"].Value.ToString();
                txtAturan.Text = row.Cells["aturan"].Value.ToString();
            }
        }

        private void SelectComboByText(ComboBox cb, string text)
        {
            for (int i = 0; i < cb.Items.Count; i++)
            {
                if (((ComboboxItem)cb.Items[i]).Text == text)
                {
                    cb.SelectedIndex = i;
                    return;
                }
            }
            cb.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPasien.Tag == null)
                {
                    MessageBox.Show("Pilih resep terlebih dahulu.");
                    return;
                }
                int id = Convert.ToInt32(cbPasien.Tag);
                var pasienItem = cbPasien.SelectedItem as ComboboxItem;
                var obatItem = cbObat.SelectedItem as ComboboxItem;
                int pasienId = Convert.ToInt32(pasienItem.Value);
                int obatId = Convert.ToInt32(obatItem.Value);
                string dosis = txtDosis.Text.Trim();
                string aturan = txtAturan.Text.Trim();

                string sql = "UPDATE resep SET pasien_id=@p, obat_id=@o, dosis=@d, aturan=@a WHERE id=@id";
                int rows = Database.ExecuteNonQuery(sql,
                    new MySqlParameter("@p", pasienId),
                    new MySqlParameter("@o", obatId),
                    new MySqlParameter("@d", dosis),
                    new MySqlParameter("@a", aturan),
                    new MySqlParameter("@id", id)
                );
                if (rows > 0)
                {
                    MessageBox.Show("Berhasil update resep.");
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update resep: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPasien.Tag == null)
                {
                    MessageBox.Show("Pilih resep terlebih dahulu.");
                    return;
                }
                int id = Convert.ToInt32(cbPasien.Tag);
                var confirm = MessageBox.Show("Yakin hapus resep ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string sql = "DELETE FROM resep WHERE id=@id";
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
                MessageBox.Show("Gagal hapus resep: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // Helper inner class untuk menampung item combobox dengan value
        private class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public ComboboxItem(string text, object value)
            {
                Text = text; Value = value;
            }
            public override string ToString() { return Text; }
        }
    }
}

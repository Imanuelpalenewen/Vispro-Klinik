using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KlinikApotekApp
{
    public partial class FormManageTransaksi : Form
    {
        public FormManageTransaksi()
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
                    string sql = "SELECT id, nama, harga, stok FROM obat ORDER BY nama";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Simpan object dengan info harga & stok di Value
                            cbObat.Items.Add(new ComboboxItem(reader["nama"].ToString(), new { id = reader["id"], harga = reader["harga"], stok = reader["stok"] }));
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
                    string sql = @"SELECT t.id, p.nama as pasien, o.nama as obat, t.jumlah, t.total, t.tanggal 
                                   FROM transaksi t
                                   LEFT JOIN pasien p ON t.pasien_id = p.id
                                   LEFT JOIN obat o ON t.obat_id = o.id
                                   ORDER BY t.id DESC";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvTransaksi.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load transaksi: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            cbPasien.SelectedIndex = -1;
            cbObat.SelectedIndex = -1;
            nudJumlah.Value = 1;
            txtTotal.Text = "0";
        }

        // Hitung total: jumlah * harga obat
        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbObat.SelectedItem == null)
                {
                    MessageBox.Show("Pilih obat terlebih dahulu.");
                    return;
                }
                var item = cbObat.SelectedItem as ComboboxItem;
                dynamic val = item.Value;
                decimal harga = Convert.ToDecimal(val.harga);
                int jumlah = (int)nudJumlah.Value;
                decimal total = harga * jumlah;
                txtTotal.Text = total.ToString("0.##");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal hitung total: " + ex.Message);
            }
        }

        // Simpan transaksi, update stok otomatis
        private void btnSave_Click(object sender, EventArgs e)
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
                dynamic obatVal = obatItem.Value;
                int obatId = Convert.ToInt32(obatVal.id);
                decimal harga = Convert.ToDecimal(obatVal.harga);
                int stok = Convert.ToInt32(obatVal.stok);
                int jumlah = (int)nudJumlah.Value;
                decimal total = harga * jumlah;

                if (jumlah <= 0)
                {
                    MessageBox.Show("Jumlah harus lebih dari 0.");
                    return;
                }
                if (jumlah > stok)
                {
                    MessageBox.Show("Jumlah melebihi stok tersedia.");
                    return;
                }

                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertSql = "INSERT INTO transaksi (pasien_id, obat_id, jumlah, total, tanggal) VALUES (@p, @o, @j, @t, @tanggal)";
                            using (var cmd = new MySqlCommand(insertSql, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@p", pasienId);
                                cmd.Parameters.AddWithValue("@o", obatId);
                                cmd.Parameters.AddWithValue("@j", jumlah);
                                cmd.Parameters.AddWithValue("@t", total);
                                cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
                                cmd.ExecuteNonQuery();
                            }

                            string updateStok = "UPDATE obat SET stok = stok - @j WHERE id = @id";
                            using (var cmd2 = new MySqlCommand(updateStok, conn, tran))
                            {
                                cmd2.Parameters.AddWithValue("@j", jumlah);
                                cmd2.Parameters.AddWithValue("@id", obatId);
                                cmd2.ExecuteNonQuery();
                            }

                            tran.Commit();
                            MessageBox.Show("Transaksi berhasil disimpan.");
                            LoadData();
                            LoadComboObat(); // refresh stok info
                            ClearInputs();
                        }
                        catch
                        {
                            try { tran.Rollback(); } catch { }
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal simpan transaksi: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // Helper combobox item
        private class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public ComboboxItem(string text, object value) { Text = text; Value = value; }
            public override string ToString() { return Text; }
        }
    }
}

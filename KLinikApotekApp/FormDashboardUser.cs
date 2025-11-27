using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KlinikApotekApp
{
    public partial class FormDashboardUser : Form
    {
        public int LoggedUserId { get; set; }
        public int LoggedPasienId { get; set; }
        private List<ObatItem> selectedObatList = new List<ObatItem>();
        private DataTable currentDataTable; // Store current datatable

        public FormDashboardUser()
        {
            InitializeComponent();
            
            // Wire event handlers
            this.Load += FormDashboardUser_Load;
            btnCari.Click += btnCari_Click;
            btnBeliObat.Click += btnBeliObat_Click;
            btnLogout.Click += btnLogout_Click;
            dgvListObat.CellValueChanged += dgvListObat_CellValueChanged;
            tabControl1.SelectedIndexChanged += tabControl_SelectedIndexChanged;
        }

        private void FormDashboardUser_Load(object sender, EventArgs e)
        {
            LoadObatList();
            LoadRiwayatTransaksi();
            
            // Set label welcome
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT u.username, p.nama 
                                  FROM users u 
                                  LEFT JOIN pasien p ON u.pasien_id = p.id 
                                  WHERE u.id = @userId";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", LoggedUserId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nama = reader["nama"].ToString();
                                lblWelcome.Text = "Selamat Datang, " + nama;
                                LoggedPasienId = GetPasienId();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load user info: " + ex.Message);
            }
        }

        private int GetPasienId()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT pasien_id FROM users WHERE id = @userId";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", LoggedUserId);
                        object result = cmd.ExecuteScalar();
                        return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        // Tab List Obat
        private void LoadObatList()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, nama, stok, harga, deskripsi FROM obat WHERE stok > 0 ORDER BY nama";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        
                        // Add checkbox column
                        DataColumn checkCol = new DataColumn("Pilih", typeof(bool));
                        checkCol.DefaultValue = false;
                        dt.Columns.Add(checkCol);
                        dt.Columns["Pilih"].SetOrdinal(0);
                        
                        // Add Jumlah column
                        DataColumn jumlahCol = new DataColumn("Jumlah_Beli", typeof(int));
                        jumlahCol.DefaultValue = 1;
                        dt.Columns.Add(jumlahCol);
                        dt.Columns["Jumlah_Beli"].SetOrdinal(1);
                        
                        currentDataTable = dt;
                        
                        // Restore selections if they exist
                        RestoreSelections();
                        
                        dgvListObat.DataSource = currentDataTable;
                        FormatDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load obat: " + ex.Message);
            }
        }

        private void FormatDataGridView()
        {
            // Format columns
            if (dgvListObat.Columns["Pilih"] != null)
            {
                dgvListObat.Columns["Pilih"].ReadOnly = false;
                dgvListObat.Columns["Pilih"].HeaderText = "Pilih";
                dgvListObat.Columns["Pilih"].Width = 50;
            }
            if (dgvListObat.Columns["Jumlah_Beli"] != null)
            {
                dgvListObat.Columns["Jumlah_Beli"].ReadOnly = false;
                dgvListObat.Columns["Jumlah_Beli"].HeaderText = "Jumlah";
                dgvListObat.Columns["Jumlah_Beli"].Width = 70;
            }
            if (dgvListObat.Columns["id"] != null)
            {
                dgvListObat.Columns["id"].Visible = false;
            }
            if (dgvListObat.Columns["nama"] != null)
            {
                dgvListObat.Columns["nama"].HeaderText = "Nama Obat";
                dgvListObat.Columns["nama"].ReadOnly = true;
            }
            if (dgvListObat.Columns["stok"] != null)
            {
                dgvListObat.Columns["stok"].HeaderText = "Stok";
                dgvListObat.Columns["stok"].Width = 60;
                dgvListObat.Columns["stok"].ReadOnly = true;
            }
            if (dgvListObat.Columns["harga"] != null)
            {
                dgvListObat.Columns["harga"].HeaderText = "Harga";
                dgvListObat.Columns["harga"].DefaultCellStyle.Format = "C0";
                dgvListObat.Columns["harga"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
                dgvListObat.Columns["harga"].ReadOnly = true;
            }
            if (dgvListObat.Columns["deskripsi"] != null)
            {
                dgvListObat.Columns["deskripsi"].HeaderText = "Deskripsi";
                dgvListObat.Columns["deskripsi"].ReadOnly = true;
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtCari.Text.Trim();
                
                // Save current selections before searching
                SaveCurrentSelections();
                
                // If empty keyword, reload all data
                if (string.IsNullOrEmpty(keyword))
                {
                    LoadObatList();
                    return;
                }
                
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, nama, stok, harga, deskripsi FROM obat WHERE stok > 0 AND nama LIKE @keyword ORDER BY nama";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                        var dt = new DataTable();
                        da.Fill(dt);
                        
                        DataColumn checkCol = new DataColumn("Pilih", typeof(bool));
                        checkCol.DefaultValue = false;
                        dt.Columns.Add(checkCol);
                        dt.Columns["Pilih"].SetOrdinal(0);
                        
                        DataColumn jumlahCol = new DataColumn("Jumlah_Beli", typeof(int));
                        jumlahCol.DefaultValue = 1;
                        dt.Columns.Add(jumlahCol);
                        dt.Columns["Jumlah_Beli"].SetOrdinal(1);
                        
                        currentDataTable = dt;
                        
                        // Restore selections if they exist in filtered results
                        RestoreSelections();
                        
                        dgvListObat.DataSource = currentDataTable;
                        FormatDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal cari obat: " + ex.Message);
            }
        }

        private void SaveCurrentSelections()
        {
            // Clear previous selections
            selectedObatList.Clear();
            
            if (currentDataTable != null)
            {
                foreach (DataRow row in currentDataTable.Rows)
                {
                    if (row["Pilih"] != DBNull.Value && Convert.ToBoolean(row["Pilih"]))
                    {
                        ObatItem item = new ObatItem
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Nama = row["nama"].ToString(),
                            Harga = Convert.ToDecimal(row["harga"]),
                            Stok = Convert.ToInt32(row["stok"]),
                            Jumlah = Convert.ToInt32(row["Jumlah_Beli"])
                        };
                        selectedObatList.Add(item);
                    }
                }
            }
        }

        private void RestoreSelections()
        {
            if (currentDataTable != null && selectedObatList.Count > 0)
            {
                foreach (DataRow row in currentDataTable.Rows)
                {
                    int obatId = Convert.ToInt32(row["id"]);
                    var selectedItem = selectedObatList.Find(x => x.Id == obatId);
                    
                    if (selectedItem != null)
                    {
                        row["Pilih"] = true;
                        row["Jumlah_Beli"] = selectedItem.Jumlah;
                    }
                }
                
                dgvListObat.Refresh();
            }
        }

        private void dgvListObat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Validasi jumlah
                if (dgvListObat.Columns[e.ColumnIndex].Name == "Jumlah_Beli")
                {
                    try
                    {
                        int jumlah = Convert.ToInt32(dgvListObat.Rows[e.RowIndex].Cells["Jumlah_Beli"].Value);
                        int stok = Convert.ToInt32(dgvListObat.Rows[e.RowIndex].Cells["stok"].Value);
                        
                        if (jumlah <= 0)
                        {
                            MessageBox.Show("Jumlah harus lebih dari 0", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgvListObat.Rows[e.RowIndex].Cells["Jumlah_Beli"].Value = 1;
                        }
                        else if (jumlah > stok)
                        {
                            MessageBox.Show("Jumlah melebihi stok tersedia (" + stok + ")", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgvListObat.Rows[e.RowIndex].Cells["Jumlah_Beli"].Value = stok;
                        }
                    }
                    catch
                    {
                        dgvListObat.Rows[e.RowIndex].Cells["Jumlah_Beli"].Value = 1;
                    }
                }
            }
        }

        private void btnBeliObat_Click(object sender, EventArgs e)
        {
            try
            {
                // Save current selections before opening cart
                SaveCurrentSelections();
                
                // Build list from current selections
                List<ObatItem> itemsToBuy = new List<ObatItem>();
                
                foreach (var item in selectedObatList)
                {
                    itemsToBuy.Add(item);
                }
                
                if (itemsToBuy.Count == 0)
                {
                    MessageBox.Show("Pilih minimal 1 obat untuk dibeli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Buka FormPembelianObat
                var formPembelian = new FormPembelianObat();
                formPembelian.SetObatList(itemsToBuy);
                formPembelian.LoggedPasienId = LoggedPasienId;
                
                if (formPembelian.ShowDialog() == DialogResult.OK)
                {
                    // Clear selections after successful purchase
                    selectedObatList.Clear();
                    
                    // Refresh list dan riwayat
                    LoadObatList();
                    LoadRiwayatTransaksi();
                    MessageBox.Show("Pembelian berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // If cancelled, selections are preserved
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka form pembelian: " + ex.Message);
            }
        }

        // Tab Riwayat Transaksi
        private void LoadRiwayatTransaksi()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT t.tanggal, o.nama AS nama_obat, t.jumlah, t.total 
                                  FROM transaksi t
                                  INNER JOIN obat o ON t.obat_id = o.id
                                  WHERE t.pasien_id = @pasienId
                                  ORDER BY t.tanggal DESC";
                    using (var da = new MySqlDataAdapter(sql, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@pasienId", LoggedPasienId);
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvRiwayat.DataSource = dt;
                        
                        // Format tanggal
                        if (dgvRiwayat.Columns["tanggal"] != null)
                        {
                            dgvRiwayat.Columns["tanggal"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                            dgvRiwayat.Columns["tanggal"].HeaderText = "Tanggal";
                        }
                        if (dgvRiwayat.Columns["nama_obat"] != null)
                        {
                            dgvRiwayat.Columns["nama_obat"].HeaderText = "Nama Obat";
                        }
                        if (dgvRiwayat.Columns["jumlah"] != null)
                        {
                            dgvRiwayat.Columns["jumlah"].HeaderText = "Jumlah";
                        }
                        if (dgvRiwayat.Columns["total"] != null)
                        {
                            dgvRiwayat.Columns["total"].HeaderText = "Total";
                            dgvRiwayat.Columns["total"].DefaultCellStyle.Format = "C0";
                            dgvRiwayat.Columns["total"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load riwayat: " + ex.Message);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                LoadRiwayatTransaksi();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
    }

    // Helper class
    public class ObatItem
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }
        public int Jumlah { get; set; }
        public decimal Subtotal
        {
            get { return Harga * Jumlah; }
        }
    }
}

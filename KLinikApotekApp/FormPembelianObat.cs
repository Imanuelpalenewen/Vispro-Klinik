using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KlinikApotekApp
{
    public partial class FormPembelianObat : Form
    {
        public int LoggedPasienId { get; set; }
        private List<ObatItem> keranjangList = new List<ObatItem>();
        private DataTable dtKeranjang;

        public FormPembelianObat()
        {
            InitializeComponent();
            InitializeKeranjang();
            
            // Wire event handlers
            btnBayar.Click += btnBayar_Click;
            btnBatal.Click += btnBatal_Click;
            dgvKeranjang.CellValueChanged += dgvKeranjang_CellValueChanged;
            dgvKeranjang.CellContentClick += dgvKeranjang_CellContentClick;
        }

        public void SetObatList(List<ObatItem> obatList)
        {
            keranjangList = new List<ObatItem>(obatList);
            LoadKeranjang();
        }

        private void InitializeKeranjang()
        {
            dtKeranjang = new DataTable();
            dtKeranjang.Columns.Add("nama_obat", typeof(string));
            dtKeranjang.Columns.Add("harga", typeof(decimal));
            dtKeranjang.Columns.Add("jumlah", typeof(int));
            dtKeranjang.Columns.Add("subtotal", typeof(decimal));
            dtKeranjang.Columns.Add("id", typeof(int));
            dtKeranjang.Columns.Add("stok", typeof(int));
            
            dgvKeranjang.DataSource = dtKeranjang;
            
            // Hide id and stok columns
            if (dgvKeranjang.Columns["id"] != null)
                dgvKeranjang.Columns["id"].Visible = false;
            if (dgvKeranjang.Columns["stok"] != null)
                dgvKeranjang.Columns["stok"].Visible = false;
            
            // Add delete button column
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Hapus";
            btnDelete.HeaderText = "Hapus";
            btnDelete.Text = "Hapus";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvKeranjang.Columns.Add(btnDelete);
            
            // Set column headers
            if (dgvKeranjang.Columns["nama_obat"] != null)
                dgvKeranjang.Columns["nama_obat"].HeaderText = "Nama Obat";
            if (dgvKeranjang.Columns["harga"] != null)
            {
                dgvKeranjang.Columns["harga"].HeaderText = "Harga";
                dgvKeranjang.Columns["harga"].DefaultCellStyle.Format = "C0";
                dgvKeranjang.Columns["harga"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
                dgvKeranjang.Columns["harga"].ReadOnly = true;
            }
            if (dgvKeranjang.Columns["jumlah"] != null)
            {
                dgvKeranjang.Columns["jumlah"].HeaderText = "Jumlah";
                dgvKeranjang.Columns["jumlah"].ReadOnly = false;
            }
            if (dgvKeranjang.Columns["subtotal"] != null)
            {
                dgvKeranjang.Columns["subtotal"].HeaderText = "Subtotal";
                dgvKeranjang.Columns["subtotal"].DefaultCellStyle.Format = "C0";
                dgvKeranjang.Columns["subtotal"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("id-ID");
                dgvKeranjang.Columns["subtotal"].ReadOnly = true;
            }
        }

        private void LoadKeranjang()
        {
            dtKeranjang.Rows.Clear();
            
            foreach (var item in keranjangList)
            {
                DataRow row = dtKeranjang.NewRow();
                row["id"] = item.Id;
                row["nama_obat"] = item.Nama;
                row["harga"] = item.Harga;
                row["jumlah"] = item.Jumlah;
                row["subtotal"] = item.Subtotal;
                row["stok"] = item.Stok;
                dtKeranjang.Rows.Add(row);
            }
            
            HitungTotal();
        }

        private void dgvKeranjang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvKeranjang.Columns[e.ColumnIndex].Name == "jumlah")
                {
                    try
                    {
                        int newJumlah = Convert.ToInt32(dgvKeranjang.Rows[e.RowIndex].Cells["jumlah"].Value);
                        int stok = Convert.ToInt32(dgvKeranjang.Rows[e.RowIndex].Cells["stok"].Value);
                        decimal harga = Convert.ToDecimal(dgvKeranjang.Rows[e.RowIndex].Cells["harga"].Value);
                        
                        if (newJumlah <= 0)
                        {
                            MessageBox.Show("Jumlah harus lebih dari 0", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgvKeranjang.Rows[e.RowIndex].Cells["jumlah"].Value = 1;
                            newJumlah = 1;
                        }
                        
                        if (newJumlah > stok)
                        {
                            MessageBox.Show("Jumlah melebihi stok tersedia (" + stok + ")", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgvKeranjang.Rows[e.RowIndex].Cells["jumlah"].Value = stok;
                            newJumlah = stok;
                        }
                        
                        decimal subtotal = harga * newJumlah;
                        dgvKeranjang.Rows[e.RowIndex].Cells["subtotal"].Value = subtotal;
                        
                        // Update keranjangList
                        int id = Convert.ToInt32(dgvKeranjang.Rows[e.RowIndex].Cells["id"].Value);
                        var item = keranjangList.Find(x => x.Id == id);
                        if (item != null)
                        {
                            item.Jumlah = newJumlah;
                        }
                        
                        HitungTotal();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error update jumlah: " + ex.Message);
                    }
                }
            }
        }

        private void dgvKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvKeranjang.Columns[e.ColumnIndex].Name == "Hapus")
                {
                    var result = MessageBox.Show("Hapus item ini dari keranjang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dgvKeranjang.Rows[e.RowIndex].Cells["id"].Value);
                        keranjangList.RemoveAll(x => x.Id == id);
                        LoadKeranjang();
                        
                        if (keranjangList.Count == 0)
                        {
                            MessageBox.Show("Keranjang kosong. Form akan ditutup.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void HitungTotal()
        {
            decimal total = 0;
            foreach (var item in keranjangList)
            {
                total += item.Subtotal;
            }
            lblTotal.Text = total.ToString("C0", new System.Globalization.CultureInfo("id-ID"));
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            try
            {
                if (keranjangList.Count == 0)
                {
                    MessageBox.Show("Keranjang kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if (LoggedPasienId == 0)
                {
                    MessageBox.Show("Pasien ID tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                var confirmResult = MessageBox.Show("Lanjutkan pembayaran?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                    return;
                
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (var item in keranjangList)
                            {
                                // Insert transaksi
                                string sqlTransaksi = "INSERT INTO transaksi (pasien_id, obat_id, jumlah, total, tanggal) VALUES (@pasienId, @obatId, @jumlah, @total, @tanggal)";
                                using (var cmdTransaksi = new MySqlCommand(sqlTransaksi, conn, transaction))
                                {
                                    cmdTransaksi.Parameters.AddWithValue("@pasienId", LoggedPasienId);
                                    cmdTransaksi.Parameters.AddWithValue("@obatId", item.Id);
                                    cmdTransaksi.Parameters.AddWithValue("@jumlah", item.Jumlah);
                                    cmdTransaksi.Parameters.AddWithValue("@total", item.Subtotal);
                                    cmdTransaksi.Parameters.AddWithValue("@tanggal", DateTime.Now);
                                    cmdTransaksi.ExecuteNonQuery();
                                }
                                
                                // Update stok obat
                                string sqlUpdateStok = "UPDATE obat SET stok = stok - @jumlah WHERE id = @obatId";
                                using (var cmdUpdateStok = new MySqlCommand(sqlUpdateStok, conn, transaction))
                                {
                                    cmdUpdateStok.Parameters.AddWithValue("@jumlah", item.Jumlah);
                                    cmdUpdateStok.Parameters.AddWithValue("@obatId", item.Id);
                                    cmdUpdateStok.ExecuteNonQuery();
                                }
                            }
                            
                            transaction.Commit();
                            
                            MessageBox.Show("Pembayaran berhasil! Terima kasih.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception("Gagal menyimpan transaksi: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Batalkan pembelian?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KlinikApotekApp
{
    public partial class FormViewResep : Form
    {
        public FormViewResep()
        {
            InitializeComponent();
            
            // Wire event handlers in constructor
            this.Load += FormViewResep_Load;
            btnFilter.Click += btnFilter_Click;
            btnClearFilter.Click += btnClearFilter_Click;
        }

        private void FormViewResep_Load(object sender, EventArgs e)
        {
            LoadComboPasien();
            LoadData();
        }

        private void LoadComboPasien()
        {
            try
            {
                cbPasien.Items.Clear();
                cbPasien.Items.Add(new ComboboxItem("-- Semua Pasien --", 0));
                
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
                
                // Set default selection
                if (cbPasien.Items.Count > 0)
                {
                    cbPasien.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load pasien: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData(int pasienId = 0)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT r.id, p.nama as pasien, o.nama as obat, r.dosis, r.aturan 
                                   FROM resep r
                                   LEFT JOIN pasien p ON r.pasien_id = p.id
                                   LEFT JOIN obat o ON r.obat_id = o.id";
                    if (pasienId > 0) sql += " WHERE r.pasien_id = @pid";
                    sql += " ORDER BY r.id DESC";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        if (pasienId > 0) cmd.Parameters.AddWithValue("@pid", pasienId);
                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            da.Fill(dt);
                            dgvResep.DataSource = dt;
                            
                            // Format columns
                            if (dgvResep.Columns["id"] != null)
                            {
                                dgvResep.Columns["id"].HeaderText = "ID";
                                dgvResep.Columns["id"].Width = 60;
                            }
                            if (dgvResep.Columns["pasien"] != null)
                            {
                                dgvResep.Columns["pasien"].HeaderText = "Nama Pasien";
                            }
                            if (dgvResep.Columns["obat"] != null)
                            {
                                dgvResep.Columns["obat"].HeaderText = "Nama Obat";
                            }
                            if (dgvResep.Columns["dosis"] != null)
                            {
                                dgvResep.Columns["dosis"].HeaderText = "Dosis";
                            }
                            if (dgvResep.Columns["aturan"] != null)
                            {
                                dgvResep.Columns["aturan"].HeaderText = "Aturan Pakai";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load resep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPasien.SelectedItem == null)
                {
                    MessageBox.Show("Pilih pasien untuk filter.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                var selectedItem = cbPasien.SelectedItem as ComboboxItem;
                if (selectedItem != null)
                {
                    int pasienId = Convert.ToInt32(selectedItem.Value);
                    LoadData(pasienId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal filter data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPasien.Items.Count > 0)
                {
                    cbPasien.SelectedIndex = 0;
                }
                LoadData(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal clear filter: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public ComboboxItem(string text, object value) { Text = text; Value = value; }
            public override string ToString() { return Text; }
        }

        private void dgvResep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reserved for future use
        }
    }
}

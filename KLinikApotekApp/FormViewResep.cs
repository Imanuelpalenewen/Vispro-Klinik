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
            LoadComboPasien();
            LoadData();
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load resep: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbPasien.SelectedItem == null)
            {
                MessageBox.Show("Pilih pasien untuk filter.");
                return;
            }
            var it = cbPasien.SelectedItem as ComboboxItem;
            int pid = Convert.ToInt32(it.Value);
            LoadData(pid);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbPasien.SelectedIndex = -1;
            LoadData(0);
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

        }
    }
}

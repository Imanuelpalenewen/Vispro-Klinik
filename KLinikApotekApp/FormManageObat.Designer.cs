using System;
using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormManageObat
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvObat;
        private Panel panelInputs;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblStok;
        private TextBox txtStok;
        private Label lblHarga;
        private TextBox txtHarga;
        private Label lblDeskripsi;
        private TextBox txtDeskripsi;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvObat = new System.Windows.Forms.DataGridView();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).BeginInit();
            this.panelInputs.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 60);
            this.panelHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Obat";

            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dgvObat);
            this.panelMain.Controls.Add(this.panelInputs);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1000, 540);
            this.panelMain.TabIndex = 1;

            // 
            // dgvObat
            // 
            this.dgvObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObat.Location = new System.Drawing.Point(10, 10);
            this.dgvObat.MultiSelect = false;
            this.dgvObat.Name = "dgvObat";
            this.dgvObat.ReadOnly = true;
            this.dgvObat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObat.Size = new System.Drawing.Size(620, 520);
            this.dgvObat.TabIndex = 0;
            this.dgvObat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObat_CellClick);

            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInputs.Controls.Add(this.btnClear);
            this.panelInputs.Controls.Add(this.btnDelete);
            this.panelInputs.Controls.Add(this.btnUpdate);
            this.panelInputs.Controls.Add(this.btnAdd);
            this.panelInputs.Controls.Add(this.txtDeskripsi);
            this.panelInputs.Controls.Add(this.lblDeskripsi);
            this.panelInputs.Controls.Add(this.txtHarga);
            this.panelInputs.Controls.Add(this.lblHarga);
            this.panelInputs.Controls.Add(this.txtStok);
            this.panelInputs.Controls.Add(this.lblStok);
            this.panelInputs.Controls.Add(this.txtNama);
            this.panelInputs.Controls.Add(this.lblNama);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInputs.Location = new System.Drawing.Point(630, 10);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Padding = new System.Windows.Forms.Padding(8);
            this.panelInputs.Size = new System.Drawing.Size(360, 520);
            this.panelInputs.TabIndex = 1;

            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 12);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(64, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Obat";

            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(12, 34);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(320, 20);
            this.txtNama.TabIndex = 1;

            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(12, 72);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(29, 13);
            this.lblStok.TabIndex = 2;
            this.lblStok.Text = "Stok";

            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(12, 94);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(320, 20);
            this.txtStok.TabIndex = 3;

            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(12, 132);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(36, 13);
            this.lblHarga.TabIndex = 4;
            this.lblHarga.Text = "Harga";

            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(12, 154);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(320, 20);
            this.txtHarga.TabIndex = 5;

            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(12, 192);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(52, 13);
            this.lblDeskripsi.TabIndex = 6;
            this.lblDeskripsi.Text = "Deskripsi";

            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(12, 214);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(320, 60);
            this.txtDeskripsi.TabIndex = 7;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(182, 314);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 36);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(182, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // FormManageObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormManageObat";
            this.Text = "Manage Obat";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}

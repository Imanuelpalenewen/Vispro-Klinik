using System;
using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormManagePasien
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvPasien;
        private Panel panelInputs;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblUmur;
        private TextBox txtUmur;
        private Label lblAlamat;
        private TextBox txtAlamat;
        private Label lblNoHP;
        private TextBox txtNoHP;
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
            this.dgvPasien = new System.Windows.Forms.DataGridView();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblUmur = new System.Windows.Forms.Label();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblNoHP = new System.Windows.Forms.Label();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasien)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(135, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Pasien";

            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dgvPasien);
            this.panelMain.Controls.Add(this.panelInputs);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1000, 540);
            this.panelMain.TabIndex = 1;

            // 
            // dgvPasien
            // 
            this.dgvPasien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPasien.Location = new System.Drawing.Point(10, 10);
            this.dgvPasien.MultiSelect = false;
            this.dgvPasien.Name = "dgvPasien";
            this.dgvPasien.ReadOnly = true;
            this.dgvPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasien.Size = new System.Drawing.Size(620, 520);
            this.dgvPasien.TabIndex = 0;
            this.dgvPasien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasien_CellClick);

            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInputs.Controls.Add(this.btnClear);
            this.panelInputs.Controls.Add(this.btnDelete);
            this.panelInputs.Controls.Add(this.btnUpdate);
            this.panelInputs.Controls.Add(this.btnAdd);
            this.panelInputs.Controls.Add(this.txtNoHP);
            this.panelInputs.Controls.Add(this.lblNoHP);
            this.panelInputs.Controls.Add(this.txtAlamat);
            this.panelInputs.Controls.Add(this.lblAlamat);
            this.panelInputs.Controls.Add(this.txtUmur);
            this.panelInputs.Controls.Add(this.lblUmur);
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
            this.lblNama.Size = new System.Drawing.Size(35, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";

            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(12, 34);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(320, 20);
            this.txtNama.TabIndex = 1;

            // 
            // lblUmur
            // 
            this.lblUmur.AutoSize = true;
            this.lblUmur.Location = new System.Drawing.Point(12, 72);
            this.lblUmur.Name = "lblUmur";
            this.lblUmur.Size = new System.Drawing.Size(32, 13);
            this.lblUmur.TabIndex = 2;
            this.lblUmur.Text = "Umur";

            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(12, 94);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(320, 20);
            this.txtUmur.TabIndex = 3;

            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(12, 132);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 4;
            this.lblAlamat.Text = "Alamat";

            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(12, 154);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(320, 60);
            this.txtAlamat.TabIndex = 5;

            // 
            // lblNoHP
            // 
            this.lblNoHP.AutoSize = true;
            this.lblNoHP.Location = new System.Drawing.Point(12, 232);
            this.lblNoHP.Name = "lblNoHP";
            this.lblNoHP.Size = new System.Drawing.Size(39, 13);
            this.lblNoHP.TabIndex = 6;
            this.lblNoHP.Text = "No HP";

            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(12, 254);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(320, 20);
            this.txtNoHP.TabIndex = 7;

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
            // FormManagePasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormManagePasien";
            this.Text = "Manage Pasien";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasien)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}

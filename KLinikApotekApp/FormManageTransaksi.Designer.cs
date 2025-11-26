using System;
using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormManageTransaksi
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvTransaksi;
        private Panel panelInputs;
        private Label lblPasien;
        private ComboBox cbPasien;
        private Label lblObat;
        private ComboBox cbObat;
        private Label lblJumlah;
        private NumericUpDown nudJumlah;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnHitung;
        private Button btnSave;
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
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.lblPasien = new System.Windows.Forms.Label();
            this.cbPasien = new System.Windows.Forms.ComboBox();
            this.lblObat = new System.Windows.Forms.Label();
            this.cbObat = new System.Windows.Forms.ComboBox();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(155, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Transaksi";

            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dgvTransaksi);
            this.panelMain.Controls.Add(this.panelInputs);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1000, 540);
            this.panelMain.TabIndex = 1;

            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaksi.Location = new System.Drawing.Point(10, 10);
            this.dgvTransaksi.MultiSelect = false;
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.ReadOnly = true;
            this.dgvTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaksi.Size = new System.Drawing.Size(600, 520);
            this.dgvTransaksi.TabIndex = 0;

            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInputs.Controls.Add(this.btnClear);
            this.panelInputs.Controls.Add(this.btnSave);
            this.panelInputs.Controls.Add(this.btnHitung);
            this.panelInputs.Controls.Add(this.txtTotal);
            this.panelInputs.Controls.Add(this.lblTotal);
            this.panelInputs.Controls.Add(this.nudJumlah);
            this.panelInputs.Controls.Add(this.lblJumlah);
            this.panelInputs.Controls.Add(this.cbObat);
            this.panelInputs.Controls.Add(this.lblObat);
            this.panelInputs.Controls.Add(this.cbPasien);
            this.panelInputs.Controls.Add(this.lblPasien);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInputs.Location = new System.Drawing.Point(610, 10);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Padding = new System.Windows.Forms.Padding(8);
            this.panelInputs.Size = new System.Drawing.Size(380, 520);
            this.panelInputs.TabIndex = 1;

            // 
            // lblPasien
            // 
            this.lblPasien.AutoSize = true;
            this.lblPasien.Location = new System.Drawing.Point(12, 12);
            this.lblPasien.Name = "lblPasien";
            this.lblPasien.Size = new System.Drawing.Size(44, 13);
            this.lblPasien.TabIndex = 0;
            this.lblPasien.Text = "Pasien";

            // 
            // cbPasien
            // 
            this.cbPasien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasien.FormattingEnabled = true;
            this.cbPasien.Location = new System.Drawing.Point(12, 34);
            this.cbPasien.Name = "cbPasien";
            this.cbPasien.Size = new System.Drawing.Size(340, 21);
            this.cbPasien.TabIndex = 1;

            // 
            // lblObat
            // 
            this.lblObat.AutoSize = true;
            this.lblObat.Location = new System.Drawing.Point(12, 72);
            this.lblObat.Name = "lblObat";
            this.lblObat.Size = new System.Drawing.Size(32, 13);
            this.lblObat.TabIndex = 2;
            this.lblObat.Text = "Obat";

            // 
            // cbObat
            // 
            this.cbObat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObat.FormattingEnabled = true;
            this.cbObat.Location = new System.Drawing.Point(12, 94);
            this.cbObat.Name = "cbObat";
            this.cbObat.Size = new System.Drawing.Size(340, 21);
            this.cbObat.TabIndex = 3;

            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(12, 132);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(44, 13);
            this.lblJumlah.TabIndex = 4;
            this.lblJumlah.Text = "Jumlah";

            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(12, 154);
            this.nudJumlah.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(120, 20);
            this.nudJumlah.TabIndex = 5;
            this.nudJumlah.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 192);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";

            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(12, 214);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 20);
            this.txtTotal.TabIndex = 7;

            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(12, 252);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(100, 36);
            this.btnHitung.TabIndex = 8;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Simpan Transaksi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(282, 252);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 36);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // FormManageTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormManageTransaksi";
            this.Text = "Manage Transaksi";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}

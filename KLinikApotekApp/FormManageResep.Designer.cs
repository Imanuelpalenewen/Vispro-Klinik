using System;
using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormManageResep
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvResep;
        private Panel panelInputs;
        private Label lblPasien;
        private ComboBox cbPasien;
        private Label lblObat;
        private ComboBox cbObat;
        private Label lblDosis;
        private TextBox txtDosis;
        private Label lblAturan;
        private TextBox txtAturan;
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
            this.dgvResep = new System.Windows.Forms.DataGridView();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.lblPasien = new System.Windows.Forms.Label();
            this.cbPasien = new System.Windows.Forms.ComboBox();
            this.lblObat = new System.Windows.Forms.Label();
            this.cbObat = new System.Windows.Forms.ComboBox();
            this.lblDosis = new System.Windows.Forms.Label();
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.lblAturan = new System.Windows.Forms.Label();
            this.txtAturan = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResep)).BeginInit();
            this.panelInputs.SuspendLayout();
            this.panelHeader.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(130, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Resep";

            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dgvResep);
            this.panelMain.Controls.Add(this.panelInputs);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1000, 540);
            this.panelMain.TabIndex = 1;

            // 
            // dgvResep
            // 
            this.dgvResep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResep.Location = new System.Drawing.Point(10, 10);
            this.dgvResep.MultiSelect = false;
            this.dgvResep.Name = "dgvResep";
            this.dgvResep.ReadOnly = true;
            this.dgvResep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResep.Size = new System.Drawing.Size(600, 520);
            this.dgvResep.TabIndex = 0;
            this.dgvResep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResep_CellClick);

            // 
            // panelInputs
            // 
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInputs.Controls.Add(this.btnClear);
            this.panelInputs.Controls.Add(this.btnDelete);
            this.panelInputs.Controls.Add(this.btnUpdate);
            this.panelInputs.Controls.Add(this.btnAdd);
            this.panelInputs.Controls.Add(this.txtAturan);
            this.panelInputs.Controls.Add(this.lblAturan);
            this.panelInputs.Controls.Add(this.txtDosis);
            this.panelInputs.Controls.Add(this.lblDosis);
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
            // lblDosis
            // 
            this.lblDosis.AutoSize = true;
            this.lblDosis.Location = new System.Drawing.Point(12, 132);
            this.lblDosis.Name = "lblDosis";
            this.lblDosis.Size = new System.Drawing.Size(35, 13);
            this.lblDosis.TabIndex = 4;
            this.lblDosis.Text = "Dosis";

            // 
            // txtDosis
            // 
            this.txtDosis.Location = new System.Drawing.Point(12, 154);
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(340, 20);
            this.txtDosis.TabIndex = 5;

            // 
            // lblAturan
            // 
            this.lblAturan.AutoSize = true;
            this.lblAturan.Location = new System.Drawing.Point(12, 192);
            this.lblAturan.Name = "lblAturan";
            this.lblAturan.Size = new System.Drawing.Size(69, 13);
            this.lblAturan.TabIndex = 6;
            this.lblAturan.Text = "Aturan Pakai";

            // 
            // txtAturan
            // 
            this.txtAturan.Location = new System.Drawing.Point(12, 214);
            this.txtAturan.Name = "txtAturan";
            this.txtAturan.Size = new System.Drawing.Size(340, 20);
            this.txtAturan.TabIndex = 7;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(192, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 36);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(192, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // FormManageResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormManageResep";
            this.Text = "Manage Resep";
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResep)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}

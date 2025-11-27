namespace KlinikApotekApp
{
    partial class FormDashboardUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBeliObat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListObat = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListObat)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10);
            this.panelHeader.Size = new System.Drawing.Size(900, 70);
            this.panelHeader.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(788, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(250, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Dashboard Pasien - Klinik Apotek";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRiwayat);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(884, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Riwayat Transaksi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.AllowUserToAddRows = false;
            this.dgvRiwayat.AllowUserToDeleteRows = false;
            this.dgvRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRiwayat.Location = new System.Drawing.Point(3, 49);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.ReadOnly = true;
            this.dgvRiwayat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRiwayat.Size = new System.Drawing.Size(878, 380);
            this.dgvRiwayat.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 46);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(300, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Riwayat Transaksi Pembelian Obat";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBeliObat);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtCari);
            this.tabPage1.Controls.Add(this.btnCari);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvListObat);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(884, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List Obat";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnBeliObat
            // 
            this.btnBeliObat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnBeliObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeliObat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBeliObat.ForeColor = System.Drawing.Color.White;
            this.btnBeliObat.Location = new System.Drawing.Point(740, 65);
            this.btnBeliObat.Name = "btnBeliObat";
            this.btnBeliObat.Size = new System.Drawing.Size(120, 35);
            this.btnBeliObat.TabIndex = 7;
            this.btnBeliObat.Text = "Beli Obat";
            this.btnBeliObat.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(25, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Petunjuk: Centang obat yang ingin dibeli dan atur jumlahnya, lalu klik Beli Obat";
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCari.Location = new System.Drawing.Point(142, 69);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(300, 25);
            this.txtCari.TabIndex = 5;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(458, 66);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(90, 30);
            this.btnCari.TabIndex = 4;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cari Obat";
            // 
            // dgvListObat
            // 
            this.dgvListObat.AllowUserToAddRows = false;
            this.dgvListObat.AllowUserToDeleteRows = false;
            this.dgvListObat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListObat.Location = new System.Drawing.Point(25, 135);
            this.dgvListObat.Name = "dgvListObat";
            this.dgvListObat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListObat.Size = new System.Drawing.Size(835, 280);
            this.dgvListObat.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daftar Obat Tersedia";
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "lihat obat";
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl1.Location = new System.Drawing.Point(4, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 460);
            this.tabControl1.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(15, 80);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(123, 19);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Selamat Datang, ...";
            // 
            // FormDashboardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 575);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormDashboardUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Pasien";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListObat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBeliObat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListObat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.Label lblWelcome;
    }
}
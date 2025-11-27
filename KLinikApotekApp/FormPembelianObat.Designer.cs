namespace KlinikApotekApp
{
    partial class FormPembelianObat
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
            this.button2 = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.panelHeader.Controls.Add(this.button2);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10);
            this.panelHeader.Size = new System.Drawing.Size(800, 70);
            this.panelHeader.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(690, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(292, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(152, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Pembelian Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daftar Obat yang dipilih :";
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Location = new System.Drawing.Point(50, 137);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.Size = new System.Drawing.Size(692, 256);
            this.dgvKeranjang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Pembayaran :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rp. ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(215, 421);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(11, 16);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "-";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.DarkGray;
            this.btnBatal.Location = new System.Drawing.Point(642, 471);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 35);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "Batalkan";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBayar.Location = new System.Drawing.Point(479, 471);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(100, 35);
            this.btnBayar.TabIndex = 9;
            this.btnBayar.Text = "Bayar Sekarang";
            this.btnBayar.UseVisualStyleBackColor = false;
            // 
            // FormPembelianObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormPembelianObat";
            this.Text = "FormPembelianObat";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnBayar;
    }
}
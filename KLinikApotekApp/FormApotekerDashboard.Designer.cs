using System;
using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormApotekerDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelSidebar;
        private Button btnViewObat;
        private Button btnInputTransaksi;
        private Button btnViewResep;
        private Button btnLogout;
        private Panel panelContainer;

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
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnViewObat = new System.Windows.Forms.Button();
            this.btnInputTransaksi = new System.Windows.Forms.Button();
            this.btnViewResep = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(135)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 70);
            this.panelHeader.TabIndex = 0;

            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(16, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(190, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Dashboard Apoteker";

            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.panelSidebar.Controls.Add(this.btnViewObat);
            this.panelSidebar.Controls.Add(this.btnInputTransaksi);
            this.panelSidebar.Controls.Add(this.btnViewResep);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(10);
            this.panelSidebar.Size = new System.Drawing.Size(200, 630);
            this.panelSidebar.TabIndex = 1;

            // 
            // btnViewObat
            // 
            this.btnViewObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewObat.Location = new System.Drawing.Point(12, 20);
            this.btnViewObat.Name = "btnViewObat";
            this.btnViewObat.Size = new System.Drawing.Size(170, 40);
            this.btnViewObat.TabIndex = 0;
            this.btnViewObat.Text = "View Obat";
            this.btnViewObat.UseVisualStyleBackColor = true;
            this.btnViewObat.Click += new System.EventHandler(this.btnViewObat_Click);

            // 
            // btnInputTransaksi
            // 
            this.btnInputTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputTransaksi.Location = new System.Drawing.Point(12, 68);
            this.btnInputTransaksi.Name = "btnInputTransaksi";
            this.btnInputTransaksi.Size = new System.Drawing.Size(170, 40);
            this.btnInputTransaksi.TabIndex = 1;
            this.btnInputTransaksi.Text = "Input Transaksi";
            this.btnInputTransaksi.UseVisualStyleBackColor = true;
            this.btnInputTransaksi.Click += new System.EventHandler(this.btnInputTransaksi_Click);

            // 
            // btnViewResep
            // 
            this.btnViewResep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewResep.Location = new System.Drawing.Point(12, 116);
            this.btnViewResep.Name = "btnViewResep";
            this.btnViewResep.Size = new System.Drawing.Size(170, 40);
            this.btnViewResep.TabIndex = 2;
            this.btnViewResep.Text = "View Resep";
            this.btnViewResep.UseVisualStyleBackColor = true;
            this.btnViewResep.Click += new System.EventHandler(this.btnViewResep_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(12, 164);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(170, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(200, 70);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(12);
            this.panelContainer.Size = new System.Drawing.Size(1000, 630);
            this.panelContainer.TabIndex = 2;

            // 
            // FormApotekerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormApotekerDashboard";
            this.Text = "Apoteker Dashboard - Klinik Apotek";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
    }
}

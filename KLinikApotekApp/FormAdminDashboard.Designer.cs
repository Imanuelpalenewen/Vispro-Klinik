using System;
using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormAdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelSidebar;
        private Button btnManagePasien;
        private Button btnManageObat;
        private Button btnManageResep;
        private Button btnManageTransaksi;
        private Button btnManageUsers;
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
            this.btnManagePasien = new System.Windows.Forms.Button();
            this.btnManageObat = new System.Windows.Forms.Button();
            this.btnManageResep = new System.Windows.Forms.Button();
            this.btnManageTransaksi = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10);
            this.panelHeader.Size = new System.Drawing.Size(1200, 70);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(16, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(316, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Dashboard Admin - Klinik & Apotek";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.panelSidebar.Controls.Add(this.btnManagePasien);
            this.panelSidebar.Controls.Add(this.btnManageObat);
            this.panelSidebar.Controls.Add(this.btnManageResep);
            this.panelSidebar.Controls.Add(this.btnManageTransaksi);
            this.panelSidebar.Controls.Add(this.btnManageUsers);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(10);
            this.panelSidebar.Size = new System.Drawing.Size(220, 630);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnManagePasien
            // 
            this.btnManagePasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePasien.Location = new System.Drawing.Point(15, 20);
            this.btnManagePasien.Name = "btnManagePasien";
            this.btnManagePasien.Size = new System.Drawing.Size(190, 40);
            this.btnManagePasien.TabIndex = 0;
            this.btnManagePasien.Text = "Manage Pasien";
            this.btnManagePasien.UseVisualStyleBackColor = true;
            this.btnManagePasien.Click += new System.EventHandler(this.btnManagePasien_Click);
            // 
            // btnManageObat
            // 
            this.btnManageObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageObat.Location = new System.Drawing.Point(15, 68);
            this.btnManageObat.Name = "btnManageObat";
            this.btnManageObat.Size = new System.Drawing.Size(190, 40);
            this.btnManageObat.TabIndex = 1;
            this.btnManageObat.Text = "Manage Obat";
            this.btnManageObat.UseVisualStyleBackColor = true;
            this.btnManageObat.Click += new System.EventHandler(this.btnManageObat_Click);
            // 
            // btnManageResep
            // 
            this.btnManageResep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageResep.Location = new System.Drawing.Point(15, 116);
            this.btnManageResep.Name = "btnManageResep";
            this.btnManageResep.Size = new System.Drawing.Size(190, 40);
            this.btnManageResep.TabIndex = 2;
            this.btnManageResep.Text = "Manage Resep";
            this.btnManageResep.UseVisualStyleBackColor = true;
            this.btnManageResep.Click += new System.EventHandler(this.btnManageResep_Click);
            // 
            // btnManageTransaksi
            // 
            this.btnManageTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTransaksi.Location = new System.Drawing.Point(15, 164);
            this.btnManageTransaksi.Name = "btnManageTransaksi";
            this.btnManageTransaksi.Size = new System.Drawing.Size(190, 40);
            this.btnManageTransaksi.TabIndex = 3;
            this.btnManageTransaksi.Text = "Manage Transaksi";
            this.btnManageTransaksi.UseVisualStyleBackColor = true;
            this.btnManageTransaksi.Click += new System.EventHandler(this.btnManageTransaksi_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Location = new System.Drawing.Point(15, 212);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(190, 40);
            this.btnManageUsers.TabIndex = 4;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(15, 260);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(220, 70);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(12);
            this.panelContainer.Size = new System.Drawing.Size(980, 630);
            this.panelContainer.TabIndex = 2;
            // 
            // FormAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormAdminDashboard";
            this.Text = "Admin Dashboard - Klinik Apotek";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}

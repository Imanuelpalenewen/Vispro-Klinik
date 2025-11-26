using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormViewResep
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvResep;
        private Panel panelFilter;
        private Label lblPasien;
        private ComboBox cbPasien;
        private Button btnFilter;
        private Button btnClearFilter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvResep = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblPasien = new System.Windows.Forms.Label();
            this.cbPasien = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResep)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(135)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1370, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(107, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Daftar Resep";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dgvResep);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 116);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1370, 460);
            this.panelMain.TabIndex = 0;
            // 
            // dgvResep
            // 
            this.dgvResep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResep.ColumnHeadersHeight = 34;
            this.dgvResep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResep.Location = new System.Drawing.Point(10, 10);
            this.dgvResep.MultiSelect = false;
            this.dgvResep.Name = "dgvResep";
            this.dgvResep.ReadOnly = true;
            this.dgvResep.RowHeadersWidth = 62;
            this.dgvResep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResep.Size = new System.Drawing.Size(1350, 440);
            this.dgvResep.TabIndex = 0;
            this.dgvResep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResep_CellContentClick);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.lblPasien);
            this.panelFilter.Controls.Add(this.cbPasien);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.btnClearFilter);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 60);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(8);
            this.panelFilter.Size = new System.Drawing.Size(1370, 56);
            this.panelFilter.TabIndex = 1;
            // 
            // lblPasien
            // 
            this.lblPasien.Location = new System.Drawing.Point(8, 18);
            this.lblPasien.Name = "lblPasien";
            this.lblPasien.Size = new System.Drawing.Size(100, 23);
            this.lblPasien.TabIndex = 0;
            this.lblPasien.Text = "Pasien:";
            // 
            // cbPasien
            // 
            this.cbPasien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasien.Location = new System.Drawing.Point(66, 14);
            this.cbPasien.Name = "cbPasien";
            this.cbPasien.Size = new System.Drawing.Size(240, 21);
            this.cbPasien.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(320, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(400, 12);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilter.TabIndex = 3;
            this.btnClearFilter.Text = "Clear";
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // FormViewResep
            // 
            this.ClientSize = new System.Drawing.Size(1370, 576);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormViewResep";
            this.Text = "View Resep";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResep)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

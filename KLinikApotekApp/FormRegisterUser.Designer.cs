namespace KlinikApotekApp
{
    partial class FormRegisterUser
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(250, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registrasi Pasien Baru";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10);
            this.panelHeader.Size = new System.Drawing.Size(800, 70);
            this.panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Umur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "No HP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password Login";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(140, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Username Login";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(280, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(140, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Alamat";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamaLengkap.Location = new System.Drawing.Point(296, 97);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(350, 23);
            this.txtNamaLengkap.TabIndex = 14;
            // 
            // txtUmur
            // 
            this.txtUmur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUmur.Location = new System.Drawing.Point(296, 132);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(100, 23);
            this.txtUmur.TabIndex = 15;
            // 
            // txtNoHP
            // 
            this.txtNoHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoHP.Location = new System.Drawing.Point(296, 167);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(350, 23);
            this.txtNoHP.TabIndex = 16;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAlamat.Location = new System.Drawing.Point(296, 202);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(350, 23);
            this.txtAlamat.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Location = new System.Drawing.Point(296, 237);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(350, 23);
            this.txtUsername.TabIndex = 18;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(296, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(350, 23);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(296, 315);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 40);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBackToLogin.Location = new System.Drawing.Point(476, 315);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(170, 40);
            this.btnBackToLogin.TabIndex = 21;
            this.btnBackToLogin.Text = "Kembali";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            // 
            // FormRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNoHP);
            this.Controls.Add(this.txtUmur);
            this.Controls.Add(this.txtNamaLengkap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrasi Pasien";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBackToLogin;
    }
}
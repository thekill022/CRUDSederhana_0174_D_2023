namespace CRUDSederhana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NIM = new Label();
            txtNIM = new TextBox();
            label1 = new Label();
            txtNama = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelepon = new TextBox();
            label4 = new Label();
            txtAlamat = new TextBox();
            label5 = new Label();
            btnTambah = new Button();
            btnHapus = new Button();
            btnReferesh = new Button();
            dgvMahasiswa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMahasiswa).BeginInit();
            SuspendLayout();
            // 
            // NIM
            // 
            NIM.AutoSize = true;
            NIM.Font = new Font("Segoe UI", 12F);
            NIM.Location = new Point(77, 78);
            NIM.Name = "NIM";
            NIM.Size = new Size(60, 32);
            NIM.TabIndex = 0;
            NIM.Text = "NIM";
            // 
            // txtNIM
            // 
            txtNIM.Location = new Point(143, 81);
            txtNIM.Name = "txtNIM";
            txtNIM.Size = new Size(320, 31);
            txtNIM.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(228, 9);
            label1.Name = "label1";
            label1.Size = new Size(391, 38);
            label1.TabIndex = 2;
            label1.Text = "Aplikasi Input Data Mahasiswa";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(143, 130);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(320, 31);
            txtNama.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(59, 130);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 3;
            label2.Text = "Nama";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 31);
            txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(62, 182);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // txtTelepon
            // 
            txtTelepon.Location = new Point(143, 236);
            txtTelepon.Name = "txtTelepon";
            txtTelepon.Size = new Size(320, 31);
            txtTelepon.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(34, 236);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 7;
            label4.Text = "Telepon";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(143, 294);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(320, 31);
            txtAlamat.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(45, 294);
            label5.Name = "label5";
            label5.Size = new Size(88, 32);
            label5.TabIndex = 9;
            label5.Text = "Alamat";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(539, 95);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(231, 58);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(539, 171);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(231, 58);
            btnHapus.TabIndex = 12;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnReferesh
            // 
            btnReferesh.Location = new Point(539, 251);
            btnReferesh.Name = "btnReferesh";
            btnReferesh.Size = new Size(231, 58);
            btnReferesh.TabIndex = 13;
            btnReferesh.Text = "Referesh";
            btnReferesh.UseVisualStyleBackColor = true;
            btnReferesh.Click += btnReferesh_Click;
            // 
            // dgvMahasiswa
            // 
            dgvMahasiswa.AllowUserToAddRows = false;
            dgvMahasiswa.AllowUserToDeleteRows = false;
            dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMahasiswa.Location = new Point(0, 354);
            dgvMahasiswa.Name = "dgvMahasiswa";
            dgvMahasiswa.ReadOnly = true;
            dgvMahasiswa.RowHeadersWidth = 62;
            dgvMahasiswa.Size = new Size(850, 303);
            dgvMahasiswa.TabIndex = 14;
            dgvMahasiswa.CellClick += dgvMahasiswa_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 688);
            Controls.Add(dgvMahasiswa);
            Controls.Add(btnReferesh);
            Controls.Add(btnHapus);
            Controls.Add(btnTambah);
            Controls.Add(txtAlamat);
            Controls.Add(label5);
            Controls.Add(txtTelepon);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNIM);
            Controls.Add(NIM);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMahasiswa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NIM;
        private TextBox txtNIM;
        private Label label1;
        private TextBox txtNama;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelepon;
        private Label label4;
        private TextBox txtAlamat;
        private Label label5;
        private Button btnTambah;
        private Button btnHapus;
        private Button btnReferesh;
        private DataGridView dgvMahasiswa;
    }
}

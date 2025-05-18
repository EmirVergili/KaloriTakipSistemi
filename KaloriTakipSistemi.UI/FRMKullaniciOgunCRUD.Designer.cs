namespace KaloriTakipSistemi.UI
{
    partial class FRMKullaniciOgunCRUD
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
            dtpYemekTarihi = new DateTimePicker();
            cmbOgun = new ComboBox();
            label1 = new Label();
            btnEkle = new Button();
            label2 = new Label();
            label3 = new Label();
            cmbYemek = new ComboBox();
            label5 = new Label();
            btnSil = new Button();
            btnGuncelle = new Button();
            label4 = new Label();
            nudMiktar = new NumericUpDown();
            dgvOgunler = new DataGridView();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpYemekTarihi
            // 
            dtpYemekTarihi.Location = new Point(199, 46);
            dtpYemekTarihi.Margin = new Padding(3, 2, 3, 2);
            dtpYemekTarihi.Name = "dtpYemekTarihi";
            dtpYemekTarihi.Size = new Size(295, 32);
            dtpYemekTarihi.TabIndex = 0;
            // 
            // cmbOgun
            // 
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(199, 109);
            cmbOgun.Margin = new Padding(3, 2, 3, 2);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(295, 31);
            cmbOgun.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 245, 247);
            label1.Location = new Point(73, 53);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 3;
            label1.Text = "Tarih";
            // 
            // btnEkle
            // 
            btnEkle.FlatStyle = FlatStyle.Popup;
            btnEkle.Location = new Point(73, 335);
            btnEkle.Margin = new Padding(3, 2, 3, 2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(157, 52);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 245, 247);
            label2.Location = new Point(73, 112);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 3;
            label2.Text = "Öğün";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(243, 245, 247);
            label3.Location = new Point(73, 230);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 3;
            label3.Text = "Miktar";
            // 
            // cmbYemek
            // 
            cmbYemek.FormattingEnabled = true;
            cmbYemek.Location = new Point(199, 168);
            cmbYemek.Margin = new Padding(3, 2, 3, 2);
            cmbYemek.Name = "cmbYemek";
            cmbYemek.Size = new Size(295, 31);
            cmbYemek.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(243, 245, 247);
            label5.Location = new Point(73, 171);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 3;
            label5.Text = "Yemek";
            // 
            // btnSil
            // 
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Location = new Point(264, 335);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(157, 52);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.FlatStyle = FlatStyle.Popup;
            btnGuncelle.Location = new Point(455, 335);
            btnGuncelle.Margin = new Padding(3, 2, 3, 2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(157, 52);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(243, 245, 247);
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(199, 262);
            label4.Name = "label4";
            label4.Size = new Size(413, 21);
            label4.TabIndex = 5;
            label4.Text = "(1 porsiyon yaklaşık 100 grama denk gelmektedir)";
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(199, 228);
            nudMiktar.Margin = new Padding(3, 2, 3, 2);
            nudMiktar.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(100, 32);
            nudMiktar.TabIndex = 6;
            nudMiktar.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvOgunler
            // 
            dgvOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunler.Location = new Point(53, 429);
            dgvOgunler.Margin = new Padding(3, 2, 3, 2);
            dgvOgunler.Name = "dgvOgunler";
            dgvOgunler.RowHeadersWidth = 51;
            dgvOgunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgunler.Size = new Size(834, 134);
            dgvOgunler.TabIndex = 7;
            dgvOgunler.CellClick += dgvOgunler_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pineapple_slice_wooden_tray_against_white_background;
            pictureBox1.Location = new Point(-583, -404);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2199, 1242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(243, 245, 247);
            label6.Location = new Point(305, 230);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 5;
            label6.Text = "Porsiyon";
            // 
            // FRMKullaniciOgunCRUD
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 623);
            Controls.Add(dgvOgunler);
            Controls.Add(nudMiktar);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbYemek);
            Controls.Add(cmbOgun);
            Controls.Add(dtpYemekTarihi);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FRMKullaniciOgunCRUD";
            Text = "Öğün Ekle";
            Load += FRMKullaniciOgunCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpYemekTarihi;
        private ComboBox cmbOgun;
        private Label label1;
        private Button btnEkle;
        private Label label2;
        private Label label3;
        private ComboBox cmbYemek;
        private Label label5;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label4;
        private NumericUpDown nudMiktar;
        private DataGridView dgvOgunler;
        private PictureBox pictureBox1;
        private Label label6;
    }
}
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
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).BeginInit();
            SuspendLayout();
            // 
            // dtpYemekTarihi
            // 
            dtpYemekTarihi.Location = new Point(295, 12);
            dtpYemekTarihi.Name = "dtpYemekTarihi";
            dtpYemekTarihi.Size = new Size(271, 29);
            dtpYemekTarihi.TabIndex = 0;
            // 
            // cmbOgun
            // 
            cmbOgun.FormattingEnabled = true;
            cmbOgun.Location = new Point(295, 118);
            cmbOgun.Name = "cmbOgun";
            cmbOgun.Size = new Size(271, 29);
            cmbOgun.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 20);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 3;
            label1.Text = "Tarih";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(131, 321);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(144, 63);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 121);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 3;
            label2.Text = "Öğün";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 241);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 3;
            label3.Text = "Miktar";
            // 
            // cmbYemek
            // 
            cmbYemek.FormattingEnabled = true;
            cmbYemek.Location = new Point(295, 174);
            cmbYemek.Name = "cmbYemek";
            cmbYemek.Size = new Size(271, 29);
            cmbYemek.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 177);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 3;
            label5.Text = "Yemek";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(311, 321);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(157, 63);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(494, 321);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(154, 63);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 243);
            label4.Name = "label4";
            label4.Size = new Size(430, 21);
            label4.TabIndex = 5;
            label4.Text = "Porsiyon ( 1 porsiyon yaklaşık 100 grama denk gelmektedir )";
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(295, 241);
            nudMiktar.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(92, 29);
            nudMiktar.TabIndex = 6;
            // 
            // dgvOgunler
            // 
            dgvOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunler.Location = new Point(105, 418);
            dgvOgunler.Name = "dgvOgunler";
            dgvOgunler.RowHeadersWidth = 51;
            dgvOgunler.Size = new Size(789, 163);
            dgvOgunler.TabIndex = 7;
            // 
            // FRMKullaniciOgunCRUD
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 630);
            Controls.Add(dgvOgunler);
            Controls.Add(nudMiktar);
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
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FRMKullaniciOgunCRUD";
            Text = "Öğün Ekle";
            Load += FRMKullaniciOgunCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).EndInit();
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
    }
}
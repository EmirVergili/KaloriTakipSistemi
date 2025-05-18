namespace KaloriTakipSistemi.UI.Models
{
    partial class FRMKullaniciAzCokYedikleri
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
            dtpBitisTarihi = new DateTimePicker();
            dtpBaslangicTarihi = new DateTimePicker();
            lblAzYediklerim = new Label();
            label2 = new Label();
            lblEnAzYedigimYemek = new Label();
            lblEnCokYedigimYemek = new Label();
            btnGoster = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Location = new Point(509, 44);
            dtpBitisTarihi.Margin = new Padding(4, 5, 4, 5);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(340, 32);
            dtpBitisTarihi.TabIndex = 0;
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Location = new Point(86, 44);
            dtpBaslangicTarihi.Margin = new Padding(4, 5, 4, 5);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(340, 32);
            dtpBaslangicTarihi.TabIndex = 1;
            // 
            // lblAzYediklerim
            // 
            lblAzYediklerim.AutoSize = true;
            lblAzYediklerim.BackColor = Color.FromArgb(249, 250, 251);
            lblAzYediklerim.Location = new Point(150, 217);
            lblAzYediklerim.Margin = new Padding(4, 0, 4, 0);
            lblAzYediklerim.Name = "lblAzYediklerim";
            lblAzYediklerim.Size = new Size(232, 23);
            lblAzYediklerim.TabIndex = 2;
            lblAzYediklerim.Text = "En Az Yediğim Yemek :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(249, 250, 251);
            label2.Location = new Point(150, 271);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(247, 23);
            label2.TabIndex = 3;
            label2.Text = "En Çok Yediğim Yemek :";
            // 
            // lblEnAzYedigimYemek
            // 
            lblEnAzYedigimYemek.AutoSize = true;
            lblEnAzYedigimYemek.BackColor = Color.FromArgb(249, 250, 251);
            lblEnAzYedigimYemek.Location = new Point(464, 217);
            lblEnAzYedigimYemek.Margin = new Padding(4, 0, 4, 0);
            lblEnAzYedigimYemek.Name = "lblEnAzYedigimYemek";
            lblEnAzYedigimYemek.Size = new Size(0, 23);
            lblEnAzYedigimYemek.TabIndex = 4;
            // 
            // lblEnCokYedigimYemek
            // 
            lblEnCokYedigimYemek.AutoSize = true;
            lblEnCokYedigimYemek.BackColor = Color.FromArgb(249, 250, 251);
            lblEnCokYedigimYemek.Location = new Point(464, 271);
            lblEnCokYedigimYemek.Margin = new Padding(4, 0, 4, 0);
            lblEnCokYedigimYemek.Name = "lblEnCokYedigimYemek";
            lblEnCokYedigimYemek.Size = new Size(0, 23);
            lblEnCokYedigimYemek.TabIndex = 5;
            // 
            // btnGoster
            // 
            btnGoster.FlatStyle = FlatStyle.Popup;
            btnGoster.Location = new Point(397, 108);
            btnGoster.Margin = new Padding(4, 5, 4, 5);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(139, 44);
            btnGoster.TabIndex = 6;
            btnGoster.Text = "Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.healthy_vegetarian_food_spices;
            pictureBox1.Location = new Point(-304, -368);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1490, 1020);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FRMKullaniciAzCokYedikleri
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 623);
            Controls.Add(btnGoster);
            Controls.Add(lblEnCokYedigimYemek);
            Controls.Add(lblEnAzYedigimYemek);
            Controls.Add(label2);
            Controls.Add(lblAzYediklerim);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FRMKullaniciAzCokYedikleri";
            Text = "FRMKullaniciAzCokYedikleri";
            Load += FRMKullaniciAzCokYedikleri_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpBitisTarihi;
        private DateTimePicker dtpBaslangicTarihi;
        private Label lblAzYediklerim;
        private Label label2;
        private Label lblEnAzYedigimYemek;
        private Label lblEnCokYedigimYemek;
        private Button btnGoster;
        private PictureBox pictureBox1;
    }
}
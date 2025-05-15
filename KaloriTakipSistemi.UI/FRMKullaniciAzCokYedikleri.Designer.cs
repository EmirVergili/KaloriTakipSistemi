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
            SuspendLayout();
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Location = new Point(331, 16);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(200, 23);
            dtpBitisTarihi.TabIndex = 0;
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Location = new Point(81, 12);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(200, 23);
            dtpBaslangicTarihi.TabIndex = 1;
            // 
            // lblAzYediklerim
            // 
            lblAzYediklerim.AutoSize = true;
            lblAzYediklerim.Location = new Point(81, 49);
            lblAzYediklerim.Name = "lblAzYediklerim";
            lblAzYediklerim.Size = new Size(120, 15);
            lblAzYediklerim.TabIndex = 2;
            lblAzYediklerim.Text = "En Az Yediğim Yemek";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 93);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 3;
            label2.Text = "En Çok Yediğim Yemek";
            // 
            // lblEnAzYedigimYemek
            // 
            lblEnAzYedigimYemek.AutoSize = true;
            lblEnAzYedigimYemek.Location = new Point(363, 49);
            lblEnAzYedigimYemek.Name = "lblEnAzYedigimYemek";
            lblEnAzYedigimYemek.Size = new Size(38, 15);
            lblEnAzYedigimYemek.TabIndex = 4;
            lblEnAzYedigimYemek.Text = "label3";
            // 
            // lblEnCokYedigimYemek
            // 
            lblEnCokYedigimYemek.AutoSize = true;
            lblEnCokYedigimYemek.Location = new Point(363, 93);
            lblEnCokYedigimYemek.Name = "lblEnCokYedigimYemek";
            lblEnCokYedigimYemek.Size = new Size(38, 15);
            lblEnCokYedigimYemek.TabIndex = 5;
            lblEnCokYedigimYemek.Text = "label4";
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(601, 12);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(101, 38);
            btnGoster.TabIndex = 6;
            btnGoster.Text = "Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // FRMKullaniciAzCokYedikleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoster);
            Controls.Add(lblEnCokYedigimYemek);
            Controls.Add(lblEnAzYedigimYemek);
            Controls.Add(label2);
            Controls.Add(lblAzYediklerim);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(dtpBitisTarihi);
            Name = "FRMKullaniciAzCokYedikleri";
            Text = "FRMKullaniciAzCokYedikleri";
            Load += FRMKullaniciAzCokYedikleri_Load;
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
    }
}
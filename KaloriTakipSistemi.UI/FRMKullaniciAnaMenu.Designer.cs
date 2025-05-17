namespace KaloriTakipSistemi.UI
{
    partial class FRMKullaniciAnaMenu
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
            btnKisiselBilgiler = new Button();
            btnOgunEkle = new Button();
            btnOgunlerim = new Button();
            btnHesapDondur = new Button();
            btnEnCokAzYediklerim = new Button();
            pnlKullaniciAnaMenuIcerik = new Panel();
            SuspendLayout();
            // 
            // btnKisiselBilgiler
            // 
            btnKisiselBilgiler.Location = new Point(25, 314);
            btnKisiselBilgiler.Margin = new Padding(3, 2, 3, 2);
            btnKisiselBilgiler.Name = "btnKisiselBilgiler";
            btnKisiselBilgiler.Size = new Size(203, 63);
            btnKisiselBilgiler.TabIndex = 0;
            btnKisiselBilgiler.Text = "Kişisel Bilgiler";
            btnKisiselBilgiler.UseVisualStyleBackColor = true;
            btnKisiselBilgiler.Click += btnKisiselBilgiler_Click;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.Location = new Point(25, 211);
            btnOgunEkle.Margin = new Padding(3, 2, 3, 2);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(203, 63);
            btnOgunEkle.TabIndex = 0;
            btnOgunEkle.Text = "Öğün Ekle";
            btnOgunEkle.UseVisualStyleBackColor = true;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // btnOgunlerim
            // 
            btnOgunlerim.Location = new Point(25, 41);
            btnOgunlerim.Margin = new Padding(3, 2, 3, 2);
            btnOgunlerim.Name = "btnOgunlerim";
            btnOgunlerim.Size = new Size(203, 63);
            btnOgunlerim.TabIndex = 0;
            btnOgunlerim.Text = "Öğünlerim";
            btnOgunlerim.UseVisualStyleBackColor = true;
            btnOgunlerim.Click += btnOgunlerim_Click;
            // 
            // btnHesapDondur
            // 
            btnHesapDondur.Location = new Point(25, 412);
            btnHesapDondur.Margin = new Padding(3, 2, 3, 2);
            btnHesapDondur.Name = "btnHesapDondur";
            btnHesapDondur.Size = new Size(203, 63);
            btnHesapDondur.TabIndex = 0;
            btnHesapDondur.Text = "Hesap Dondur";
            btnHesapDondur.UseVisualStyleBackColor = true;
            btnHesapDondur.Click += btnHesapDondur_Click;
            // 
            // btnEnCokAzYediklerim
            // 
            btnEnCokAzYediklerim.Location = new Point(25, 126);
            btnEnCokAzYediklerim.Margin = new Padding(3, 2, 3, 2);
            btnEnCokAzYediklerim.Name = "btnEnCokAzYediklerim";
            btnEnCokAzYediklerim.Size = new Size(203, 63);
            btnEnCokAzYediklerim.TabIndex = 0;
            btnEnCokAzYediklerim.Text = "En Çok/Az Yediklerim";
            btnEnCokAzYediklerim.UseVisualStyleBackColor = true;
            btnEnCokAzYediklerim.Click += btnEnCokAzYediklerim_Click;
            // 
            // pnlKullaniciAnaMenuIcerik
            // 
            pnlKullaniciAnaMenuIcerik.Location = new Point(267, 10);
            pnlKullaniciAnaMenuIcerik.Margin = new Padding(3, 2, 3, 2);
            pnlKullaniciAnaMenuIcerik.Name = "pnlKullaniciAnaMenuIcerik";
            pnlKullaniciAnaMenuIcerik.Size = new Size(1385, 591);
            pnlKullaniciAnaMenuIcerik.TabIndex = 1;
            // 
            // FRMKullaniciAnaMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1666, 610);
            Controls.Add(pnlKullaniciAnaMenuIcerik);
            Controls.Add(btnEnCokAzYediklerim);
            Controls.Add(btnHesapDondur);
            Controls.Add(btnOgunEkle);
            Controls.Add(btnOgunlerim);
            Controls.Add(btnKisiselBilgiler);
            Font = new Font("Century Gothic", 12F);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FRMKullaniciAnaMenu";
            Text = "Kullanıcı Ana Menü";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKisiselBilgiler;
        private Button btnOgunEkle;
        private Button btnOgunlerim;
        private Button btnHesapDondur;
        private Button btnEnCokAzYediklerim;
        private Panel pnlKullaniciAnaMenuIcerik;
    }
}
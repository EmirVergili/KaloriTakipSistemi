namespace KaloriTakipSistemi.UI
{
    partial class FRMYoneticiAnaMenu
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
            btnYemekler = new Button();
            btnKullanicilariGoster = new Button();
            btnKullaniciOgunleri = new Button();
            pnlYoneticiAnamenuIcerik = new Panel();
            SuspendLayout();
            // 
            // btnYemekler
            // 
            btnYemekler.Location = new Point(16, 49);
            btnYemekler.Margin = new Padding(4, 3, 4, 3);
            btnYemekler.Name = "btnYemekler";
            btnYemekler.Size = new Size(190, 39);
            btnYemekler.TabIndex = 0;
            btnYemekler.Text = "Yemekler";
            btnYemekler.UseVisualStyleBackColor = true;
            btnYemekler.Click += btnYemekler_Click;
            // 
            // btnKullanicilariGoster
            // 
            btnKullanicilariGoster.Location = new Point(16, 109);
            btnKullanicilariGoster.Margin = new Padding(4, 3, 4, 3);
            btnKullanicilariGoster.Name = "btnKullanicilariGoster";
            btnKullanicilariGoster.Size = new Size(220, 67);
            btnKullanicilariGoster.TabIndex = 1;
            btnKullanicilariGoster.Text = "Kullanıcıları Göster";
            btnKullanicilariGoster.UseVisualStyleBackColor = true;
            btnKullanicilariGoster.Click += btnKullanicilariGoster_Click;
            // 
            // btnKullaniciOgunleri
            // 
            btnKullaniciOgunleri.Location = new Point(5, 196);
            btnKullaniciOgunleri.Margin = new Padding(4, 3, 4, 3);
            btnKullaniciOgunleri.Name = "btnKullaniciOgunleri";
            btnKullaniciOgunleri.Size = new Size(201, 61);
            btnKullaniciOgunleri.TabIndex = 2;
            btnKullaniciOgunleri.Text = "Kullanıcı Öğünleri";
            btnKullaniciOgunleri.UseVisualStyleBackColor = true;
            btnKullaniciOgunleri.Click += btnKullaniciOgunleri_Click;
            // 
            // pnlYoneticiAnamenuIcerik
            // 
            pnlYoneticiAnamenuIcerik.Location = new Point(305, 2);
            pnlYoneticiAnamenuIcerik.Margin = new Padding(4, 3, 4, 3);
            pnlYoneticiAnamenuIcerik.Name = "pnlYoneticiAnamenuIcerik";
            pnlYoneticiAnamenuIcerik.Size = new Size(1031, 588);
            pnlYoneticiAnamenuIcerik.TabIndex = 3;
            // 
            // FRMYoneticiAnaMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 601);
            Controls.Add(pnlYoneticiAnamenuIcerik);
            Controls.Add(btnKullaniciOgunleri);
            Controls.Add(btnKullanicilariGoster);
            Controls.Add(btnYemekler);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FRMYoneticiAnaMenu";
            Text = "FRMYoneticiAnaMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYemekler;
        private Button btnKullanicilariGoster;
        private Button btnKullaniciOgunleri;
        private Panel pnlYoneticiAnamenuIcerik;
    }
}
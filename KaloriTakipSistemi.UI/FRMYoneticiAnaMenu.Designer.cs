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
            btnYemekler.Location = new Point(15, 60);
            btnYemekler.Margin = new Padding(4, 4, 4, 4);
            btnYemekler.Name = "btnYemekler";
            btnYemekler.Size = new Size(96, 32);
            btnYemekler.TabIndex = 0;
            btnYemekler.Text = "Yemekler";
            btnYemekler.UseVisualStyleBackColor = true;
            // 
            // btnKullanicilariGoster
            // 
            btnKullanicilariGoster.Location = new Point(15, 133);
            btnKullanicilariGoster.Margin = new Padding(4, 4, 4, 4);
            btnKullanicilariGoster.Name = "btnKullanicilariGoster";
            btnKullanicilariGoster.Size = new Size(153, 32);
            btnKullanicilariGoster.TabIndex = 1;
            btnKullanicilariGoster.Text = "Kullanıcıları Göster";
            btnKullanicilariGoster.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciOgunleri
            // 
            btnKullaniciOgunleri.Location = new Point(5, 238);
            btnKullaniciOgunleri.Margin = new Padding(4, 4, 4, 4);
            btnKullaniciOgunleri.Name = "btnKullaniciOgunleri";
            btnKullaniciOgunleri.Size = new Size(163, 32);
            btnKullaniciOgunleri.TabIndex = 2;
            btnKullaniciOgunleri.Text = "Kullanıcı Öğünleri";
            btnKullaniciOgunleri.UseVisualStyleBackColor = true;
            // 
            // pnlYoneticiAnamenuIcerik
            // 
            pnlYoneticiAnamenuIcerik.Location = new Point(280, 3);
            pnlYoneticiAnamenuIcerik.Margin = new Padding(4, 4, 4, 4);
            pnlYoneticiAnamenuIcerik.Name = "pnlYoneticiAnamenuIcerik";
            pnlYoneticiAnamenuIcerik.Size = new Size(701, 546);
            pnlYoneticiAnamenuIcerik.TabIndex = 3;
            // 
            // FRMYoneticiAnaMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(pnlYoneticiAnamenuIcerik);
            Controls.Add(btnKullaniciOgunleri);
            Controls.Add(btnKullanicilariGoster);
            Controls.Add(btnYemekler);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
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
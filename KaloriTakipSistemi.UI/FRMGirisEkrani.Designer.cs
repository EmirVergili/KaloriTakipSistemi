namespace KaloriTakipSistemi.UI
{
    partial class FRMGirisEkrani
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
            btnKullaniciGiris = new Button();
            btnYoneticiGiris = new Button();
            SuspendLayout();
            // 
            // btnKullaniciGiris
            // 
            btnKullaniciGiris.Location = new Point(65, 165);
            btnKullaniciGiris.Margin = new Padding(4);
            btnKullaniciGiris.Name = "btnKullaniciGiris";
            btnKullaniciGiris.Size = new Size(342, 190);
            btnKullaniciGiris.TabIndex = 0;
            btnKullaniciGiris.Text = "Kullanıcı Giriş Ekranı";
            btnKullaniciGiris.UseVisualStyleBackColor = true;
            btnKullaniciGiris.Click += btnKullaniciGiris_Click;
            // 
            // btnYoneticiGiris
            // 
            btnYoneticiGiris.Location = new Point(438, 165);
            btnYoneticiGiris.Margin = new Padding(4);
            btnYoneticiGiris.Name = "btnYoneticiGiris";
            btnYoneticiGiris.Size = new Size(360, 190);
            btnYoneticiGiris.TabIndex = 1;
            btnYoneticiGiris.Text = "Yönetici Giriş Ekranı";
            btnYoneticiGiris.UseVisualStyleBackColor = true;
            btnYoneticiGiris.Click += btnYoneticiGiris_Click;
            // 
            // FRMGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 462);
            Controls.Add(btnYoneticiGiris);
            Controls.Add(btnKullaniciGiris);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FRMGirisEkrani";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKullaniciGiris;
        private Button btnYoneticiGiris;
    }
}

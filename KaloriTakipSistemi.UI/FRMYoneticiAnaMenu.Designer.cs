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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnYemekler
            // 
            btnYemekler.Location = new Point(2, 208);
            btnYemekler.Margin = new Padding(4, 3, 4, 3);
            btnYemekler.Name = "btnYemekler";
            btnYemekler.Size = new Size(220, 60);
            btnYemekler.TabIndex = 0;
            btnYemekler.Text = "Yemekler";
            btnYemekler.UseVisualStyleBackColor = true;
            btnYemekler.Click += btnYemekler_Click;
            // 
            // btnKullanicilariGoster
            // 
            btnKullanicilariGoster.Location = new Point(2, 274);
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
            btnKullaniciOgunleri.Location = new Point(2, 347);
            btnKullaniciOgunleri.Margin = new Padding(4, 3, 4, 3);
            btnKullaniciOgunleri.Name = "btnKullaniciOgunleri";
            btnKullaniciOgunleri.Size = new Size(220, 61);
            btnKullaniciOgunleri.TabIndex = 2;
            btnKullaniciOgunleri.Text = "Kullanıcı Öğünleri";
            btnKullaniciOgunleri.UseVisualStyleBackColor = true;
            btnKullaniciOgunleri.Click += btnKullaniciOgunleri_Click;
            // 
            // pnlYoneticiAnamenuIcerik
            // 
            pnlYoneticiAnamenuIcerik.Location = new Point(222, 1);
            pnlYoneticiAnamenuIcerik.Margin = new Padding(4, 3, 4, 3);
            pnlYoneticiAnamenuIcerik.Name = "pnlYoneticiAnamenuIcerik";
            pnlYoneticiAnamenuIcerik.Size = new Size(934, 621);
            pnlYoneticiAnamenuIcerik.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.png1;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FRMYoneticiAnaMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 621);
            Controls.Add(pictureBox1);
            Controls.Add(btnYemekler);
            Controls.Add(pnlYoneticiAnamenuIcerik);
            Controls.Add(btnKullaniciOgunleri);
            Controls.Add(btnKullanicilariGoster);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FRMYoneticiAnaMenu";
            Text = "Yönetici Menü";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnYemekler;
        private Button btnKullanicilariGoster;
        private Button btnKullaniciOgunleri;
        private Panel pnlYoneticiAnamenuIcerik;
        private PictureBox pictureBox1;
    }
}
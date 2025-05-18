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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnYemekler
            // 
            btnYemekler.BackColor = Color.FromArgb(45, 107, 62);
            btnYemekler.FlatStyle = FlatStyle.Popup;
            btnYemekler.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnYemekler.ForeColor = Color.White;
            btnYemekler.Location = new Point(2, 193);
            btnYemekler.Margin = new Padding(4, 3, 4, 3);
            btnYemekler.Name = "btnYemekler";
            btnYemekler.Size = new Size(220, 60);
            btnYemekler.TabIndex = 0;
            btnYemekler.Text = "Yemekler                >\r\n";
            btnYemekler.TextAlign = ContentAlignment.MiddleLeft;
            btnYemekler.UseVisualStyleBackColor = false;
            btnYemekler.Click += btnYemekler_Click;
            // 
            // btnKullanicilariGoster
            // 
            btnKullanicilariGoster.BackColor = Color.FromArgb(45, 107, 62);
            btnKullanicilariGoster.FlatStyle = FlatStyle.Popup;
            btnKullanicilariGoster.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnKullanicilariGoster.ForeColor = Color.White;
            btnKullanicilariGoster.Location = new Point(2, 254);
            btnKullanicilariGoster.Margin = new Padding(4, 3, 4, 3);
            btnKullanicilariGoster.Name = "btnKullanicilariGoster";
            btnKullanicilariGoster.Size = new Size(220, 67);
            btnKullanicilariGoster.TabIndex = 1;
            btnKullanicilariGoster.Text = "Kullanıcılar              >";
            btnKullanicilariGoster.TextAlign = ContentAlignment.MiddleLeft;
            btnKullanicilariGoster.UseVisualStyleBackColor = false;
            btnKullanicilariGoster.Click += btnKullanicilariGoster_Click;
            // 
            // btnKullaniciOgunleri
            // 
            btnKullaniciOgunleri.BackColor = Color.FromArgb(45, 107, 62);
            btnKullaniciOgunleri.FlatStyle = FlatStyle.Popup;
            btnKullaniciOgunleri.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnKullaniciOgunleri.ForeColor = Color.White;
            btnKullaniciOgunleri.Location = new Point(2, 322);
            btnKullaniciOgunleri.Margin = new Padding(4, 3, 4, 3);
            btnKullaniciOgunleri.Name = "btnKullaniciOgunleri";
            btnKullaniciOgunleri.Size = new Size(220, 61);
            btnKullaniciOgunleri.TabIndex = 2;
            btnKullaniciOgunleri.Text = "Kullanıcı Öğünleri   >";
            btnKullaniciOgunleri.TextAlign = ContentAlignment.MiddleLeft;
            btnKullaniciOgunleri.UseVisualStyleBackColor = false;
            btnKullaniciOgunleri.Click += btnKullaniciOgunleri_Click;
            // 
            // pnlYoneticiAnamenuIcerik
            // 
            pnlYoneticiAnamenuIcerik.Location = new Point(222, 0);
            pnlYoneticiAnamenuIcerik.Margin = new Padding(4, 3, 4, 3);
            pnlYoneticiAnamenuIcerik.Name = "pnlYoneticiAnamenuIcerik";
            pnlYoneticiAnamenuIcerik.Size = new Size(934, 621);
            pnlYoneticiAnamenuIcerik.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(201, 231, 182);
            label1.Location = new Point(-12, 1);
            label1.Name = "label1";
            label1.Size = new Size(236, 621);
            label1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Adsız_tasarım;
            pictureBox1.Location = new Point(28, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.avakadodogruolan;
            pictureBox2.Location = new Point(-10, 571);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(201, 231, 182);
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(45, 107, 62);
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(194, 22);
            label2.TabIndex = 0;
            label2.Text = "Kalori Takip Programı";
            // 
            // FRMYoneticiAnaMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 621);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(btnYemekler);
            Controls.Add(pictureBox1);
            Controls.Add(pnlYoneticiAnamenuIcerik);
            Controls.Add(btnKullaniciOgunleri);
            Controls.Add(btnKullanicilariGoster);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FRMYoneticiAnaMenu";
            Text = "Yönetici Menü";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYemekler;
        private Button btnKullanicilariGoster;
        private Button btnKullaniciOgunleri;
        private Panel pnlYoneticiAnamenuIcerik;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}
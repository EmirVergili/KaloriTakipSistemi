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
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnKullaniciGiris
            // 
            btnKullaniciGiris.BackColor = Color.FromArgb(199, 234, 203);
            btnKullaniciGiris.FlatStyle = FlatStyle.Popup;
            btnKullaniciGiris.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKullaniciGiris.Location = new Point(227, 164);
            btnKullaniciGiris.Margin = new Padding(4);
            btnKullaniciGiris.Name = "btnKullaniciGiris";
            btnKullaniciGiris.Size = new Size(225, 64);
            btnKullaniciGiris.TabIndex = 0;
            btnKullaniciGiris.Text = "Kullanıcı Giriş Ekranı";
            btnKullaniciGiris.UseVisualStyleBackColor = false;
            btnKullaniciGiris.Click += btnKullaniciGiris_Click;
            // 
            // btnYoneticiGiris
            // 
            btnYoneticiGiris.BackColor = Color.FromArgb(199, 234, 203);
            btnYoneticiGiris.FlatStyle = FlatStyle.Popup;
            btnYoneticiGiris.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYoneticiGiris.Location = new Point(227, 245);
            btnYoneticiGiris.Margin = new Padding(4);
            btnYoneticiGiris.Name = "btnYoneticiGiris";
            btnYoneticiGiris.Size = new Size(225, 64);
            btnYoneticiGiris.TabIndex = 1;
            btnYoneticiGiris.Text = "Yönetici Giriş Ekranı";
            btnYoneticiGiris.UseVisualStyleBackColor = false;
            btnYoneticiGiris.Click += btnYoneticiGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(253, 253, 253);
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(152, 60);
            label1.Name = "label1";
            label1.Size = new Size(501, 47);
            label1.TabIndex = 3;
            label1.Text = "KALORİ TAKİP PROGRAMI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(253, 253, 253);
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(471, 107);
            label2.Name = "label2";
            label2.Size = new Size(170, 37);
            label2.TabIndex = 3;
            label2.Text = "Giriş Ekranı";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.herbs_vegetables_white_background;
            pictureBox2.Location = new Point(-134, -22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(956, 461);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // FRMGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(686, 433);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnYoneticiGiris);
            Controls.Add(btnKullaniciGiris);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FRMGirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKullaniciGiris;
        private Button btnYoneticiGiris;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}

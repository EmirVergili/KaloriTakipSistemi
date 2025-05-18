namespace KaloriTakipSistemi.UI
{
    partial class FRMYoneticiKullaniciOgunleri
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
            label1 = new Label();
            label2 = new Label();
            cmbKullanici = new ComboBox();
            dtpTarih = new DateTimePicker();
            dgvYoneticiOgunleri = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvYoneticiOgunleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(173, 116);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 0;
            label1.Text = "Tarih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(173, 194);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı";
            // 
            // cmbKullanici
            // 
            cmbKullanici.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKullanici.FormattingEnabled = true;
            cmbKullanici.Location = new Point(300, 191);
            cmbKullanici.Margin = new Padding(4, 5, 4, 5);
            cmbKullanici.Name = "cmbKullanici";
            cmbKullanici.Size = new Size(376, 31);
            cmbKullanici.TabIndex = 1;
            cmbKullanici.SelectedIndexChanged += cmbKullanici_SelectedIndexChanged;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(300, 109);
            dtpTarih.Margin = new Padding(4, 5, 4, 5);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(376, 32);
            dtpTarih.TabIndex = 2;
            dtpTarih.ValueChanged += dtpTarih_ValueChanged;
            // 
            // dgvYoneticiOgunleri
            // 
            dgvYoneticiOgunleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYoneticiOgunleri.Location = new Point(109, 265);
            dgvYoneticiOgunleri.Margin = new Padding(4, 5, 4, 5);
            dgvYoneticiOgunleri.Name = "dgvYoneticiOgunleri";
            dgvYoneticiOgunleri.RowHeadersWidth = 51;
            dgvYoneticiOgunleri.Size = new Size(700, 246);
            dgvYoneticiOgunleri.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fruit_slices_white;
            pictureBox1.Location = new Point(-102, -309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1312, 985);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FRMYoneticiKullaniciOgunleri
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 623);
            Controls.Add(dgvYoneticiOgunleri);
            Controls.Add(dtpTarih);
            Controls.Add(cmbKullanici);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FRMYoneticiKullaniciOgunleri";
            Text = "FRMYoneticiKullaniciOgunleri";
            Load += FRMYoneticiKullaniciOgunleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYoneticiOgunleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox cmbKullanici;
        private DateTimePicker dtpTarih;
        private DataGridView dgvYoneticiOgunleri;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private PictureBox pictureBox1;
    }
}
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
            ((System.ComponentModel.ISupportInitialize)dgvYoneticiOgunleri).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 0;
            label1.Text = "Tarih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 196);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı";
            // 
            // cmbKullanici
            // 
            cmbKullanici.FormattingEnabled = true;
            cmbKullanici.Location = new Point(195, 193);
            cmbKullanici.Margin = new Padding(4, 5, 4, 5);
            cmbKullanici.Name = "cmbKullanici";
            cmbKullanici.Size = new Size(376, 31);
            cmbKullanici.TabIndex = 1;
            cmbKullanici.SelectedIndexChanged += cmbKullanici_SelectedIndexChanged;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(195, 111);
            dtpTarih.Margin = new Padding(4, 5, 4, 5);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(376, 32);
            dtpTarih.TabIndex = 2;
            dtpTarih.ValueChanged += dtpTarih_ValueChanged;
            // 
            // dgvYoneticiOgunleri
            // 
            dgvYoneticiOgunleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYoneticiOgunleri.Location = new Point(44, 281);
            dgvYoneticiOgunleri.Margin = new Padding(4, 5, 4, 5);
            dgvYoneticiOgunleri.Name = "dgvYoneticiOgunleri";
            dgvYoneticiOgunleri.RowHeadersWidth = 51;
            dgvYoneticiOgunleri.Size = new Size(1003, 246);
            dgvYoneticiOgunleri.TabIndex = 3;
            // 
            // FRMYoneticiKullaniciOgunleri
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 598);
            Controls.Add(dgvYoneticiOgunleri);
            Controls.Add(dtpTarih);
            Controls.Add(cmbKullanici);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FRMYoneticiKullaniciOgunleri";
            Text = "FRMYoneticiKullaniciOgunleri";
            Load += FRMYoneticiKullaniciOgunleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYoneticiOgunleri).EndInit();
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
    }
}
namespace KaloriTakipSistemi.UI
{
    partial class FRMYoneticiYemekler
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
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            dgvYemekler = new DataGridView();
            txtYemekAdi = new TextBox();
            nudKalori = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKalori).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(334, 232);
            btnEkle.Margin = new Padding(4, 4, 4, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(129, 41);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(472, 232);
            btnSil.Margin = new Padding(4, 4, 4, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(129, 41);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(609, 232);
            btnGuncelle.Margin = new Padding(4, 4, 4, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(129, 41);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // dgvYemekler
            // 
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Location = new Point(20, 320);
            dgvYemekler.Margin = new Padding(4, 4, 4, 4);
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.RowHeadersWidth = 51;
            dgvYemekler.Size = new Size(1067, 263);
            dgvYemekler.TabIndex = 1;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(179, 52);
            txtYemekAdi.Margin = new Padding(4, 4, 4, 4);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(208, 34);
            txtYemekAdi.TabIndex = 2;
            txtYemekAdi.TextChanged += textBox1_TextChanged;
            // 
            // nudKalori
            // 
            nudKalori.Location = new Point(179, 98);
            nudKalori.Margin = new Padding(4, 4, 4, 4);
            nudKalori.Name = "nudKalori";
            nudKalori.Size = new Size(206, 34);
            nudKalori.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 4;
            label1.Text = "Kalori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 5;
            label2.Text = "Yemek Adı";
            // 
            // FRMYoneticiYemekler
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudKalori);
            Controls.Add(txtYemekAdi);
            Controls.Add(dgvYemekler);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FRMYoneticiYemekler";
            Text = "FRMYoneticiYemekler";
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKalori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private DataGridView dgvYemekler;
        private TextBox txtYemekAdi;
        private NumericUpDown nudKalori;
        private Label label1;
        private Label label2;
    }
}
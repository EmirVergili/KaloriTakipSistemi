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
            btnYemekEkle = new Button();
            btnYemekSil = new Button();
            btnYemekGuncelle = new Button();
            dgvYemekler = new DataGridView();
            txtYemekAdi = new TextBox();
            nudKalori = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btnOgunEkle = new Button();
            btnOgunSil = new Button();
            btnOgunGuncelle = new Button();
            dgvOgunler = new DataGridView();
            txtOgunAdi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).BeginInit();
            SuspendLayout();
            // 
            // btnYemekEkle
            // 
            btnYemekEkle.Location = new Point(79, 259);
            btnYemekEkle.Margin = new Padding(4, 3, 4, 3);
            btnYemekEkle.Name = "btnYemekEkle";
            btnYemekEkle.Size = new Size(141, 46);
            btnYemekEkle.TabIndex = 0;
            btnYemekEkle.Text = "Ekle";
            btnYemekEkle.UseVisualStyleBackColor = true;
            btnYemekEkle.Click += btnYemekEkle_Click;
            // 
            // btnYemekSil
            // 
            btnYemekSil.Location = new Point(230, 259);
            btnYemekSil.Margin = new Padding(4, 3, 4, 3);
            btnYemekSil.Name = "btnYemekSil";
            btnYemekSil.Size = new Size(141, 46);
            btnYemekSil.TabIndex = 0;
            btnYemekSil.Text = "Sil";
            btnYemekSil.UseVisualStyleBackColor = true;
            btnYemekSil.Click += btnYemekSil_Click;
            // 
            // btnYemekGuncelle
            // 
            btnYemekGuncelle.Location = new Point(379, 259);
            btnYemekGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnYemekGuncelle.Name = "btnYemekGuncelle";
            btnYemekGuncelle.Size = new Size(141, 46);
            btnYemekGuncelle.TabIndex = 0;
            btnYemekGuncelle.Text = "Güncelle";
            btnYemekGuncelle.UseVisualStyleBackColor = true;
            btnYemekGuncelle.Click += btnYemekGuncelle_Click;
            // 
            // dgvYemekler
            // 
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Location = new Point(27, 328);
            dgvYemekler.Margin = new Padding(4, 3, 4, 3);
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.RowHeadersWidth = 51;
            dgvYemekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekler.Size = new Size(520, 216);
            dgvYemekler.TabIndex = 1;
            dgvYemekler.CellClick += dgvYemekler_CellClick;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(230, 135);
            txtYemekAdi.Margin = new Padding(4, 3, 4, 3);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(227, 32);
            txtYemekAdi.TabIndex = 2;
            // 
            // nudKalori
            // 
            nudKalori.Location = new Point(230, 173);
            nudKalori.Margin = new Padding(4, 3, 4, 3);
            nudKalori.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            nudKalori.Name = "nudKalori";
            nudKalori.Size = new Size(225, 32);
            nudKalori.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 175);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 4;
            label1.Text = "Kalori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 138);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 5;
            label2.Text = "Yemek Adı";
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.Location = new Point(604, 259);
            btnOgunEkle.Margin = new Padding(4, 3, 4, 3);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(141, 46);
            btnOgunEkle.TabIndex = 0;
            btnOgunEkle.Text = "Ekle";
            btnOgunEkle.UseVisualStyleBackColor = true;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // btnOgunSil
            // 
            btnOgunSil.Location = new Point(755, 259);
            btnOgunSil.Margin = new Padding(4, 3, 4, 3);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(141, 46);
            btnOgunSil.TabIndex = 0;
            btnOgunSil.Text = "Sil";
            btnOgunSil.UseVisualStyleBackColor = true;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.Location = new Point(904, 259);
            btnOgunGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(141, 46);
            btnOgunGuncelle.TabIndex = 0;
            btnOgunGuncelle.Text = "Güncelle";
            btnOgunGuncelle.UseVisualStyleBackColor = true;
            btnOgunGuncelle.Click += btnOgunGuncelle_Click;
            // 
            // dgvOgunler
            // 
            dgvOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunler.Location = new Point(574, 328);
            dgvOgunler.Margin = new Padding(4, 3, 4, 3);
            dgvOgunler.Name = "dgvOgunler";
            dgvOgunler.RowHeadersWidth = 51;
            dgvOgunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgunler.Size = new Size(493, 216);
            dgvOgunler.TabIndex = 1;
            dgvOgunler.CellClick += dgvOgunler_CellClick;
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(764, 154);
            txtOgunAdi.Margin = new Padding(4, 3, 4, 3);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.Size = new Size(227, 32);
            txtOgunAdi.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(647, 157);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 5;
            label4.Text = "Öğün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 208);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 4;
            label3.Text = "(100 gram için)";
            // 
            // FRMYoneticiYemekler
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 598);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(nudKalori);
            Controls.Add(txtOgunAdi);
            Controls.Add(txtYemekAdi);
            Controls.Add(dgvOgunler);
            Controls.Add(btnOgunGuncelle);
            Controls.Add(dgvYemekler);
            Controls.Add(btnOgunSil);
            Controls.Add(btnYemekGuncelle);
            Controls.Add(btnOgunEkle);
            Controls.Add(btnYemekSil);
            Controls.Add(btnYemekEkle);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FRMYoneticiYemekler";
            Text = "FRMYoneticiYemekler";
            Load += FRMYoneticiYemekler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKalori).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYemekEkle;
        private Button btnYemekSil;
        private Button btnYemekGuncelle;
        private DataGridView dgvYemekler;
        private TextBox txtYemekAdi;
        private NumericUpDown nudKalori;
        private Label label1;
        private Label label2;
        private Button btnOgunEkle;
        private Button btnOgunSil;
        private Button btnOgunGuncelle;
        private DataGridView dgvOgunler;
        private TextBox txtOgunAdi;
        private Label label4;
        private Label label3;
    }
}
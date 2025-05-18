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
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnYemekEkle
            // 
            btnYemekEkle.BackColor = Color.WhiteSmoke;
            btnYemekEkle.FlatStyle = FlatStyle.Popup;
            btnYemekEkle.Location = new Point(35, 209);
            btnYemekEkle.Margin = new Padding(4, 3, 4, 3);
            btnYemekEkle.Name = "btnYemekEkle";
            btnYemekEkle.Size = new Size(141, 46);
            btnYemekEkle.TabIndex = 0;
            btnYemekEkle.Text = "Ekle";
            btnYemekEkle.UseVisualStyleBackColor = false;
            btnYemekEkle.Click += btnYemekEkle_Click;
            // 
            // btnYemekSil
            // 
            btnYemekSil.BackColor = Color.WhiteSmoke;
            btnYemekSil.FlatStyle = FlatStyle.Popup;
            btnYemekSil.Location = new Point(186, 209);
            btnYemekSil.Margin = new Padding(4, 3, 4, 3);
            btnYemekSil.Name = "btnYemekSil";
            btnYemekSil.Size = new Size(141, 46);
            btnYemekSil.TabIndex = 0;
            btnYemekSil.Text = "Sil";
            btnYemekSil.UseVisualStyleBackColor = false;
            btnYemekSil.Click += btnYemekSil_Click;
            // 
            // btnYemekGuncelle
            // 
            btnYemekGuncelle.BackColor = Color.WhiteSmoke;
            btnYemekGuncelle.FlatStyle = FlatStyle.Popup;
            btnYemekGuncelle.Location = new Point(335, 209);
            btnYemekGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnYemekGuncelle.Name = "btnYemekGuncelle";
            btnYemekGuncelle.Size = new Size(141, 46);
            btnYemekGuncelle.TabIndex = 0;
            btnYemekGuncelle.Text = "Güncelle";
            btnYemekGuncelle.UseVisualStyleBackColor = false;
            btnYemekGuncelle.Click += btnYemekGuncelle_Click;
            // 
            // dgvYemekler
            // 
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Location = new Point(495, 62);
            dgvYemekler.Margin = new Padding(4, 3, 4, 3);
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.ReadOnly = true;
            dgvYemekler.RowHeadersWidth = 51;
            dgvYemekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekler.Size = new Size(328, 216);
            dgvYemekler.TabIndex = 1;
            dgvYemekler.CellClick += dgvYemekler_CellClick;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(186, 86);
            txtYemekAdi.Margin = new Padding(4, 3, 4, 3);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(227, 32);
            txtYemekAdi.TabIndex = 2;
            // 
            // nudKalori
            // 
            nudKalori.Location = new Point(186, 123);
            nudKalori.Margin = new Padding(4, 3, 4, 3);
            nudKalori.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            nudKalori.Name = "nudKalori";
            nudKalori.Size = new Size(225, 32);
            nudKalori.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(52, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 4;
            label1.Text = "Kalori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(52, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 5;
            label2.Text = "Yemek Adı";
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.BackColor = Color.WhiteSmoke;
            btnOgunEkle.FlatStyle = FlatStyle.Popup;
            btnOgunEkle.Location = new Point(35, 479);
            btnOgunEkle.Margin = new Padding(4, 3, 4, 3);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(141, 46);
            btnOgunEkle.TabIndex = 0;
            btnOgunEkle.Text = "Ekle";
            btnOgunEkle.UseVisualStyleBackColor = false;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // btnOgunSil
            // 
            btnOgunSil.BackColor = Color.WhiteSmoke;
            btnOgunSil.FlatStyle = FlatStyle.Popup;
            btnOgunSil.Location = new Point(186, 479);
            btnOgunSil.Margin = new Padding(4, 3, 4, 3);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(141, 46);
            btnOgunSil.TabIndex = 0;
            btnOgunSil.Text = "Sil";
            btnOgunSil.UseVisualStyleBackColor = false;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.BackColor = Color.WhiteSmoke;
            btnOgunGuncelle.FlatStyle = FlatStyle.Popup;
            btnOgunGuncelle.Location = new Point(335, 479);
            btnOgunGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(141, 46);
            btnOgunGuncelle.TabIndex = 0;
            btnOgunGuncelle.Text = "Güncelle";
            btnOgunGuncelle.UseVisualStyleBackColor = false;
            btnOgunGuncelle.Click += btnOgunGuncelle_Click;
            // 
            // dgvOgunler
            // 
            dgvOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunler.Location = new Point(534, 327);
            dgvOgunler.Margin = new Padding(4, 3, 4, 3);
            dgvOgunler.Name = "dgvOgunler";
            dgvOgunler.ReadOnly = true;
            dgvOgunler.RowHeadersWidth = 51;
            dgvOgunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgunler.Size = new Size(181, 216);
            dgvOgunler.TabIndex = 1;
            dgvOgunler.CellClick += dgvOgunler_CellClick;
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(186, 381);
            txtOgunAdi.Margin = new Padding(4, 3, 4, 3);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.Size = new Size(227, 32);
            txtOgunAdi.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(69, 384);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 5;
            label4.Text = "Öğün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(186, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 4;
            label3.Text = "(100 gram için)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.top_view_healthy_salad_with_mushrooms;
            pictureBox1.Location = new Point(-40, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1266, 854);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(611, 34);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 7;
            label5.Text = "Yemekler";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(578, 299);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 7;
            label6.Text = "Öğünler";
            // 
            // FRMYoneticiYemekler
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 623);
            Controls.Add(label6);
            Controls.Add(label5);
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
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
    }
}
namespace KaloriTakipSistemi.UI
{
    partial class FRMKullaniciOgunlerim
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
            dgvKullaniciOgunlerim = new DataGridView();
            dtpKullaniciOgunGoruntuleme = new DateTimePicker();
            label1 = new Label();
            lblToplamkalori = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvKullaniciOgunlerim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvKullaniciOgunlerim
            // 
            dgvKullaniciOgunlerim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullaniciOgunlerim.Location = new Point(64, 208);
            dgvKullaniciOgunlerim.Margin = new Padding(4, 3, 4, 3);
            dgvKullaniciOgunlerim.Name = "dgvKullaniciOgunlerim";
            dgvKullaniciOgunlerim.RowHeadersWidth = 51;
            dgvKullaniciOgunlerim.Size = new Size(808, 396);
            dgvKullaniciOgunlerim.TabIndex = 0;
            // 
            // dtpKullaniciOgunGoruntuleme
            // 
            dtpKullaniciOgunGoruntuleme.Location = new Point(72, 75);
            dtpKullaniciOgunGoruntuleme.Margin = new Padding(4, 3, 4, 3);
            dtpKullaniciOgunGoruntuleme.Name = "dtpKullaniciOgunGoruntuleme";
            dtpKullaniciOgunGoruntuleme.Size = new Size(373, 32);
            dtpKullaniciOgunGoruntuleme.TabIndex = 1;
            dtpKullaniciOgunGoruntuleme.ValueChanged += dtpKullaniciOgunGoruntuleme_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(249, 250, 251);
            label1.Location = new Point(72, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(533, 23);
            label1.TabIndex = 2;
            label1.Text = "Yediğiniz öğünleri görüntülemek istediğiniz günü seçiniz";
            // 
            // lblToplamkalori
            // 
            lblToplamkalori.AutoSize = true;
            lblToplamkalori.BackColor = Color.FromArgb(249, 250, 251);
            lblToplamkalori.Location = new Point(72, 137);
            lblToplamkalori.Margin = new Padding(4, 0, 4, 0);
            lblToplamkalori.Name = "lblToplamkalori";
            lblToplamkalori.Size = new Size(142, 23);
            lblToplamkalori.TabIndex = 3;
            lblToplamkalori.Text = "Toplam Kalori";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.red_apples_concept_fresh_healthy_food;
            pictureBox1.Location = new Point(-276, -412);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1336, 1035);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FRMKullaniciOgunlerim
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 623);
            Controls.Add(lblToplamkalori);
            Controls.Add(label1);
            Controls.Add(dtpKullaniciOgunGoruntuleme);
            Controls.Add(dgvKullaniciOgunlerim);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FRMKullaniciOgunlerim";
            Text = "FRMKullaniciOgunlerim";
            ((System.ComponentModel.ISupportInitialize)dgvKullaniciOgunlerim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKullaniciOgunlerim;
        private DateTimePicker dtpKullaniciOgunGoruntuleme;
        private Label label1;
        private Label lblToplamkalori;
        private PictureBox pictureBox1;
    }
}
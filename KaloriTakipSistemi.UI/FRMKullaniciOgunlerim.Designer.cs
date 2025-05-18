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
            ((System.ComponentModel.ISupportInitialize)dgvKullaniciOgunlerim).BeginInit();
            SuspendLayout();
            // 
            // dgvKullaniciOgunlerim
            // 
            dgvKullaniciOgunlerim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullaniciOgunlerim.Location = new Point(72, 208);
            dgvKullaniciOgunlerim.Margin = new Padding(4, 3, 4, 3);
            dgvKullaniciOgunlerim.Name = "dgvKullaniciOgunlerim";
            dgvKullaniciOgunlerim.RowHeadersWidth = 51;
            dgvKullaniciOgunlerim.Size = new Size(793, 396);
            dgvKullaniciOgunlerim.TabIndex = 0;
            // 
            // dtpKullaniciOgunGoruntuleme
            // 
            dtpKullaniciOgunGoruntuleme.Location = new Point(203, 170);
            dtpKullaniciOgunGoruntuleme.Margin = new Padding(4, 3, 4, 3);
            dtpKullaniciOgunGoruntuleme.Name = "dtpKullaniciOgunGoruntuleme";
            dtpKullaniciOgunGoruntuleme.Size = new Size(373, 32);
            dtpKullaniciOgunGoruntuleme.TabIndex = 1;
            dtpKullaniciOgunGoruntuleme.ValueChanged += dtpKullaniciOgunGoruntuleme_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(533, 23);
            label1.TabIndex = 2;
            label1.Text = "Yediğiniz öğünleri görüntülemek istediğiniz günü seçiniz";
            // 
            // lblToplamkalori
            // 
            lblToplamkalori.AutoSize = true;
            lblToplamkalori.Location = new Point(72, 33);
            lblToplamkalori.Margin = new Padding(4, 0, 4, 0);
            lblToplamkalori.Name = "lblToplamkalori";
            lblToplamkalori.Size = new Size(142, 23);
            lblToplamkalori.TabIndex = 3;
            lblToplamkalori.Text = "Toplam Kalori";
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
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FRMKullaniciOgunlerim";
            Text = "FRMKullaniciOgunlerim";
            Load += FRMKullaniciOgunlerim_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKullaniciOgunlerim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKullaniciOgunlerim;
        private DateTimePicker dtpKullaniciOgunGoruntuleme;
        private Label label1;
        private Label lblToplamkalori;
    }
}
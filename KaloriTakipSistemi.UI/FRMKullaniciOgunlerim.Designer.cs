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
            ((System.ComponentModel.ISupportInitialize)dgvKullaniciOgunlerim).BeginInit();
            SuspendLayout();
            // 
            // dgvKullaniciOgunlerim
            // 
            dgvKullaniciOgunlerim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullaniciOgunlerim.Location = new Point(48, 181);
            dgvKullaniciOgunlerim.Name = "dgvKullaniciOgunlerim";
            dgvKullaniciOgunlerim.RowHeadersWidth = 51;
            dgvKullaniciOgunlerim.Size = new Size(867, 344);
            dgvKullaniciOgunlerim.TabIndex = 0;
            // 
            // dtpKullaniciOgunGoruntuleme
            // 
            dtpKullaniciOgunGoruntuleme.Location = new Point(591, 103);
            dtpKullaniciOgunGoruntuleme.Name = "dtpKullaniciOgunGoruntuleme";
            dtpKullaniciOgunGoruntuleme.Size = new Size(250, 27);
            dtpKullaniciOgunGoruntuleme.TabIndex = 1;
            dtpKullaniciOgunGoruntuleme.ValueChanged += dtpKullaniciOgunGoruntuleme_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 108);
            label1.Name = "label1";
            label1.Size = new Size(381, 20);
            label1.TabIndex = 2;
            label1.Text = "Yediğiniz öğünleri görüntülemek istediğiniz günü seçiniz";
            // 
            // FRMKullaniciOgunlerim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 571);
            Controls.Add(label1);
            Controls.Add(dtpKullaniciOgunGoruntuleme);
            Controls.Add(dgvKullaniciOgunlerim);
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
    }
}
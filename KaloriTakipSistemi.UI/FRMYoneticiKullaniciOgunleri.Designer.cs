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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 44);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Tarih";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 97);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 0;
            label2.Text = "Kullanici";
            // 
            // cmbKullanici
            // 
            cmbKullanici.FormattingEnabled = true;
            cmbKullanici.Location = new Point(233, 89);
            cmbKullanici.Name = "cmbKullanici";
            cmbKullanici.Size = new Size(430, 23);
            cmbKullanici.TabIndex = 1;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(233, 36);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(430, 23);
            dtpTarih.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(683, 268);
            dataGridView1.TabIndex = 3;
            // 
            // FRMYoneticiKullaniciOgunleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(dtpTarih);
            Controls.Add(cmbKullanici);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMYoneticiKullaniciOgunleri";
            Text = "FRMYoneticiKullaniciOgunleri";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}
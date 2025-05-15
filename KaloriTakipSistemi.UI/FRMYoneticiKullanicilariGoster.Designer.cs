namespace KaloriTakipSistemi.UI
{
    partial class FRMYoneticiKullanicilariGoster
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
            dgvKullanicilariGoster = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilariGoster).BeginInit();
            SuspendLayout();
            // 
            // dgvKullanicilariGoster
            // 
            dgvKullanicilariGoster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilariGoster.Location = new Point(22, 23);
            dgvKullanicilariGoster.Name = "dgvKullanicilariGoster";
            dgvKullanicilariGoster.Size = new Size(742, 405);
            dgvKullanicilariGoster.TabIndex = 0;
            dgvKullanicilariGoster.CellContentClick += dgvKullanicilariGoster_CellContentClick;
            // 
            // FRMYoneticiKullanicilariGoster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKullanicilariGoster);
            Name = "FRMYoneticiKullanicilariGoster";
            Text = "FRMKullanicilariGoster";
            Load += FRMYoneticiKullanicilariGoster_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilariGoster).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKullanicilariGoster;
    }
}
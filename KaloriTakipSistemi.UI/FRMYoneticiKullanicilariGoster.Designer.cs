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
            dgvKullanicilariGoster.Location = new Point(38, 36);
            dgvKullanicilariGoster.Margin = new Padding(4, 5, 4, 5);
            dgvKullanicilariGoster.Name = "dgvKullanicilariGoster";
            dgvKullanicilariGoster.RowHeadersWidth = 51;
            dgvKullanicilariGoster.Size = new Size(1272, 621);
            dgvKullanicilariGoster.TabIndex = 0;
            dgvKullanicilariGoster.CellContentClick += dgvKullanicilariGoster_CellContentClick;
            // 
            // FRMYoneticiKullanicilariGoster
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 690);
            Controls.Add(dgvKullanicilariGoster);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 5, 4, 5);
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
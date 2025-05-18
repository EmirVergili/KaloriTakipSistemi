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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilariGoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvKullanicilariGoster
            // 
            dgvKullanicilariGoster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilariGoster.Location = new Point(86, 57);
            dgvKullanicilariGoster.Margin = new Padding(4, 5, 4, 5);
            dgvKullanicilariGoster.Name = "dgvKullanicilariGoster";
            dgvKullanicilariGoster.ReadOnly = true;
            dgvKullanicilariGoster.RowHeadersWidth = 51;
            dgvKullanicilariGoster.Size = new Size(742, 504);
            dgvKullanicilariGoster.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vegetables_white_background_with_copy_space1;
            pictureBox1.Location = new Point(-29, -65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1128, 749);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FRMYoneticiKullanicilariGoster
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 623);
            Controls.Add(dgvKullanicilariGoster);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FRMYoneticiKullanicilariGoster";
            Text = "FRMKullanicilariGoster";
            Load += FRMYoneticiKullanicilariGoster_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilariGoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKullanicilariGoster;
        private PictureBox pictureBox1;
    }
}
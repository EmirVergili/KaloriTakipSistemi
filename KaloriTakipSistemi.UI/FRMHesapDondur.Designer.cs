namespace KaloriTakipSistemi.UI
{
    partial class FRMHesapDondur
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
            lblDondurmaSebebi = new Label();
            lblSifre = new Label();
            btnDondur = new Button();
            txtSifre = new TextBox();
            txtDondurmaSebebi = new TextBox();
            SuspendLayout();
            // 
            // lblDondurmaSebebi
            // 
            lblDondurmaSebebi.AutoSize = true;
            lblDondurmaSebebi.Location = new Point(38, 48);
            lblDondurmaSebebi.Margin = new Padding(4, 0, 4, 0);
            lblDondurmaSebebi.Name = "lblDondurmaSebebi";
            lblDondurmaSebebi.Size = new Size(188, 23);
            lblDondurmaSebebi.TabIndex = 0;
            lblDondurmaSebebi.Text = "Dondurma Sebebi";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(38, 124);
            lblSifre.Margin = new Padding(4, 0, 4, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(48, 23);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre";
            // 
            // btnDondur
            // 
            btnDondur.Location = new Point(166, 196);
            btnDondur.Margin = new Padding(4, 3, 4, 3);
            btnDondur.Name = "btnDondur";
            btnDondur.Size = new Size(132, 47);
            btnDondur.TabIndex = 2;
            btnDondur.Text = "Dondur";
            btnDondur.UseVisualStyleBackColor = true;
            btnDondur.Click += btnDondur_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(220, 124);
            txtSifre.Margin = new Padding(4, 3, 4, 3);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(138, 32);
            txtSifre.TabIndex = 3;
            // 
            // txtDondurmaSebebi
            // 
            txtDondurmaSebebi.Location = new Point(220, 45);
            txtDondurmaSebebi.Margin = new Padding(4, 3, 4, 3);
            txtDondurmaSebebi.Name = "txtDondurmaSebebi";
            txtDondurmaSebebi.Size = new Size(138, 32);
            txtDondurmaSebebi.TabIndex = 4;
            // 
            // FRMHesapDondur
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 623);
            Controls.Add(txtDondurmaSebebi);
            Controls.Add(txtSifre);
            Controls.Add(btnDondur);
            Controls.Add(lblSifre);
            Controls.Add(lblDondurmaSebebi);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FRMHesapDondur";
            Text = "FRMHesapDondur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDondurmaSebebi;
        private Label lblSifre;
        private Button btnDondur;
        private TextBox txtSifre;
        private TextBox txtDondurmaSebebi;
    }
}
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
            lblDondurmaSebebi.Location = new Point(35, 59);
            lblDondurmaSebebi.Margin = new Padding(4, 0, 4, 0);
            lblDondurmaSebebi.Name = "lblDondurmaSebebi";
            lblDondurmaSebebi.Size = new Size(171, 28);
            lblDondurmaSebebi.TabIndex = 0;
            lblDondurmaSebebi.Text = "Dondurma Sebebi";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(35, 151);
            lblSifre.Margin = new Padding(4, 0, 4, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(51, 28);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre";
            // 
            // btnDondur
            // 
            btnDondur.Location = new Point(152, 239);
            btnDondur.Margin = new Padding(4);
            btnDondur.Name = "btnDondur";
            btnDondur.Size = new Size(121, 57);
            btnDondur.TabIndex = 2;
            btnDondur.Text = "Dondur";
            btnDondur.UseVisualStyleBackColor = true;
            btnDondur.Click += btnDondur_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(202, 151);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(127, 34);
            txtSifre.TabIndex = 3;
            // 
            // txtDondurmaSebebi
            // 
            txtDondurmaSebebi.Location = new Point(202, 55);
            txtDondurmaSebebi.Margin = new Padding(4);
            txtDondurmaSebebi.Name = "txtDondurmaSebebi";
            txtDondurmaSebebi.Size = new Size(127, 34);
            txtDondurmaSebebi.TabIndex = 4;
            // 
            // FRMHesapDondur
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 537);
            Controls.Add(txtDondurmaSebebi);
            Controls.Add(txtSifre);
            Controls.Add(btnDondur);
            Controls.Add(lblSifre);
            Controls.Add(lblDondurmaSebebi);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
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
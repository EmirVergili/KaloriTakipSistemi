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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblDondurmaSebebi
            // 
            lblDondurmaSebebi.Location = new Point(111, 180);
            lblDondurmaSebebi.Margin = new Padding(4, 0, 4, 0);
            lblDondurmaSebebi.Name = "lblDondurmaSebebi";
            lblDondurmaSebebi.Size = new Size(188, 58);
            lblDondurmaSebebi.TabIndex = 0;
            lblDondurmaSebebi.Text = "Hesabını neden donduruyorsun?";
            // 
            // lblSifre
            // 
            lblSifre.Location = new Point(111, 332);
            lblSifre.Margin = new Padding(4, 0, 4, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(207, 53);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Devam etmek için lütfen şifreni gir";
            // 
            // btnDondur
            // 
            btnDondur.BackColor = Color.IndianRed;
            btnDondur.FlatStyle = FlatStyle.Popup;
            btnDondur.ForeColor = Color.White;
            btnDondur.Location = new Point(338, 472);
            btnDondur.Margin = new Padding(4, 3, 4, 3);
            btnDondur.Name = "btnDondur";
            btnDondur.Size = new Size(314, 41);
            btnDondur.TabIndex = 2;
            btnDondur.Text = "Hesabı Geçici Olarak Dondur";
            btnDondur.UseVisualStyleBackColor = false;
            btnDondur.Click += btnDondur_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(338, 332);
            txtSifre.Margin = new Padding(4, 3, 4, 3);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(195, 32);
            txtSifre.TabIndex = 3;
            // 
            // txtDondurmaSebebi
            // 
            txtDondurmaSebebi.Location = new Point(338, 180);
            txtDondurmaSebebi.Margin = new Padding(4, 3, 4, 3);
            txtDondurmaSebebi.Multiline = true;
            txtDondurmaSebebi.Name = "txtDondurmaSebebi";
            txtDondurmaSebebi.Size = new Size(392, 134);
            txtDondurmaSebebi.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(111, 78);
            label1.Name = "label1";
            label1.Size = new Size(522, 40);
            label1.TabIndex = 5;
            label1.Text = "Hesabını Geçici Olarak Dondur";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.flat_lay_tomatoes_holding_hands;
            pictureBox1.Location = new Point(656, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.flat_lay_vegetables_holding_hands;
            pictureBox2.Location = new Point(-5, 487);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(550, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(338, 374);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(413, 53);
            label2.TabIndex = 1;
            label2.Text = "Seni özleyeceğiz. Tekrar giriş yaparak hesabını aktif edebileceğini unutma.";
            // 
            // FRMHesapDondur
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(932, 623);
            Controls.Add(label1);
            Controls.Add(txtDondurmaSebebi);
            Controls.Add(txtSifre);
            Controls.Add(btnDondur);
            Controls.Add(label2);
            Controls.Add(lblSifre);
            Controls.Add(lblDondurmaSebebi);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FRMHesapDondur";
            Text = "FRMHesapDondur";
            Load += FRMHesapDondur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDondurmaSebebi;
        private Label lblSifre;
        private Button btnDondur;
        private TextBox txtSifre;
        private TextBox txtDondurmaSebebi;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}
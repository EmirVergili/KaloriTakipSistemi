using KaloriTakipSistemi.UI.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriTakipSistemi.UI
{
    public partial class FRMYoneticiGiris : Form
    {
        private readonly MyDbContext _context;
        public FRMYoneticiGiris()
        {
            _context = new MyDbContext();
            InitializeComponent();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || (string.IsNullOrWhiteSpace(txtSifre.Text)))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız !!! ");
            }
            if (
               _context.Yoneticiler.Any(k => k.YoneticiAdi == txtKullaniciAdi.Text && k.Sifre == _context.sha256_hash(txtSifre.Text)))
            {
                MessageBox.Show("Giriş Başarılı");
                FRMYoneticiAnaMenu fRMYoneticiAnaMenu = new FRMYoneticiAnaMenu();
                fRMYoneticiAnaMenu.Show();
                this.Hide();
            }
        }

        private void chbGoster_CheckedChanged(object sender, EventArgs e)
        {

            if (chbGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';

            }
        }
    }
}

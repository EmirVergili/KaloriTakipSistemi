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
using System.Text.RegularExpressions;
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
            //kullanıcı adı ve şifredeki başta ve sonda olan boşlukları sil
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();


            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || (string.IsNullOrWhiteSpace(txtSifre.Text)))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız !!! ");
            }            
            if (
               _context.Yoneticiler.Any(k => k.YoneticiAdi == txtKullaniciAdi.Text && k.Sifre == _context.sha256_hash(txtSifre.Text)))
            {
                MessageBox.Show("Giriş başarılı Hoş Geldiniz", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRMYoneticiAnaMenu fRMYoneticiAnaMenu = new FRMYoneticiAnaMenu();
                fRMYoneticiAnaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

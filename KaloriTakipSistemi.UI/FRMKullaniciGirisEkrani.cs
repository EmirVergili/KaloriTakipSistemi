using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaloriTakipSistemi.UI.Context;
using KaloriTakipSistemi.UI.Models;

namespace KaloriTakipSistemi.UI
{
    public partial class FRMKullaniciGirisEkrani : Form
    {
        private readonly MyDbContext _context;
       

        public static int AktifKullaniciId { get; private set; }
        
        public FRMKullaniciGirisEkrani()
        {
            _context = new MyDbContext();
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.");
                return;
            }
            var kullanici = _context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == _context.sha256_hash(txtSifre.Text));
            

            if (kullanici!=null)
            {
                AktifKullaniciId = kullanici.Id;
                if (kullanici.HesapDurumu != true)
                {
                    kullanici.HesapDurumu = true;
                    _context.SaveChanges();
                    MessageBox.Show("Hesabınız Aktif Edildi");
                }

                
                FRMKullaniciAnaMenu kullaniciAnaMenu = new FRMKullaniciAnaMenu();
                kullaniciAnaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                return;
            }


        }
     

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMKayitOl frmKayitOl = new FRMKayitOl();
            frmKayitOl.Show();
            this.Hide();
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

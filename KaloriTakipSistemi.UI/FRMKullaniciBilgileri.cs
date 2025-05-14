using KaloriTakipSistemi.UI.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriTakipSistemi.UI
{
    public partial class FRMKullaniciBilgileri : Form
    {
        MyDbContext _context = new MyDbContext();
        public FRMKullaniciBilgileri()
        {
            InitializeComponent();
        }


        private void FRMKullaniciBilgileri_Load(object sender, EventArgs e)
        {
            var kullanici = _context.Kullanicilar.FirstOrDefault(k => k.Id == FRMKullaniciGirisEkrani.AktifKullaniciId);
            if (kullanici != null)
            {
                lblKullaniciAdi.Text = kullanici.KullaniciAdi;
                txtAd.Text = kullanici.Ad;
                txtSoyad.Text = kullanici.Soyad;
                txtYas.Text = kullanici.Yas.ToString();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }



        }

        private void chbBilgilerimiGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBilgilerimiGuncelle.Checked)
            {
                txtAd.ReadOnly = false;
                txtSoyad.ReadOnly = false;
                txtYas.ReadOnly = false;
                txtSifre.ReadOnly = false;
            }
            else
            {
                txtAd.ReadOnly = true;
                txtSoyad.ReadOnly = true;
                txtYas.ReadOnly = true;
                txtSifre.ReadOnly = true;
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var kullanici = _context.Kullanicilar.FirstOrDefault(k => k.Id == FRMKullaniciGirisEkrani.AktifKullaniciId);
            if (kullanici != null)
            {
                kullanici.Ad=txtAd.Text;
                kullanici.Soyad = txtSoyad.Text;
                kullanici.Yas = byte.Parse(txtYas.Text);
                kullanici.Sifre = txtSifre.Text;
                _context.SaveChanges();
                MessageBox.Show("Bilgileriniz güncellendi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
        
        }
    }
}

using KaloriTakipSistemi.UI.Context;
using KaloriTakipSistemi.UI.Models;
using Microsoft.EntityFrameworkCore;
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

namespace KaloriTakipSistemi.UI
{
    public partial class FRMKayitOl : Form
    {
        private readonly MyDbContext _context;
        public FRMKayitOl()
        {
            _context = new MyDbContext();
            InitializeComponent();

        }
        private bool KayitValidasyonu()
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtSifreTekrar.Text) ||
                string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtYas.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kullanıcı adı uzunluk kontrolü
            if (txtKullaniciAdi.Text.Length < 3 || txtKullaniciAdi.Text.Length > 20)
            {
                MessageBox.Show("Kullanıcı adı 3-20 karakter arasında olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kullanıcı adı benzersizlik kontrolü
            if (_context.Kullanicilar.Any(k => k.KullaniciAdi == txtKullaniciAdi.Text.Trim()))
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //var olan kullanıcı adı varsa uyarı vermesi...
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            if (_context.Kullanicilar.Any(k => k.KullaniciAdi == kullaniciAdi))
            {
                MessageBox.Show("Bu kullanıcı adı kullanılıyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //kullanıcı adında noktalama işareti kullanılmaması...
            if (kullaniciAdi.Any(char.IsPunctuation))
            {
                MessageBox.Show("Kullanıcı adı noktalama işareti içermemelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Şifre eşleşme kontrolü
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Ad ve soyad uzunluk kontrolü
            if (txtAd.Text.Length < 2 || txtSoyad.Text.Length < 2)
            {
                MessageBox.Show("Ad ve soyad en az 2 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Yaş kontrolü
            if (!byte.TryParse(txtYas.Text, out byte yas) || yas < 13 || yas > 100)
            {
                MessageBox.Show("Yaş 13-100 arasında olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KayitValidasyonu())
                {
                    return;
                }
               
                var YeniKullanici = new Kullanici()
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = _context.sha256_hash(txtSifre.Text),
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Yas = Convert.ToByte(txtYas.Text)

                };
                _context.Add(YeniKullanici);
                _context.SaveChanges();
                MessageBox.Show("Kayıt başarılı! Kullanıcı adı ve şifrenizle giriş yapmanız durumunda hesabınız aktif edilecektir.");
                FRMKullaniciGirisEkrani fRMKullaniciGirisEkrani = new FRMKullaniciGirisEkrani();
                fRMKullaniciGirisEkrani.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Olurken Hata Oluştu: " + ex.Message);


            }
        }

    }
}

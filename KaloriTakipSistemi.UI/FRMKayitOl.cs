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
        private readonly MyDbContext _context; //  Burada Veri tabını baglıyoruz 
        public FRMKayitOl() 
        {
            _context = new MyDbContext();
            InitializeComponent();

        }
        private bool KayitValidasyonu()  // Kayıt Validasyonunu yapıyoruz 
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtSifreTekrar.Text) ||
                string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtYas.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); // burada boş alan kontrolü yapıyoruz
                return false;
            }

            if(txtAd.Text.Any(char.IsPunctuation) || txtSoyad.Text.Any(char.IsPunctuation)) // burada ad ve soyadın noktalama işareti içerip içermediğini kontrol ediyoruz
            {
                MessageBox.Show("Ad ve soyad noktalama işareti içermemelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Burada uyarı mesajımızı veriyoruz 
                return false;
            }
            //sayı kontrolü
            if (txtYas.Text.Any(char.IsLetter)) // burada yaşın harf içerip içermediğini kontrol ediyoruz
            {
                MessageBox.Show("Yaş sadece sayılardan oluşmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtAd.Text.Any(char.IsDigit) || txtSoyad.Text.Any(char.IsDigit)) // burada ad ve soyadın sayı içerip içermediğini kontrol ediyoruz
            {
                MessageBox.Show("Ad ve soyad sayı içermemelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string kullaniciAdi = txtKullaniciAdi.Text.Trim(); // burada kullanıcı adını alıyoruz

            if (kullaniciAdi.Any(char.IsPunctuation)) // burada kullanıcı adının noktalama işareti içerip içermediğini kontrol ediyoruz
            {
                MessageBox.Show("Kullanıcı adı noktalama işareti içermemelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_context.Kullanicilar.Any(k => k.KullaniciAdi == kullaniciAdi))
            {
                MessageBox.Show("Bu kullanıcı adı kullanılıyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //kullanıcı adında noktalama işareti kullanılmaması...

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
            try // burada kayıt ol butonuna tıkladığımızda çalışacak olan kodları yazıyoruz
            {
                if (!KayitValidasyonu())
                {
                    return;
                }
               
                var YeniKullanici = new Kullanici() // burada yeni kullanıcı nesnesi oluşturuyoruz
                {
                    KullaniciAdi = txtKullaniciAdi.Text.Trim(), // burada kullanıcı adını alıyoruz
                    Sifre = _context.sha256_hash(txtSifre.Text.Trim()), // burada şifreyi alıyoruz ve sha256 ile hashliyoruz
                    Ad = txtAd.Text.Trim(), // burada adı alıyoruz
                    Soyad = txtSoyad.Text.Trim(), // burada soyadı alıyoruz
                    Yas = Convert.ToByte(txtYas.Text) // burada yaşı alıyoruz

                };
                _context.Add(YeniKullanici);
                _context.SaveChanges();
                MessageBox.Show("Kayıt başarılı! Kullanıcı adı ve şifrenizle giriş yapmanız durumunda hesabınız aktif edilecektir."); // burada kayıt başarılı mesajı veriyoruz
                FRMKullaniciGirisEkrani fRMKullaniciGirisEkrani = new FRMKullaniciGirisEkrani(); // burada kullanıcı giriş ekranını açıyoruz
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

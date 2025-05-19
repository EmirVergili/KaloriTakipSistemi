using KaloriTakipSistemi.UI.Context;
using KaloriTakipSistemi.UI.Models;
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
    public partial class FRMHesapDondur : Form
        //
    {
        private readonly MyDbContext _context;
        public FRMHesapDondur() // 
        {
            InitializeComponent(); 
            _context = new MyDbContext();
        }
        private void btnDondur_Click(object sender, EventArgs e)  // 
        {
            var kullanici = _context.Kullanicilar.FirstOrDefault(k => k.Id == FRMKullaniciGirisEkrani.AktifKullaniciId && k.Sifre == _context.sha256_hash(txtSifre.Text));// burada veri tabanınında  giris bilgilerini istiyoruz 
            if (string.IsNullOrWhiteSpace(txtDondurmaSebebi.Text))  // burada bos mu deigl mi onun kontorlunu yapıyoruz 
            {
                MessageBox.Show("Lütfen bir dondurma sebebi giriniz."); //girilen bilgiler boş ise uyarı mesajı veriyoruz 
                return;
            }

         
            if (kullanici != null) // burada kullanici bilgilerini kontrol ediyoruz
            {
                var onay = MessageBox.Show("Hesabınızı dondurmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //  kullanıcıya eminmisiniz diye soruyoruz son kontrol amaclı

                if (onay == DialogResult.Yes)
                {
                    kullanici.HesapDurumu = false; // burada kullanıcının hesap durumunu false yapıyoruz
                    kullanici.DondurmaSebebi = txtDondurmaSebebi.Text; // burada kullanıcının dondurma sebebini alıyoruz

                    _context.SaveChanges(); // degisklikleri  kayıt ediyoruz 
                    MessageBox.Show("Hesap başarıyla donduruldu"); // burada kullanıcıya mesaj veriyoruz
                } 
                else
                {
                    MessageBox.Show("Hesap dondurma işlemi iptal edildi."); // burada kullanıcıya iptal edildi mesajı veriyoruz
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı. İşlem gerçekleştirilemedi."); // burada kullanıcı bulunamadı mesajı veriyoruz
            }

        }

    }
}

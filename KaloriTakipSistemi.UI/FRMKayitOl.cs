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


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler Uyuşmuyor !!!!!");
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
                MessageBox.Show("Kayıt Başarılı");
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

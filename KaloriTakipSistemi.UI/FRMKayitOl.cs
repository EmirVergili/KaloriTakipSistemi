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
        public string sha256_hash(string sifre) { using (SHA256 hash = SHA256Managed.Create())
            { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(b => b.ToString("X2"))); } }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            var YeniKullanici = new Kullanici()
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = sha256_hash(txtSifre.Text),
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Yas = Convert.ToByte(txtYas.Text)
               
            };
            _context.Add(YeniKullanici);
            _context.SaveChanges();
            MessageBox.Show("Kayıt Başarılı");

        }
    }
}

﻿using KaloriTakipSistemi.UI.Context;
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
    public partial class FRMKullaniciOgunlerim : Form
    {
        MyDbContext _context = new MyDbContext();
        public FRMKullaniciOgunlerim()
        {
            InitializeComponent();
        }


        private void dtpKullaniciOgunGoruntuleme_ValueChanged(object sender, EventArgs e)
        {
            var ogunler = _context.KullaniciYemekler.Where(k => k.KullaniciId == FRMKullaniciGirisEkrani.AktifKullaniciId && dtpKullaniciOgunGoruntuleme.Value.Date == k.YemekTarihi.Date) // burada kullanici yemekler tablosunu alıyoruz
                .Select(o => new
                {
                    AdSoyad = o.Kullanici.Ad + " " + o.Kullanici.Soyad,
                    Ogun = o.Ogun.Ad,
                    Yemek = o.Yemek.Ad,
                    Kalori = o.Yemek.Kalori,
                    Tarih = o.YemekTarihi,
                    porsiyon = o.Miktar,
                    ToplamKalori = o.Miktar * o.Yemek.Kalori

                }).ToList();
            var toplamkalori = _context.KullaniciYemekler.Where(k => k.KullaniciId == FRMKullaniciGirisEkrani.AktifKullaniciId && dtpKullaniciOgunGoruntuleme.Value.Date == k.YemekTarihi.Date).Sum(o => o.Miktar * o.Yemek.Kalori);
            lblToplamkalori.Text = "Günlük toplam kalori : " + toplamkalori.ToString() + " kcal"; // burada toplam kalori labela yazdırıyoruz

            dgvKullaniciOgunlerim.DataSource = ogunler;

        }

        private void FRMKullaniciOgunlerim_Load(object sender, EventArgs e)
        {
            dtpKullaniciOgunGoruntuleme.MaxDate = DateTime.Now; // burada tarih seçimini max tarihini bugüne ayarlıyoruz
        }
    }
}

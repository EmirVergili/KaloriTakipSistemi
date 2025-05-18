using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaloriTakipSistemi.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace KaloriTakipSistemi.UI
{
    public partial class FRMYoneticiKullaniciOgunleri : Form
    {
        private readonly Context.MyDbContext _context;
        public FRMYoneticiKullaniciOgunleri()
        {
            InitializeComponent();
            _context = new Context.MyDbContext();

        }

        private void FRMYoneticiKullaniciOgunleri_Load(object sender, EventArgs e)
        {
            dtpTarih.MaxDate = DateTime.Now;

            cmbKullanici.SelectedIndexChanged -= cmbKullanici_SelectedIndexChanged;
            cmbKullanici.DataSource = _context.Kullanicilar
               .Select(k => new
               {
                   Id = k.Id,
                   AdSoyad = k.Ad + " " + k.Soyad,

               }).ToList();
            cmbKullanici.DisplayMember = "AdSoyad";
            cmbKullanici.ValueMember = "Id";
            cmbKullanici.SelectedIndex = 0;
            cmbKullanici.SelectedIndexChanged += cmbKullanici_SelectedIndexChanged;
        }

        private void cmbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKullanici.SelectedItem == null)
            {
                MessageBox.Show("Kullanıcı seçiniz.");
                return;
            }

            var kullaniciId = (int)cmbKullanici.SelectedValue;

            var ogunler = _context.KullaniciYemekler
                .Where(k => k.KullaniciId == kullaniciId && k.YemekTarihi.Date == dtpTarih.Value.Date)
                .Select(k => new
                {
                    k.Yemek.Ad,
                    k.Yemek.Kalori,
                    OgunAd = k.Ogun.Ad,
                    Porsiyon = k.Miktar,
                    YTarih = k.YemekTarihi.Date,
                    ToplamKalori = k.Miktar * k.Yemek.Kalori
                })
                .ToList();

            dgvYoneticiOgunleri.DataSource = ogunler;
            dgvYoneticiOgunleri.Columns["Ad"].HeaderText = "Yemek Adı";
            dgvYoneticiOgunleri.Columns["YTarih"].HeaderText = "Yemek Tarihi";
            dgvYoneticiOgunleri.Columns["OgunAd"].HeaderText = "Öğün Adı";
            dgvYoneticiOgunleri.Columns["Kalori"].HeaderText = "Kalori";
            dgvYoneticiOgunleri.Columns["Porsiyon"].HeaderText = "Porsiyon";
            dgvYoneticiOgunleri.Columns["ToplamKalori"].HeaderText = "Toplam Kalori";
            dgvYoneticiOgunleri.Columns["Ad"].Width = 200;
            dgvYoneticiOgunleri.Columns["Kalori"].Width = 100;
            dgvYoneticiOgunleri.Columns["YTarih"].Width = 150;
            dgvYoneticiOgunleri.Columns["OgunAd"].Width = 100;
            dgvYoneticiOgunleri.Columns["Porsiyon"].Width = 100;
            dgvYoneticiOgunleri.Columns["ToplamKalori"].Width = 100;


        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            if (cmbKullanici.SelectedItem == null)
            {
                MessageBox.Show("Kisi Seç.");
                return;
            }
            var kullaniciId = (int)cmbKullanici.SelectedValue;

            var ogunler = _context.KullaniciYemekler
                .Where(k => k.KullaniciId == kullaniciId && k.YemekTarihi.Date == dtpTarih.Value.Date)
                .Select(k => new
                {
                    k.Yemek.Ad,
                    k.Yemek.Kalori,
                    OgunAd = k.Ogun.Ad,
                    Porsiyon = k.Miktar,
                    YTarih = k.YemekTarihi.Date
                })
                .ToList();

            dgvYoneticiOgunleri.DataSource = ogunler;
            dgvYoneticiOgunleri.Columns["Ad"].HeaderText = "Yemek Adı";
            dgvYoneticiOgunleri.Columns["YTarih"].HeaderText = "Yemek Tarihi";
            dgvYoneticiOgunleri.Columns["OgunAd"].HeaderText = "Öğün Adı";
            dgvYoneticiOgunleri.Columns["Kalori"].HeaderText = "Kalori";
            dgvYoneticiOgunleri.Columns["Porsiyon"].HeaderText = "Porsiyon";
            dgvYoneticiOgunleri.Columns["Ad"].Width = 200;
            dgvYoneticiOgunleri.Columns["Kalori"].Width = 100;
            dgvYoneticiOgunleri.Columns["YTarih"].Width = 150;
            dgvYoneticiOgunleri.Columns["OgunAd"].Width = 100;
            dgvYoneticiOgunleri.Columns["Porsiyon"].Width = 100;

        }
    }
}


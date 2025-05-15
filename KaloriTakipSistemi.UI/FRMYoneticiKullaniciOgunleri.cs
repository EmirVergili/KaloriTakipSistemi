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
            cmbKullanici.DataSource = _context.Kullanicilar
               .Select(k => new
               {
                   Id = k.Id,
                   AdSoyad = k.Ad + " " + k.Soyad,

               }).ToList();

            cmbKullanici.DisplayMember = "AdSoyad";
            cmbKullanici.ValueMember = "Id";
        }

        private void cmbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKullanici.SelectedItem == null)
            {
                MessageBox.Show("Kisi Seç.");
                return;
            }

            //cmbden secilen kullanıcıya ve tarihe göre veritabanından yemekleri listele
            if (cmbKullanici.SelectedValue is int kullaniciId)
            {
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
            else
            {
                MessageBox.Show("Geçersiz seçim");
            }
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            if (cmbKullanici.SelectedItem == null)
            {
                MessageBox.Show("Kisi Seç.");
                return;
            }

            //cmbden secilen kullanıcıya ve tarihe göre veritabanından yemekleri listele
                if (cmbKullanici.SelectedValue is int kullaniciId)
            {
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
            else
            {
                MessageBox.Show("geçersiz seçim");
            }
        }
    }
}


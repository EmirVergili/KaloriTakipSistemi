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

                   k.Ad,
                   k.Soyad,

               }).ToList();

        }

        private void cmbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            //cmbden secilen kullanıcıya ve tarihe göre veritabanından yemekleri listele
            var kullanici = cmbKullanici.SelectedItem;
            var kullaniciAdi = kullanici.GetType().GetProperty("Ad").GetValue(kullanici, null).ToString();
            var kullaniciSoyadi = kullanici.GetType().GetProperty("Soyad").GetValue(kullanici, null).ToString();
            var kullaniciId = _context.Kullanicilar
                .Where(k => k.Ad == kullaniciAdi && k.Soyad == kullaniciSoyadi)
                .Select(k => k.Id)
                .FirstOrDefault();
            var ogunler = _context.KullaniciYemekler
                .Where(k => k.KullaniciId == kullaniciId && k.YemekTarihi.Date == dtpTarih.Value.Date)
                .Select(k => new
                {
                    k.Yemek.Ad,
                    k.Yemek.Kalori,
                    k.YemekTarihi
                })
                .ToList();
           dgvYoneticiOgunleri.DataSource = ogunler;
            dgvYoneticiOgunleri.Columns["YemekTarihi"].HeaderText = "Yemek Tarihi";
            dgvYoneticiOgunleri.Columns["Ad"].HeaderText = "Yemek Adı";
            dgvYoneticiOgunleri.Columns["Kalori"].HeaderText = "Kalori";
            dgvYoneticiOgunleri.Columns["Ad"].Width = 200;
            dgvYoneticiOgunleri.Columns["Kalori"].Width = 100;
            dgvYoneticiOgunleri.Columns["YemekTarihi"].Width = 150;






        }

    }


}


    

    


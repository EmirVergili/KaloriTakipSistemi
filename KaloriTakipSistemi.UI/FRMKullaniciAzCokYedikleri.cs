using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriTakipSistemi.UI.Models
{
    public partial class FRMKullaniciAzCokYedikleri : Form
    {
        private readonly Context.MyDbContext _context;
        public FRMKullaniciAzCokYedikleri()
        {
            InitializeComponent();
            _context = new Context.MyDbContext();
        }

        private void FRMKullaniciAzCokYedikleri_Load(object sender, EventArgs e)
        {
           

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpBaslangicTarihi.Value.Date;
            DateTime bitisTarihi = dtpBitisTarihi.Value.Date;

            var filtrelenmisYemekler = _context.KullaniciYemekler
                .Where(y =>y.KullaniciId==FRMKullaniciGirisEkrani.AktifKullaniciId && y.YemekTarihi >= baslangicTarihi && y.YemekTarihi <= bitisTarihi)
                .GroupBy(y => y.Yemek.Ad)
                .Select(g => new
                {
                    YemekAd = g.Key,
                    ToplamMiktar = g.Sum(y => y.Miktar)
                })
                .ToList();

            if (filtrelenmisYemekler.Any())
            {
                var enCokYemek = filtrelenmisYemekler.OrderByDescending(y => y.ToplamMiktar).First();
                var enAzYemek = filtrelenmisYemekler.OrderBy(y => y.ToplamMiktar).First();

                lblEnCokYedigimYemek.Text = $"En Çok Yenen Yemek: {enCokYemek.YemekAd} - Miktar: {enCokYemek.ToplamMiktar}";
                lblEnAzYedigimYemek.Text = $"En Az Yenen Yemek: {enAzYemek.YemekAd} - Miktar: {enAzYemek.ToplamMiktar}";
            }
            else
            {
                lblEnCokYedigimYemek.Text = "Hiç yemek bulunamadı.";
                lblEnAzYedigimYemek.Text = "";
            }
        }
    }
}


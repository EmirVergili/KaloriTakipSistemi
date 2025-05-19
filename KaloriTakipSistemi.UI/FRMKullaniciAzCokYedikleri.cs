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

        private void btnGoster_Click(object sender, EventArgs e) // burada butona tıkladığımızda tarih aralığını alıp veritabanından filtreleme yapıyoruz
        {
            DateTime baslangicTarihi = dtpBaslangicTarihi.Value.Date; // burada başlangıç tarihini alıyoruz
            DateTime bitisTarihi = dtpBitisTarihi.Value.Date; // burada bitiş tarihini alıyoruz

            var filtrelenmisYemekler = _context.KullaniciYemekler // burada kullanici yemekler tablosunu alıyoruz
                .Where(y => y.KullaniciId == FRMKullaniciGirisEkrani.AktifKullaniciId && y.YemekTarihi >= baslangicTarihi && y.YemekTarihi <= bitisTarihi) // burada filtreleme yapıyoruz
                .GroupBy(y => y.Yemek.Ad) // burada yemek adlarına göre grupluyoruz
                .Select(g => new // burada yeni bir nesne oluşturuyoruz
                {
                    YemekAd = g.Key,
                    ToplamMiktar = g.Sum(y => y.Miktar)
                })
                .ToList();

            if (filtrelenmisYemekler.Any()) // burada filtrelenmiş yemeklerin olup olmadığını kontrol ediyoruz
            {
                var enCokYemek = filtrelenmisYemekler.OrderByDescending(y => y.ToplamMiktar).First(); // burada en çok yenen yemeği alıyoruz
                var enAzYemek = filtrelenmisYemekler.OrderBy(y => y.ToplamMiktar).First(); // burada en az yenen yemeği alıyoruz

                lblEnCokYedigimYemek.Text = $"{enCokYemek.YemekAd} - Miktar: {enCokYemek.ToplamMiktar}"; // burada en çok yenen yemeği labela yazdırıyoruz
                lblEnAzYedigimYemek.Text = $"{enAzYemek.YemekAd} - Miktar: {enAzYemek.ToplamMiktar}"; // burada en az yenen yemeği labela yazdırıyoruz
            }
            else
            {
                lblEnCokYedigimYemek.Text = "Hiç yemek bulunamadı."; // burada hiç yemek bulunamadı mesajı veriyoruz
                lblEnAzYedigimYemek.Text = "Hiç yemek bulunamadı."; // burada hiç yemek bulunamadı mesajı veriyoruz
            }
        }

        private void dtpBaslangicTarihi_ValueChanged(object sender, EventArgs e) // burada baslangıc tarihini degistirdigimiz de bitis tarihini minimum olarak degistiriyoruz 
        {
            dtpBitisTarihi.MinDate = dtpBaslangicTarihi.Value;
        }

        private void FRMKullaniciAzCokYedikleri_Load(object sender, EventArgs e)
        {
            dtpBaslangicTarihi.Value = DateTime.Now;
            dtpBitisTarihi.MinDate = DateTime.Now;
        }
    }
}


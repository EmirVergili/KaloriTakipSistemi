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
    {
        private readonly MyDbContext _context;
        public FRMHesapDondur()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }
        private void btnDondur_Click(object sender, EventArgs e)
        {
            var kullanici = _context.Kullanicilar.FirstOrDefault(x => x.Id == 2);

            if(kullanici!=null)
            {
                kullanici.HesapDurumu = false;
                kullanici.DondurmaSebebi = txtDondurmaSebebi.Text;
            };
            _context.SaveChanges();
            MessageBox.Show("Hesap Başarıyla Donduruldu");

            DataListele();
        }
        private void DataListele()
        {
            var kullanicilar = _context.Kullanicilar.Select(k => new
            {
                k.Id,
                k.KullaniciAdi,
                k.Ad,
                k.Soyad,
                k.DondurmaSebebi,
                k.Yas,
                HesapDurumuMetin = k.HesapDurumu ? "AKTİF" : "DONDURULMUŞ"

            }).ToList();
            dgvDondurulanHesaplar.DataSource = kullanicilar;
        }

        private void FRMHesapDondur_Load(object sender, EventArgs e)
        {
            DataListele();
        }
    }
}

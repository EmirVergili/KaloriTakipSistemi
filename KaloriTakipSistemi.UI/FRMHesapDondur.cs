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
            var kullanici = _context.Kullanicilar.FirstOrDefault(k=>k.Id==FRMKullaniciGirisEkrani.AktifKullaniciId);
            if (string.IsNullOrWhiteSpace(txtDondurmaSebebi.Text))
            {
                MessageBox.Show("Lütfen bir dondurma sebebi giriniz.");
                return;
            }


            if (kullanici != null)
            {
                kullanici.HesapDurumu = false;
                kullanici.DondurmaSebebi = txtDondurmaSebebi.Text;

                _context.SaveChanges(); 
                MessageBox.Show("Hesap başarıyla donduruldu");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı. İşlem gerçekleştirilemedi.");
            }
            
        }

    }
}

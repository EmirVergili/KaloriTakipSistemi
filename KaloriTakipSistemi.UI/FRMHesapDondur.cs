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
            var kullanici = _context.Kullanicilar.FirstOrDefault(k => k.Id == FRMKullaniciGirisEkrani.AktifKullaniciId && k.Sifre == _context.sha256_hash(txtSifre.Text));

            if (string.IsNullOrWhiteSpace(txtDondurmaSebebi.Text))
            {
                MessageBox.Show("Lütfen bir dondurma sebebi giriniz.");
                return;
            }

            //kullanıcı hesabı null değilse hesabı dondurmak istiyip istemediğini sor
            if (kullanici != null)
            {
                var onay = MessageBox.Show("Hesabınızı dondurmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    kullanici.HesapDurumu = false;
                    kullanici.DondurmaSebebi = txtDondurmaSebebi.Text;

                    _context.SaveChanges();
                    MessageBox.Show("Hesap başarıyla donduruldu");
                }
                else
                {
                    MessageBox.Show("Hesap dondurma işlemi iptal edildi.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı. İşlem gerçekleştirilemedi.");
            }

        }

        private void FRMHesapDondur_Load(object sender, EventArgs e)
        {
            lblDondurmaSebebi.Location = new Point(111 - lblDondurmaSebebi.Width / 2, 180);
            lblSifre.Location = new Point(111 - lblSifre.Width / 2, 332);
            label1.Location = new Point(338 - label1.Width / 2, 374);
        }
    }
}

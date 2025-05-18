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
    public partial class FRMYoneticiKullanicilariGoster : Form
    {
        private readonly Context.MyDbContext _context;

        public FRMYoneticiKullanicilariGoster()
        {
            InitializeComponent();
            _context = new Context.MyDbContext();
        }

        private void FRMYoneticiKullanicilariGoster_Load(object sender, EventArgs e)
        {
           dgvKullanicilariGoster.DataSource = _context.Kullanicilar
                .Select(k => new
                {
                    k.Id,
                    AdSoyad = k.Ad + " " + k.Soyad,
                    k.KullaniciAdi,
                    k.Sifre,
                    HesapDurumuMetin = k.HesapDurumu ? "AKTİF" : "DONDURULMUŞ",
                    k.Yas,
                                   
                }).ToList();
            dgvKullanicilariGoster.Columns["Id"].Visible = false;
        }
    }
}

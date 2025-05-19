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
           dgvKullanicilariGoster.DataSource = _context.Kullanicilar // burada kullanicilar tablosunu alıyoruz
                .Select(k => new
                {
                    k.Id,
                    AdSoyad = k.Ad + " " + k.Soyad,
                    k.KullaniciAdi,
                    HesapDurumuMetin = k.HesapDurumu ? "AKTİF" : "DONDURULMUŞ", // burada hesap durumunu metin olarak gösteriyoruz
                    k.Yas,
                                   
                }).ToList();
            dgvKullanicilariGoster.Columns["Id"].Visible = false; // burada id kolonunu gizliyoruz
        }
    }
}

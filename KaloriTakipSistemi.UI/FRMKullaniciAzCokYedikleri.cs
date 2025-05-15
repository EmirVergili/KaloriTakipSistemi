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
           // en cok yedigi yemek
           this.DataContext = _context;
            var enCokYedigiYemek = _context.KullaniciYemekler
                .GroupBy(k => k.YemekId)
                .Select(g => new
                {
                    YemekId = g.Key,
                    YemekAdet = g.Count()
                })
                .OrderByDescending(g => g.YemekAdet)
                .FirstOrDefault();
            if (enCokYedigiYemek != null)
            {
                var yemek = _context.Yemekler.Find(enCokYedigiYemek.YemekId);
                lblEnCokYedigimYemek.Text = yemek?.Ad;
            }
            // en az yedigi yemek
            var enAzYedigiYemek = _context.KullaniciYemekler
                .GroupBy(k => k.YemekId)
                .Select(g => new
                {
                    YemekId = g.Key,
                    YemekAdet = g.Count()
                })
                .OrderBy(g => g.YemekAdet)
                .FirstOrDefault();
            if (enAzYedigiYemek != null)
            {
                var yemek = _context.Yemekler.Find(enAzYedigiYemek.YemekId);
                lblEnAzYedigimYemek.Text = yemek?.Ad;
            }


        }
    }
}


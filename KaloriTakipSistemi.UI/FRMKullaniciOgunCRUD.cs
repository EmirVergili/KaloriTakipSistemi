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
    public partial class FRMKullaniciOgunCRUD : Form
    {
        private readonly MyDbContext _context;
        public FRMKullaniciOgunCRUD()
        {
            _context = new MyDbContext();
            InitializeComponent();
            DataGridGoster();
        }

        private void FRMKullaniciOgunCRUD_Load(object sender, EventArgs e)
        {
            cmbOgun.DataSource = _context.Ogunler.ToList();
            cmbOgun.DisplayMember = "Ad";
            cmbOgun.ValueMember = "Id";

            cmbYemek.DataSource = _context.Yemekler.ToList();
            cmbYemek.DisplayMember = "Ad";
            cmbYemek.ValueMember = "Id";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            var kullanici = _context.Kullanicilar.FirstOrDefault(x => x.Id == 1);
            var ogunEkle = new KullaniciYemek()
            {
                YemekTarihi = dtpYemekTarihi.Value,
                OgunId = ((Ogun)cmbOgun.SelectedItem).Id,
                YemekId = ((Yemek)cmbYemek.SelectedItem).Id,
                Miktar = Convert.ToInt32(nudMiktar.Value),
                KullaniciId = kullanici.Id
            };
                        _context.KullaniciYemekler.Add(ogunEkle);
            _context.SaveChanges();
            DataGridGoster();
        }
        private void DataGridGoster()
        {
            dgvOgunler.DataSource = _context.KullaniciYemekler.ToList();
        }
    }
}

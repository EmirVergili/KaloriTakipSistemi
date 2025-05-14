using KaloriTakipSistemi.UI.Context;
using KaloriTakipSistemi.UI.Models;
using Microsoft.EntityFrameworkCore;
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
            Listele();
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


            var ogunEkle = new KullaniciYemek()
            {
                YemekTarihi = dtpYemekTarihi.Value,
                OgunId = ((Ogun)cmbOgun.SelectedItem).Id,
                YemekId = ((Yemek)cmbYemek.SelectedItem).Id,
                Miktar = Convert.ToInt32(nudMiktar.Value),
                KullaniciId = FRMKullaniciGirisEkrani.AktifKullaniciId

            };
            _context.KullaniciYemekler.Add(ogunEkle);
            _context.SaveChanges();
            Listele();
        }

        private void Listele()
        {
            var kullaniciYemek = _context.KullaniciYemekler
                .Where(k => k.KullaniciId == FRMKullaniciGirisEkrani.AktifKullaniciId)
                .Select(a => new
                {
                    a.Id,
                    a.Yemek.Ad,
                    ogunAdi = a.Ogun.Ad,
                    a.YemekTarihi,
                    a.Miktar,
                    kullaniciAdi = a.Kullanici.Ad,
                    a.Yemek.Kalori
                }).ToList();
            dgvOgunler.DataSource = kullaniciYemek;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvOgunler.CurrentRow == null) return;

            int ogunıd = (int)dgvOgunler.CurrentRow.Cells["Id"].Value;

            var ogun = _context.KullaniciYemekler.Find(ogunıd);

            if (ogun != null)
            {
                _context.KullaniciYemekler.Remove(ogun);
                _context.SaveChanges();
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int ogunId = (int)dgvOgunler.CurrentRow.Cells["Id"].Value;
            var ogun = _context.KullaniciYemekler.Find(ogunId);

            if (ogun != null)
            {
                ogun.YemekTarihi = dtpYemekTarihi.Value;
                ogun.OgunId = ((Ogun)cmbOgun.SelectedItem).Id;
                ogun.YemekId = ((Yemek)cmbYemek.SelectedItem).Id;
                ogun.Miktar = Convert.ToInt32(nudMiktar.Value);                               
            }
            _context.SaveChanges();
            Listele();
        }
    }
}

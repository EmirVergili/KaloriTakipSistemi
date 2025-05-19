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

        public FRMKullaniciOgunCRUD() // burada veri tabanını bağlıyoruz
        {
            _context = new MyDbContext();
            InitializeComponent();
            Listele();
        }

        private void FRMKullaniciOgunCRUD_Load(object sender, EventArgs e)
        {
            cmbOgun.DataSource = _context.Ogunler.ToList(); // burada veri tabanından öğünleri alıyoruz
            cmbOgun.DisplayMember = "Ad"; // burada öğün adını gösteriyoruz
            cmbOgun.ValueMember = "Id"; // burada öğün id'sini gösteriyoruz

            cmbYemek.DataSource = _context.Yemekler.ToList(); // burada veri tabanından yemekleri alıyoruz
            cmbYemek.DisplayMember = "Ad"; // burada yemek adını gösteriyoruz
            cmbYemek.ValueMember = "Id"; // burada yemek id'sini gösteriyoruz
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            HataKontrol(); // burada hata kontrolü yapıyoruz

            var ogunEkle = new KullaniciYemek() // burada yeni bir nesne oluşturuyoruz
            {
                YemekTarihi = dtpYemekTarihi.Value, // burada yemek tarihini alıyoruz
                OgunId = ((Ogun)cmbOgun.SelectedItem).Id, // burada öğün id'sini alıyoruz
                YemekId = ((Yemek)cmbYemek.SelectedItem).Id, // burada yemek id'sini alıyoruz
                Miktar = Convert.ToInt32(nudMiktar.Value), // burada miktarı alıyoruz
                KullaniciId = FRMKullaniciGirisEkrani.AktifKullaniciId // burada aktif kullanici id'sini alıyoruz

            };
            _context.KullaniciYemekler.Add(ogunEkle); // burada yeni öğünü ekliyoruz
            _context.SaveChanges(); // burada değişiklikleri kaydediyoruz
            Listele(); // burada listeyi güncelliyoruz
        }

        private void Listele() // listele metodunu cagırıyoruz 
        {
            var kullaniciYemek = _context.KullaniciYemekler // burada kullanici yemekler tablosunu alıyoruz
                .Where(k => k.KullaniciId == FRMKullaniciGirisEkrani.AktifKullaniciId) // burada aktif kullanici id'sine göre filtreliyoruz
                .Select(a => new // burada yeni bir nesne oluşturuyoruz
                {
                    a.Id,
                    a.Yemek.Ad,
                    ogunAdi = a.Ogun.Ad,
                    a.YemekTarihi,
                   porsiyon = a.Miktar,
                    kullaniciAdi = a.Kullanici.Ad,
                    a.Yemek.Kalori
                }).ToList();
            dgvOgunler.DataSource = kullaniciYemek;
            dgvOgunler.Columns[0].Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (dgvOgunler.CurrentRow == null) return; // burada eğer seçili satır yoksa return yapıyoruz

            int ogunıd = (int)dgvOgunler.CurrentRow.Cells["Id"].Value; // burada seçili satırın id'sini alıyoruz

            var ogun = _context.KullaniciYemekler.Find(ogunıd); // burada id'sine göre öğünü buluyoruz

            if (ogun != null)
            {
                _context.KullaniciYemekler.Remove(ogun); // burada öğünü siliyoruz
                _context.SaveChanges(); // degisiklikleri kaydediyoruz 
                Listele(); // burada listeyi güncelliyoruz
            }
        }
        public void HataKontrol() // burada hata kontrolü yapıyoruz
        {
            if (cmbOgun.SelectedItem == null || cmbYemek.SelectedItem == null) // burada öğün ve yemek seçilip seçilmediğini kontrol ediyoruz
            {
                MessageBox.Show("Lütfen öğün ve yemek seçiniz."); // burada hata mesajı veriyoruz
                return;
            }
            if (nudMiktar.Value <= 0) // burada miktarın 0'dan büyük olup olmadığını kontrol ediyoruz
            {
                MessageBox.Show("Lütfen geçerli bir miktar giriniz."); // burada hata mesajı veriyoruz
                return;
            }
         
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            HataKontrol();
            if (dgvOgunler.CurrentRow == null) return;
          
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

        private void dgvOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ogunId = (int)dgvOgunler.CurrentRow.Cells["Id"].Value;
            var ogun = _context.KullaniciYemekler.Find(ogunId);
            cmbOgun.SelectedValue = ogun.OgunId;
            cmbYemek.SelectedValue =  ogun.YemekId;
            dtpYemekTarihi.Value = ogun.YemekTarihi;
            nudMiktar.Value = ogun.Miktar;

        }
    }
}

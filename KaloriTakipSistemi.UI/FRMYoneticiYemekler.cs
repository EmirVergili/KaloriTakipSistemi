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
    public partial class FRMYoneticiYemekler : Form
    {
        private readonly MyDbContext _db;
        Yemek secilenYemek = new();
        Ogun secilenOgun = new();
        public FRMYoneticiYemekler()
        {
            _db = new MyDbContext();
            InitializeComponent();
        }
        private void FRMYoneticiYemekler_Load(object sender, EventArgs e) // burada form yüklendiğinde çalışacak olan kodlar
        {
            YemekDgvListele();
            OgunDgvListele();
        }
        private bool GirdiKontrolYemek() // burada yemek girdi kontrolü yapıyoruz
        {
            if (string.IsNullOrWhiteSpace(txtYemekAdi.Text)) // burada yemek adı boş geçilemez
            {
                MessageBox.Show("Yemek adı boş geçilemez!"); 
                return false;
            }
            if (nudKalori.Value == 0)
            {
                MessageBox.Show("Lütfen geçerli bir kalori giriniz!");
                return false;
            }
            return true;
        }
        private void YemekDgvListele() // burada yemekleri listeleme işlemini yapıyoruz
        {
            dgvYemekler.DataSource = _db.Yemekler.ToList();
            dgvYemekler.Columns["Id"].Visible = false;
        }
        private void TemizleYemek() // burada yemekleri temizleme işlemini yapıyoruz
        {
            txtYemekAdi.Text = string.Empty;
            nudKalori.Text = string.Empty;
            secilenYemek = null;
        }
        private void btnYemekEkle_Click(object sender, EventArgs e) // burada yemek ekleme işlemini yapıyoruz
        {
            if (!GirdiKontrolYemek()) return; // burada girdi kontrolü yapıyoruz
            Yemek yemek = new Yemek { Ad = txtYemekAdi.Text, Kalori = (double)(nudKalori.Value) }; // burada yeni bir yemek nesnesi oluşturuyoruz
            _db.Yemekler.Add(yemek);
            _db.SaveChanges();
            TemizleYemek();
            YemekDgvListele();
            MessageBox.Show("Yemek başarıyla eklendi.");
        }

        private void btnYemekSil_Click(object sender, EventArgs e) // burada yemek silme işlemini yapıyoruz
        {
            if (!GirdiKontrolYemek()) return;
            _db.Yemekler.Remove(secilenYemek);
            _db.SaveChanges();
            TemizleYemek();
            YemekDgvListele();
            MessageBox.Show("Yemek başarıyla silindi.");
        }

        private void btnYemekGuncelle_Click(object sender, EventArgs e) // burada yemek güncelleme işlemini yapıyoruz
        {
            if (!GirdiKontrolYemek()) return;
            secilenYemek.Ad = txtYemekAdi.Text;
            secilenYemek.Kalori = (double)(nudKalori.Value);
            _db.SaveChanges();
            TemizleYemek();
            YemekDgvListele();
            MessageBox.Show("Yemek başarıyla güncellendi.");
        }

        private void dgvYemekler_CellClick(object sender, DataGridViewCellEventArgs e) // burada yemekler datagridview'ine tıkladığımızda çalışacak olan kodlar
        {
            TemizleYemek(); 
            secilenYemek = dgvYemekler.SelectedRows[0].DataBoundItem as Yemek;
            txtYemekAdi.Text = secilenYemek.Ad;
            nudKalori.Value = (decimal)secilenYemek.Kalori;
        }

        private bool GirdiKontrolOgun() // burada öğün girdi kontrolü yapıyoruz
        {
            if(string.IsNullOrWhiteSpace(txtOgunAdi.Text))
            {
                MessageBox.Show("Öğün adı boş geçilemez!");
                return false;
            }
            return true;

        }
        private void OgunDgvListele()
        {
            dgvOgunler.DataSource = _db.Ogunler.ToList();
            dgvOgunler.Columns["Id"].Visible = false;
        }
        private void TemizleOgun()
        {
            txtOgunAdi.Text = string.Empty;
            secilenOgun = null;
        }
        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            if (!GirdiKontrolOgun()) return;
            Ogun ogun = new Ogun { Ad = txtOgunAdi.Text};
            _db.Ogunler.Add(ogun);
            _db.SaveChanges();
            TemizleOgun();
            OgunDgvListele();
            MessageBox.Show("Öğün başarıyla eklendi.");
        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (!GirdiKontrolOgun()) return;
            _db.Ogunler.Remove(secilenOgun);
            _db.SaveChanges();
            TemizleOgun();
            OgunDgvListele();
            MessageBox.Show("Öğün başarıyla silindi.");
        }

        private void btnOgunGuncelle_Click(object sender, EventArgs e)
        {
            if (!GirdiKontrolOgun()) return;
            secilenOgun.Ad = txtOgunAdi.Text;
            _db.SaveChanges();
            TemizleOgun();
            OgunDgvListele();
            MessageBox.Show("Öğün başarıyla güncellendi.");
        }

        private void dgvOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TemizleOgun();
            secilenOgun = dgvOgunler.SelectedRows[0].DataBoundItem as Ogun;
            txtOgunAdi.Text = secilenOgun.Ad;
        }
    }
}

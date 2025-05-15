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
        public FRMYoneticiYemekler()
        {
            _db = new MyDbContext();
            InitializeComponent();
        }
        private void FRMYoneticiYemekler_Load(object sender, EventArgs e)
        {

        }
        public bool GirdiKontrolYemek()
        {
            if (string.IsNullOrWhiteSpace(txtYemekAdi.Text))
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
        public void YemekDgvListele()
        {
            dgvYemekler.DataSource = _db.Yemekler
                .Select(y => new
                {
                    y.Ad,
                    y.Kalori
                }).ToList();
        }
        private void btnYemekEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnYemekSil_Click(object sender, EventArgs e)
        {

        }

        private void btnYemekGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void dgvYemekler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {

        }

        private void btnOgunGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void dgvOgunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

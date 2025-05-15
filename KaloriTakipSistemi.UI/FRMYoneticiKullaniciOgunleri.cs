using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace KaloriTakipSistemi.UI
{
    public partial class FRMYoneticiKullaniciOgunleri : Form
    {
        private readonly Context.MyDbContext _context;
        public FRMYoneticiKullaniciOgunleri()
        {
            InitializeComponent();
            _context = new Context.MyDbContext();
        }

        private void FRMYoneticiKullaniciOgunleri_Load(object sender, EventArgs e)
        {
            cmbKullanici.DataSource = _context.Kullanicilar
               .Select(k => new
               {

                   k.Ad,
                   k.Soyad,

               }).ToList();

        }

        private void cmbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
           

        }
    }
}

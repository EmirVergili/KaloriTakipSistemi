using KaloriTakipSistemi.UI.Context;
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
    }
}

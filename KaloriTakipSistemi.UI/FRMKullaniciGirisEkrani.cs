using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaloriTakipSistemi.UI.Context;

namespace KaloriTakipSistemi.UI
{
    public partial class FRMKullaniciGirisEkrani : Form
        
    {
        private readonly MyDbContext _context;

        public FRMKullaniciGirisEkrani()
        {
            _context = new MyDbContext();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.");
                return;
            }
         
            //else
            //{
            //    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            //}
            if (
                _context.Kullanicilar.Any(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.Sifre == txtSifre.Text))
            {
                MessageBox.Show("Giriş Başarılı");
                FRMKullaniciAnaMenu kullaniciAnaMenu = new FRMKullaniciAnaMenu();
                kullaniciAnaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                return;
            }
            
            
        }
    }
}

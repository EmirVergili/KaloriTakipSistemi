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
    public partial class FRMKullaniciAnaMenu : Form
    {
        public FRMKullaniciAnaMenu()
        {
            InitializeComponent();
        }

        public void FormGetir(Form form)
        {
            pnlKullaniciAnaMenuIcerik.Controls.Clear();
            form.MdiParent = this; //this form(içinde bulunduğumuz form), ana formdur. parametreden aldığımız form, ana formun alt formudur.
            form.FormBorderStyle = FormBorderStyle.None; //hareket etmesini engelledik
            pnlKullaniciAnaMenuIcerik.Controls.Add(form);  //Çağırdığımız formu pnlIcerik adındaki panele ekledik.
            form.Show(); //Çağırdığımız formu göster dedik.
        }


        #region Button Click Eventleri

        private void btnOgunlerim_Click(object sender, EventArgs e)
        {
            FRMKullaniciOgunlerim fRMKullaniciOgunlerim = new();
            FormGetir(fRMKullaniciOgunlerim);

        }

        private void btnEnCokAzYediklerim_Click(object sender, EventArgs e)
        {
            FRMKullaniciAzCokYedikleri fRMKullaniciAzCokYedikleri = new();
            FormGetir(fRMKullaniciAzCokYedikleri);
        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            FRMKullaniciOgunCRUD fRMKullaniciOgunCRUD = new();
            FormGetir(fRMKullaniciOgunCRUD);
        }

        private void btnKisiselBilgiler_Click(object sender, EventArgs e)
        {
            FRMKullaniciBilgileri fRMKullaniciBilgileri = new();
            FormGetir(fRMKullaniciBilgileri);
        }

        private void btnHesapDondur_Click(object sender, EventArgs e)
        {
            FRMHesapDondur fRMHesapDondur = new();
            FormGetir(fRMHesapDondur);
        }

        #endregion

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FRMGirisEkrani fRMGirisEkrani = new();
            fRMGirisEkrani.Show(); //Giriş ekranını gösterdik.
            this.Hide(); //Ana menüyü gizledik.
        }
    }
}

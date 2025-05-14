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
    public partial class FRMYoneticiAnaMenu : Form
    {
        public FRMYoneticiAnaMenu()
        {
            InitializeComponent();
        }

        public void FormGetir(Form form)
        {
            pnlYoneticiAnamenuIcerik.Controls.Clear();
            form.MdiParent = this; //this form(içinde bulunduğumuz form), ana formdur. parametreden aldığımız form, ana formun alt formudur.
            form.FormBorderStyle = FormBorderStyle.None; //hareket etmesini engelledik
            pnlYoneticiAnamenuIcerik.Controls.Add(form);  //Çağırdığımız formu pnlIcerik adındaki panele ekledik.
            form.Show(); //Çağırdığımız formu göster dedik.
        }

        #region Buttonların Click Eventleri
        private void btnYemekler_Click(object sender, EventArgs e)
        {
            FRMYoneticiYemekler fRMYoneticiYemekler = new();
            FormGetir(fRMYoneticiYemekler);
        }

        private void btnKullanicilariGoster_Click(object sender, EventArgs e)
        {
            FRMYoneticiKullanicilariGoster fRMYoneticiKullanicilariGoster = new();
            FormGetir(fRMYoneticiKullanicilariGoster);
        }

        private void btnKullaniciOgunleri_Click(object sender, EventArgs e)
        {
            FRMYoneticiKullaniciOgunleri fRMYoneticiKullaniciOgunleri = new();
            FormGetir(fRMYoneticiKullaniciOgunleri);
        }
        #endregion

    }
}

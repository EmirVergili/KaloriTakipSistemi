namespace KaloriTakipSistemi.UI
{
    public partial class FRMGirisEkrani : Form
    {
        public FRMGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e) 
        {
            FRMKullaniciGirisEkrani kullaniciGirisEkrani = new FRMKullaniciGirisEkrani(); // burada giris butonumuzun icine hangi form ekran�yla ilskili oldugunu bagl�yoruz 
            kullaniciGirisEkrani.Show();
            this.Hide();

        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e) // burada da ayn� sekilde yonetici giris ekran�na yonlendirmek icin  form ekranlar�m�z� birbirine baglad�k
        {
            FRMYoneticiGiris yoneticiGirisEkrani = new FRMYoneticiGiris();
            yoneticiGirisEkrani.Show();
            this.Hide();
        }
    }
}

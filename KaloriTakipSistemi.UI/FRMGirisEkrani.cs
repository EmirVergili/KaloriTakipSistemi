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
            FRMKullaniciGirisEkrani kullaniciGirisEkrani = new FRMKullaniciGirisEkrani(); // burada giris butonumuzun icine hangi form ekranýyla ilskili oldugunu baglýyoruz 
            kullaniciGirisEkrani.Show();
            this.Hide();

        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e) // burada da ayný sekilde yonetici giris ekranýna yonlendirmek icin  form ekranlarýmýzý birbirine bagladýk
        {
            FRMYoneticiGiris yoneticiGirisEkrani = new FRMYoneticiGiris();
            yoneticiGirisEkrani.Show();
            this.Hide();
        }
    }
}

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
            FRMKullaniciGirisEkrani kullaniciGirisEkrani = new FRMKullaniciGirisEkrani();
            kullaniciGirisEkrani.Show();
            this.Hide();

        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            FRMYoneticiGiris yoneticiGirisEkrani = new FRMYoneticiGiris();
            yoneticiGirisEkrani.Show();
            this.Hide();
        }
    }
}

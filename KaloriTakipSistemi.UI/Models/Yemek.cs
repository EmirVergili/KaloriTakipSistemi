using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipSistemi.UI.Models
{
    public class Yemek
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Kalori { get; set; }
        public List<KullaniciYemek> KullaniciYemeks { get; set; }

    }
}

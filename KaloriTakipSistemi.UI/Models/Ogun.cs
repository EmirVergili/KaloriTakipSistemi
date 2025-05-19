using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipSistemi.UI.Models
{
    // burada classlarımızı olsuturuyoruz ve tablolarda istenilenlere göre propertylerimizi ekliyoruz
    public class Ogun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<KullaniciYemek> KullaniciYemek { get; set; }

    }
}

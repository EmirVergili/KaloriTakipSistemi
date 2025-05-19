using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipSistemi.UI.Models
{ // burada classlarımızı olsuturuyoruz ve tablolarda istenilenlere göre propertylerimizi ekliyoruz
    public class Yonetici
    {
        public int Id { get; set; }
        public string YoneticiAdi { get; set; }
        public string Sifre { get; set; }
    }
}

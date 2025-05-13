using KaloriTakipSistemi.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipSistemi.UI.Context
{
    public class MyDbContext:DbContext
    {
        public DbSet<KullaniciYemek> KullaniciYemek { get; set; }
        public DbSet<Ogun> Ogun { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Yemek> Yemek { get; set; }
        public DbSet<Yonetici> yonetici { get; set; }

    }
}

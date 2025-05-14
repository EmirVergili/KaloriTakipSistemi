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
        public DbSet<KullaniciYemek> KullaniciYemekler { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ERHANLAPTOP\\SQLEXPRESS;Database=KaloriTakipProgramDB;Trusted_Connection=true;TrustServerCertificate=true");
        }

    }
}

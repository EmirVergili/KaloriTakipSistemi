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
            optionsBuilder.UseSqlServer("Server=ERHANLAPTOP\\SQLEXPRESS;Database=KaloriTakipProgramDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasIndex(k => k.KullaniciAdi).IsUnique();


            modelBuilder.Entity<Ogun>().HasData(
                new Ogun { Id =1,Ad = "Sabah"},
                new Ogun { Id =2,Ad = "Öğle"},
                new Ogun { Id =3,Ad = "Akşam"},
                new Ogun { Id =4,Ad = "Ara Öğün"}
                );

            modelBuilder.Entity<Yemek>().HasData(
                new Yemek { Id = 1, Ad = "Kahvaltı Tabağı", Kalori = 450 },
                new Yemek { Id = 2, Ad = "Menemen", Kalori = 250 },
                new Yemek { Id = 3, Ad = "Sucuklu Yumurta", Kalori = 300 },
                new Yemek { Id = 4, Ad = "Peynirli Omlet", Kalori = 280 },
                new Yemek { Id = 5, Ad = "Avokadolu Tost", Kalori = 320 },
                new Yemek { Id = 6, Ad = "Mercimek Çorbası", Kalori = 120 },
                new Yemek { Id = 7, Ad = "Ezogelin Çorbası", Kalori = 150 },
                new Yemek { Id = 8, Ad = "Tavuk Sote", Kalori = 400 },
                new Yemek { Id = 9, Ad = "Etli Nohut", Kalori = 450 },
                new Yemek { Id = 10, Ad = "Kuru Fasulye", Kalori = 430 },
                new Yemek { Id = 11, Ad = "Izgara Köfte", Kalori = 350 },
                new Yemek { Id = 12, Ad = "Pilav Üstü Tavuk", Kalori = 500 },
                new Yemek { Id = 13, Ad = "Sebzeli Bulgur Pilavı", Kalori = 300 },
                new Yemek { Id = 14, Ad = "Fırında Somon", Kalori = 370 },
                new Yemek { Id = 15, Ad = "Zeytinyağlı Taze Fasulye", Kalori = 220 },
                new Yemek { Id = 16, Ad = "Zeytinyağlı Enginar", Kalori = 200 },
                new Yemek { Id = 17, Ad = "Fırında Tavuk But", Kalori = 380 },
                new Yemek { Id = 18, Ad = "Fırında Kabak Mücver", Kalori = 250 },
                new Yemek { Id = 19, Ad = "Mantı", Kalori = 550 },
                new Yemek { Id = 20, Ad = "Lazanya", Kalori = 600 },
                new Yemek { Id = 21, Ad = "Spagetti Bolognese", Kalori = 580 },
                new Yemek { Id = 22, Ad = "Tavuklu Sezar Salata", Kalori = 350 },
                new Yemek { Id = 23, Ad = "Ton Balıklı Salata", Kalori = 300 },
                new Yemek { Id = 24, Ad = "Çoban Salata", Kalori = 100 },
                new Yemek { Id = 25, Ad = "Yeşil Mercimek Salatası", Kalori = 250 },
                new Yemek { Id = 26, Ad = "Acılı Ezme", Kalori = 80 },
                new Yemek { Id = 27, Ad = "Humus", Kalori = 180 },
                new Yemek { Id = 28, Ad = "Patates Kızartması", Kalori = 400 },
                new Yemek { Id = 29, Ad = "Fırında Patates", Kalori = 220 },
                new Yemek { Id = 30, Ad = "Karışık Pizza (orta dilim)", Kalori = 280 },
                new Yemek { Id = 31, Ad = "Tavuk Döner Dürüm", Kalori = 520 },
                new Yemek { Id = 32, Ad = "Et Döner Porsiyon", Kalori = 550 },
                new Yemek { Id = 33, Ad = "Burger (Klasik)", Kalori = 600 },
                new Yemek { Id = 34, Ad = "Lahmacun", Kalori = 220 },
                new Yemek { Id = 35, Ad = "Pide (Kıymalı)", Kalori = 500 },
                new Yemek { Id = 36, Ad = "Karnıyarık", Kalori = 380 },
                new Yemek { Id = 37, Ad = "İmam Bayıldı", Kalori = 250 },
                new Yemek { Id = 38, Ad = "Zeytinyağlı Barbunya", Kalori = 230 },
                new Yemek { Id = 39, Ad = "Yoğurtlu Kabak", Kalori = 180 },
                new Yemek { Id = 40, Ad = "Taze Börülce", Kalori = 210 },
                new Yemek { Id = 41, Ad = "Kıymalı Makarna", Kalori = 530 },
                new Yemek { Id = 42, Ad = "Fırın Tavuklu Makarna", Kalori = 480 },
                new Yemek { Id = 43, Ad = "Sebzeli Noodle", Kalori = 350 },
                new Yemek { Id = 44, Ad = "Şehriyeli Tavuk Çorbası", Kalori = 130 },
                new Yemek { Id = 45, Ad = "Domates Çorbası", Kalori = 110 },
                new Yemek { Id = 46, Ad = "Yoğurtlu Karnabahar", Kalori = 190 },
                new Yemek { Id = 47, Ad = "Zeytinyağlı Pırasa", Kalori = 210 },
                new Yemek { Id = 48, Ad = "Çılbır", Kalori = 270 },
                new Yemek { Id = 49, Ad = "Kısır", Kalori = 300 },
                new Yemek { Id = 50, Ad = "Mücver", Kalori = 240 }
            );
        }


    }
}

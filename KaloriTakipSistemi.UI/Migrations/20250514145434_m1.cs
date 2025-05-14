using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KaloriTakipSistemi.UI.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Yas = table.Column<byte>(type: "tinyint", nullable: false),
                    HesapDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yemekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemekler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yoneticiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YoneticiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yoneticiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciYemekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    YemekId = table.Column<int>(type: "int", nullable: false),
                    OgunId = table.Column<int>(type: "int", nullable: false),
                    YemekTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciYemekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciYemekler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciYemekler_Ogunler_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Ogunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciYemekler_Yemekler_YemekId",
                        column: x => x.YemekId,
                        principalTable: "Yemekler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "Id", "Ad" },
                values: new object[,]
                {
                    { 1, "Sabah" },
                    { 2, "Öğle" },
                    { 3, "Akşam" },
                    { 4, "Ara Öğün" }
                });

            migrationBuilder.InsertData(
                table: "Yemekler",
                columns: new[] { "Id", "Ad", "Kalori" },
                values: new object[,]
                {
                    { 1, "Kahvaltı Tabağı", 450.0 },
                    { 2, "Menemen", 250.0 },
                    { 3, "Sucuklu Yumurta", 300.0 },
                    { 4, "Peynirli Omlet", 280.0 },
                    { 5, "Avokadolu Tost", 320.0 },
                    { 6, "Mercimek Çorbası", 120.0 },
                    { 7, "Ezogelin Çorbası", 150.0 },
                    { 8, "Tavuk Sote", 400.0 },
                    { 9, "Etli Nohut", 450.0 },
                    { 10, "Kuru Fasulye", 430.0 },
                    { 11, "Izgara Köfte", 350.0 },
                    { 12, "Pilav Üstü Tavuk", 500.0 },
                    { 13, "Sebzeli Bulgur Pilavı", 300.0 },
                    { 14, "Fırında Somon", 370.0 },
                    { 15, "Zeytinyağlı Taze Fasulye", 220.0 },
                    { 16, "Zeytinyağlı Enginar", 200.0 },
                    { 17, "Fırında Tavuk But", 380.0 },
                    { 18, "Fırında Kabak Mücver", 250.0 },
                    { 19, "Mantı", 550.0 },
                    { 20, "Lazanya", 600.0 },
                    { 21, "Spagetti Bolognese", 580.0 },
                    { 22, "Tavuklu Sezar Salata", 350.0 },
                    { 23, "Ton Balıklı Salata", 300.0 },
                    { 24, "Çoban Salata", 100.0 },
                    { 25, "Yeşil Mercimek Salatası", 250.0 },
                    { 26, "Acılı Ezme", 80.0 },
                    { 27, "Humus", 180.0 },
                    { 28, "Patates Kızartması", 400.0 },
                    { 29, "Fırında Patates", 220.0 },
                    { 30, "Karışık Pizza (orta dilim)", 280.0 },
                    { 31, "Tavuk Döner Dürüm", 520.0 },
                    { 32, "Et Döner Porsiyon", 550.0 },
                    { 33, "Burger (Klasik)", 600.0 },
                    { 34, "Lahmacun", 220.0 },
                    { 35, "Pide (Kıymalı)", 500.0 },
                    { 36, "Karnıyarık", 380.0 },
                    { 37, "İmam Bayıldı", 250.0 },
                    { 38, "Zeytinyağlı Barbunya", 230.0 },
                    { 39, "Yoğurtlu Kabak", 180.0 },
                    { 40, "Taze Börülce", 210.0 },
                    { 41, "Kıymalı Makarna", 530.0 },
                    { 42, "Fırın Tavuklu Makarna", 480.0 },
                    { 43, "Sebzeli Noodle", 350.0 },
                    { 44, "Şehriyeli Tavuk Çorbası", 130.0 },
                    { 45, "Domates Çorbası", 110.0 },
                    { 46, "Yoğurtlu Karnabahar", 190.0 },
                    { 47, "Zeytinyağlı Pırasa", 210.0 },
                    { 48, "Çılbır", 270.0 },
                    { 49, "Kısır", 300.0 },
                    { 50, "Mücver", 240.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_KullaniciAdi",
                table: "Kullanicilar",
                column: "KullaniciAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYemekler_KullaniciId",
                table: "KullaniciYemekler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYemekler_OgunId",
                table: "KullaniciYemekler",
                column: "OgunId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciYemekler_YemekId",
                table: "KullaniciYemekler",
                column: "YemekId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciYemekler");

            migrationBuilder.DropTable(
                name: "Yoneticiler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Yemekler");
        }
    }
}

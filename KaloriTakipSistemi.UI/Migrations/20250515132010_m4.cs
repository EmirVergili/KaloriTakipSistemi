using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipSistemi.UI.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Yoneticiler",
                columns: new[] { "Id", "Sifre", "YoneticiAdi" },
                values: new object[] { 1, "4CF6829AA93728E8F3C97DF913FB1BFA95FE5810E2933A05943F8312A98D9CF2", "sa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Yoneticiler",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

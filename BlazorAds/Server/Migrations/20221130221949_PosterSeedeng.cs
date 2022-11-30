using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorAds.Server.Migrations
{
    /// <inheritdoc />
    public partial class PosterSeedeng : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posters",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы", "https://hyperpc.ru/images/support/articles/kak-sobrat-pk-dlya-igr/hpc-sborka-gaming-pc-banner_webp.jpg", 9.99m, "Мощный комп" },
                    { 2, "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы", "https://parentbook.ru/wordpress/wp-content/uploads/2017/04/IMG_5428.jpg", 9.99m, "Слабый комп" },
                    { 3, "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы", "https://overclockers.ru/st/legacy/blog/281867/140025_O.png", 9.99m, "Средний комп" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorAds.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedMorePosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Продам свой личный пк в полном комплекте! В состоянии нового, собирал около месяца назад, все коробки и чеки имеются, все на гарантии кроме монитора и видеокарты ( т.к и то, и другое заказывал с америки, видеокарта в превосходном состоянии, на пломбе, без шумов, с пассивным охлаждением работающим, вертушки крутятся максимально тихо и быстро, по монитору особо сказать нечего, без всяких засветов, битых пикселей и прочего, четкая картинка 1920х1080 ) От себя на видеокарту и монитор дам гарантию 60 дней! Любые проверки от вас по факту только порадуют, компьютер тянет абсолютно все игры на высоких-максимальных, при покупке сразу переустановим виндовс (потому что сейчас мои данные на компьютере), сделаем драйвера и все в этом духе. Живу в Академическом, адрес в обьявлении правильный. В комплект входит - монитор, колонки, игровые наушники с микрофоном, вебкамера 720р, клавиатура, мышь, коврик для мыши игровой, системный блок, и естественно все кабели.", "https://52.img.avito.st/image/1/1.bRk9Yba6wfALyAP1a1QBWPzCx_SJQskyjMLF-IHKww.4zFAWqfk8mp-af46F8N0cqqoHulRiQLGdQeKzoYjdPg", 44999m, "Игровой пк Полный Комплект" });

            migrationBuilder.UpdateData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Нa вcе HОУTБУKИ пpедocтавляeтcя ГАРAHTИЯ! Пpоводим пoлнoценноe теxническоe обслуживание и предпродажное тестирование каждого ноутбука", "https://87.img.avito.st/image/1/1.JnzoMba6ipXemEiQqDlVMSmSjJFcEoJXWZKOnVSaiA.zimulSF4iWMwSOQgCrboVNhm4SeohyWaO-GMR03e4Jw", 9990m, "Офисный пк i5-2320/4GB/1TB/Intel HD" });

            migrationBuilder.UpdateData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Не вскрывалась, не перегревалась, не разгонялась, в майнинге не участвовала. Как новая, коробка чек имеется, гарантия ещё 10 месяцев.", "https://42.img.avito.st/image/1/1.QyAbGra678ktsy3MEXdKUtq56c2vOecLqrnrwaex7Q.yRiKb99iuPc_ui9LJoBva1rWA08vZXN222upEi1XJfI", 14000m, "Видеокарта asus GTX 1650 Super" });

            migrationBuilder.InsertData(
                table: "Posters",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "Процессор в рабочем состоянии", "https://46.img.avito.st/image/1/1.__R8Ara6Ux1Kq5EYDkHn2LyhVRnIIVvfzaFXFcCpUQ.-qPwDpwWaj3_Lt9MFnhfDjAA2tgZHH3RiRDpyeG510M", 3000m, "Процессор ryzen 3 1200 OEM" },
                    { 5, 3, "Монитор в отличном состоянии. Адаптер и hdmi в комплекте.", "https://00.img.avito.st/image/1/1.NbBMJ7a6mVl6jltcKg8JnIyEn134BJGb_YSdUfCMmw.E7MPTOUDNa3k2ucIsPKyRR2HJCCbMuZQb1M72vi8L6I", 7000m, "Монитор samsung s24e390hl" },
                    { 6, 3, "Как новая. Вообще не пользовался", "https://65.img.avito.st/image/1/1.9OrODra6WAP4p5oGqlnJrA-tXgd6LVDBf61cC3KlWg.thbpmBqxTM4_5a2jxntwKaquBUvyyi-gC1T2U9yzHJQ", 150m, "Компьютерная мышка" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы", "https://hyperpc.ru/images/support/articles/kak-sobrat-pk-dlya-igr/hpc-sborka-gaming-pc-banner_webp.jpg", 9.99m, "Мощный комп" });

            migrationBuilder.UpdateData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы", "https://parentbook.ru/wordpress/wp-content/uploads/2017/04/IMG_5428.jpg", 9.99m, "Слабый комп" });

            migrationBuilder.UpdateData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы", "https://overclockers.ru/st/legacy/blog/281867/140025_O.png", 9.99m, "Средний комп" });
        }
    }
}

namespace BlazorAds.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)   
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Готовые сборки",
                    Url = "prefabricated-computer-assemblies",

                },
                 new Category
                 {
                     Id = 2,
                     Name = "Компоненты по отдельности",
                     Url = "components-separately",

                 },
                  new Category
                  {
                      Id = 3,
                      Name = "Переферия",
                      Url = "peripherals",

                  }
                  ); 
            modelBuilder.Entity<Poster>().HasData(

            new Poster
            {
                Id = 1,
                Title = "Игровой пк Полный Комплект",
                Description = "Продам свой личный пк в полном комплекте! В состоянии нового, собирал около месяца назад, все коробки и чеки имеются, все на гарантии кроме монитора и видеокарты ( т.к и то, и другое заказывал с америки, видеокарта в превосходном состоянии, на пломбе, без шумов, с пассивным охлаждением работающим, вертушки крутятся максимально тихо и быстро, по монитору особо сказать нечего, без всяких засветов, битых пикселей и прочего, четкая картинка 1920х1080 ) От себя на видеокарту и монитор дам гарантию 60 дней! Любые проверки от вас по факту только порадуют, компьютер тянет абсолютно все игры на высоких-максимальных, при покупке сразу переустановим виндовс (потому что сейчас мои данные на компьютере), сделаем драйвера и все в этом духе. Живу в Академическом, адрес в обьявлении правильный. В комплект входит - монитор, колонки, игровые наушники с микрофоном, вебкамера 720р, клавиатура, мышь, коврик для мыши игровой, системный блок, и естественно все кабели.",
                ImageUrl = "https://52.img.avito.st/image/1/1.bRk9Yba6wfALyAP1a1QBWPzCx_SJQskyjMLF-IHKww.4zFAWqfk8mp-af46F8N0cqqoHulRiQLGdQeKzoYjdPg",
                Price = 44999,
                CategoryId = 1
            },

            new Poster
            {
                Id = 2,
                Title = "Офисный пк i5-2320/4GB/1TB/Intel HD",
                Description = "Нa вcе HОУTБУKИ пpедocтавляeтcя ГАРAHTИЯ! Пpоводим пoлнoценноe теxническоe обслуживание и предпродажное тестирование каждого ноутбука",
                ImageUrl = "https://87.img.avito.st/image/1/1.JnzoMba6ipXemEiQqDlVMSmSjJFcEoJXWZKOnVSaiA.zimulSF4iWMwSOQgCrboVNhm4SeohyWaO-GMR03e4Jw",
                Price = 9990,
                CategoryId = 1
            },
            new Poster
            {
                Id = 3,
                Title = "Видеокарта asus GTX 1650 Super",
                Description = "Не вскрывалась, не перегревалась, не разгонялась, в майнинге не участвовала. Как новая, коробка чек имеется, гарантия ещё 10 месяцев.",
                ImageUrl = "https://42.img.avito.st/image/1/1.QyAbGra678ktsy3MEXdKUtq56c2vOecLqrnrwaex7Q.yRiKb99iuPc_ui9LJoBva1rWA08vZXN222upEi1XJfI",
                Price = 14000,
                CategoryId = 2
            },
            new Poster
            {
                Id = 4,
                Title = "Процессор ryzen 3 1200 OEM",
                Description = "Процессор в рабочем состоянии",
                ImageUrl = "https://46.img.avito.st/image/1/1.__R8Ara6Ux1Kq5EYDkHn2LyhVRnIIVvfzaFXFcCpUQ.-qPwDpwWaj3_Lt9MFnhfDjAA2tgZHH3RiRDpyeG510M",
                Price = 3000,
                CategoryId = 2

            },
            new Poster
            {
                Id = 5,
                Title = "Монитор samsung s24e390hl",
                Description = "Монитор в отличном состоянии. Адаптер и hdmi в комплекте.",
                ImageUrl = "https://00.img.avito.st/image/1/1.NbBMJ7a6mVl6jltcKg8JnIyEn134BJGb_YSdUfCMmw.E7MPTOUDNa3k2ucIsPKyRR2HJCCbMuZQb1M72vi8L6I",
                Price = 7000,
                CategoryId = 3
            },
            new Poster
            {
                Id = 6,
                Title = "Компьютерная мышка",
                Description = "Как новая. Вообще не пользовался",
                ImageUrl = "https://65.img.avito.st/image/1/1.9OrODra6WAP4p5oGqlnJrA-tXgd6LVDBf61cC3KlWg.thbpmBqxTM4_5a2jxntwKaquBUvyyi-gC1T2U9yzHJQ",
                Price = 150,
                CategoryId = 3
            }         
               );
        }

        public DbSet<Poster> Posters { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

namespace BlazorAds.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)   
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Poster>().HasData(

            new Poster
            {
                Id = 1,
                Title = "Мощный комп",
                Description = "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы",
                ImageUrl = "https://hyperpc.ru/images/support/articles/kak-sobrat-pk-dlya-igr/hpc-sborka-gaming-pc-banner_webp.jpg",
                Price = 9.99m
            },

            new Poster
            {
                Id = 2,
                Title = "Слабый комп",
                Description = "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы",
                ImageUrl = "https://parentbook.ru/wordpress/wp-content/uploads/2017/04/IMG_5428.jpg",
                Price = 9.99m
            },
            new Poster
            {
                Id = 3,
                Title = "Средний комп",
                Description = "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы",
                ImageUrl = "https://overclockers.ru/st/legacy/blog/281867/140025_O.png",
                Price = 9.99m
            }
                );
        }

        public DbSet<Poster> Posters { get; set; }
    }
}

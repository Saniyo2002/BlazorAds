﻿// <auto-generated />
using BlazorAds.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorAds.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221201010702_Categories")]
    partial class Categories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorAds.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Готовые сборки",
                            Url = "prefabricated-computer-assemblies"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Компоненты по отдельности",
                            Url = "components-separately"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Переферия",
                            Url = "peripherals"
                        });
                });

            modelBuilder.Entity("BlazorAds.Shared.Poster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы",
                            ImageUrl = "https://hyperpc.ru/images/support/articles/kak-sobrat-pk-dlya-igr/hpc-sborka-gaming-pc-banner_webp.jpg",
                            Price = 9.99m,
                            Title = "Мощный комп"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы",
                            ImageUrl = "https://parentbook.ru/wordpress/wp-content/uploads/2017/04/IMG_5428.jpg",
                            Price = 9.99m,
                            Title = "Слабый комп"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Фвырлофыврлфыоврлфыр фыврлофырв лыорв лорфлоывр лфоырв лофыр влфоырвфлы врлофы",
                            ImageUrl = "https://overclockers.ru/st/legacy/blog/281867/140025_O.png",
                            Price = 9.99m,
                            Title = "Средний комп"
                        });
                });

            modelBuilder.Entity("BlazorAds.Shared.Poster", b =>
                {
                    b.HasOne("BlazorAds.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

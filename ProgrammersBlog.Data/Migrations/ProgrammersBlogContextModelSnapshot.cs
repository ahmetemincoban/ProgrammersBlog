﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;

namespace ProgrammersBlog.Data.Migrations
{
    [DbContext(typeof(ProgrammersBlogContext))]
    partial class ProgrammersBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec bibendum nibh, et hendrerit lorem. Quisque tempus nisl nec ex rhoncus, a tincidunt neque placerat. Ut ut enim ac odio vehicula aliquam nec eget lorem. Nulla ultricies turpis maximus massa faucibus rhoncus ac quis risus. Pellentesque dignissim libero vel odio consectetur, quis imperdiet nisl rutrum. Curabitur sed orci quam. Etiam quis tincidunt est, sed ultricies tortor. Fusce vitae ex pellentesque diam egestas volutpat. Nunc malesuada nulla et erat dapibus placerat. Nullam maximus ante in nibh tincidunt eleifend. Sed facilisis neque eu condimentum luctus.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(5573),
                            Date = new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(4452),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(6121),
                            Note = "C# 9.0 Yenilikleri",
                            SeoAuthor = "AhmetEminST",
                            SeoDescription = "C# 9.0 Yenilikleri",
                            SeoTags = "C#, C# 9, .net5",
                            Thumbnail = "default.jpg",
                            Title = "C# 9.0 Yenilikleri",
                            UserId = 1,
                            ViewCount = 95842
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec bibendum nibh, et hendrerit lorem. Quisque tempus nisl nec ex rhoncus, a tincidunt neque placerat. Ut ut enim ac odio vehicula aliquam nec eget lorem. Nulla ultricies turpis maximus massa faucibus rhoncus ac quis risus. Pellentesque dignissim libero vel odio consectetur, quis imperdiet nisl rutrum. Curabitur sed orci quam. Etiam quis tincidunt est, sed ultricies tortor. Fusce vitae ex pellentesque diam egestas volutpat. Nunc malesuada nulla et erat dapibus placerat. Nullam maximus ante in nibh tincidunt eleifend. Sed facilisis neque eu condimentum luctus.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7353),
                            Date = new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7351),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7355),
                            Note = "JAVA Spring Yenilikleri",
                            SeoAuthor = "AhmetEminST",
                            SeoDescription = "JAVA Spring Yenilikleri",
                            SeoTags = "JAVA, JAVA SPRING, JAVA ILE MOBIL UYGULAMA",
                            Thumbnail = "default.jpg",
                            Title = "JAVA Spring Yenilikleri",
                            UserId = 1,
                            ViewCount = 157456
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec bibendum nibh, et hendrerit lorem. Quisque tempus nisl nec ex rhoncus, a tincidunt neque placerat. Ut ut enim ac odio vehicula aliquam nec eget lorem. Nulla ultricies turpis maximus massa faucibus rhoncus ac quis risus. Pellentesque dignissim libero vel odio consectetur, quis imperdiet nisl rutrum. Curabitur sed orci quam. Etiam quis tincidunt est, sed ultricies tortor. Fusce vitae ex pellentesque diam egestas volutpat. Nunc malesuada nulla et erat dapibus placerat. Nullam maximus ante in nibh tincidunt eleifend. Sed facilisis neque eu condimentum luctus.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7361),
                            Date = new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7360),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7363),
                            Note = "Python ile Instagram Botu Yazma",
                            SeoAuthor = "AhmetEminST",
                            SeoDescription = "Python ile Instagram Botu Yazma",
                            SeoTags = "Python, instagram, bot",
                            Thumbnail = "default.jpg",
                            Title = "Python ile Instagram Botu Yazma",
                            UserId = 1,
                            ViewCount = 1224875
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8441),
                            Description = "C# Programlama dili ile ilgili en güncel bilgiler.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8456),
                            Name = "C#",
                            Note = "C# Kategorisi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8471),
                            Description = "Java Programlama dili ile ilgili en güncel bilgiler.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8472),
                            Name = "JAVA",
                            Note = "JAVA Kategorisi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8476),
                            Description = "Python Programlama dili ile ilgili en güncel bilgiler.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8478),
                            Name = "Python",
                            Note = "Python Kategorisi"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8638),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8651),
                            Note = "C# Makale Yorumu",
                            Text = "Çok çokomel bir makale :)"
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8664),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8665),
                            Note = "JAVA Makale Yorumu",
                            Text = "Çok Çükülop bir makale :)"
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8669),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8671),
                            Note = "Python Makale Yorumu",
                            Text = "Çok Çükübik bir makale :)"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 904, DateTimeKind.Local).AddTicks(7857),
                            Description = "Bu en yetkili kullanıcı yetkisidir. Her türlü izni bulunur",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 904, DateTimeKind.Local).AddTicks(7872),
                            Name = "Admin",
                            Note = "Admin Rolüdür"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 10, 31, 6, 23, 3, 917, DateTimeKind.Local).AddTicks(6274),
                            Description = "İlk admin kullanıcı",
                            Email = "mail@ahmeteminst.com",
                            FirstName = "Ahmet Emin",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "ST",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2021, 10, 31, 6, 23, 3, 917, DateTimeKind.Local).AddTicks(6289),
                            Note = "Admin Kullanıcısı",
                            PasswordHash = new byte[] { 54, 101, 51, 51, 54, 98, 97, 54, 101, 57, 49, 102, 98, 55, 102, 100, 99, 101, 50, 57, 98, 53, 52, 52, 53, 48, 55, 98, 54, 56, 56, 53 },
                            Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU",
                            RoleId = 1,
                            Username = "ahmeteminst"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProgrammersBlog.Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}

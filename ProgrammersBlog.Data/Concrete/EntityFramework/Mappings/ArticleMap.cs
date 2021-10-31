using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap:IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a=>a.Title).IsRequired(true);
            builder.Property(a =>a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a=>a.Category).WithMany(c=>c.Articles).HasForeignKey(a=>a.CategoryId);
            builder.HasOne<User>(a=>a.User).WithMany(u=>u.Articles).HasForeignKey(a=>a.UserId);
            builder.ToTable("Articles");
            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "C# 9.0 Yenilikleri",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec bibendum nibh, et hendrerit lorem. Quisque tempus nisl nec ex rhoncus, a tincidunt neque placerat. Ut ut enim ac odio vehicula aliquam nec eget lorem. Nulla ultricies turpis maximus massa faucibus rhoncus ac quis risus. Pellentesque dignissim libero vel odio consectetur, quis imperdiet nisl rutrum. Curabitur sed orci quam. Etiam quis tincidunt est, sed ultricies tortor. Fusce vitae ex pellentesque diam egestas volutpat. Nunc malesuada nulla et erat dapibus placerat. Nullam maximus ante in nibh tincidunt eleifend. Sed facilisis neque eu condimentum luctus.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "C# 9.0 Yenilikleri",
                    SeoTags = "C#, C# 9, .net5",
                    SeoAuthor = "AhmetEminST",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 Yenilikleri",
                    UserId = 1,
                    ViewCount = 95842,
                    CommentCount = 1
                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "JAVA Spring Yenilikleri",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec bibendum nibh, et hendrerit lorem. Quisque tempus nisl nec ex rhoncus, a tincidunt neque placerat. Ut ut enim ac odio vehicula aliquam nec eget lorem. Nulla ultricies turpis maximus massa faucibus rhoncus ac quis risus. Pellentesque dignissim libero vel odio consectetur, quis imperdiet nisl rutrum. Curabitur sed orci quam. Etiam quis tincidunt est, sed ultricies tortor. Fusce vitae ex pellentesque diam egestas volutpat. Nunc malesuada nulla et erat dapibus placerat. Nullam maximus ante in nibh tincidunt eleifend. Sed facilisis neque eu condimentum luctus.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "JAVA Spring Yenilikleri",
                    SeoTags = "JAVA, JAVA SPRING, JAVA ILE MOBIL UYGULAMA",
                    SeoAuthor = "AhmetEminST",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "JAVA Spring Yenilikleri",
                    UserId = 1,
                    ViewCount = 157456,
                    CommentCount = 1
                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Python ile Instagram Botu Yazma",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec bibendum nibh, et hendrerit lorem. Quisque tempus nisl nec ex rhoncus, a tincidunt neque placerat. Ut ut enim ac odio vehicula aliquam nec eget lorem. Nulla ultricies turpis maximus massa faucibus rhoncus ac quis risus. Pellentesque dignissim libero vel odio consectetur, quis imperdiet nisl rutrum. Curabitur sed orci quam. Etiam quis tincidunt est, sed ultricies tortor. Fusce vitae ex pellentesque diam egestas volutpat. Nunc malesuada nulla et erat dapibus placerat. Nullam maximus ante in nibh tincidunt eleifend. Sed facilisis neque eu condimentum luctus.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "Python ile Instagram Botu Yazma",
                    SeoTags = "Python, instagram, bot",
                    SeoAuthor = "AhmetEminST",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Python ile Instagram Botu Yazma",
                    UserId = 1,
                    ViewCount = 1224875,
                    CommentCount = 1
                });
        }
    }
}

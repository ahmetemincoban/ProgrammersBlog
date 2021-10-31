using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class Yapilandirma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoAuthor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8441), "C# Programlama dili ile ilgili en güncel bilgiler.", true, false, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8456), "C#", "C# Kategorisi" },
                    { 2, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8471), "Java Programlama dili ile ilgili en güncel bilgiler.", true, false, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8472), "JAVA", "JAVA Kategorisi" },
                    { 3, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8476), "Python Programlama dili ile ilgili en güncel bilgiler.", true, false, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 900, DateTimeKind.Local).AddTicks(8478), "Python", "Python Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 904, DateTimeKind.Local).AddTicks(7857), "Bu en yetkili kullanıcı yetkisidir. Her türlü izni bulunur", true, false, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 904, DateTimeKind.Local).AddTicks(7872), "Admin", "Admin Rolüdür" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PasswordHash", "Picture", "RoleId", "Username" },
                values: new object[] { 1, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 917, DateTimeKind.Local).AddTicks(6274), "İlk admin kullanıcı", "mail@ahmeteminst.com", "Ahmet Emin", true, false, "ST", "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 917, DateTimeKind.Local).AddTicks(6289), "Admin Kullanıcısı", new byte[] { 54, 101, 51, 51, 54, 98, 97, 54, 101, 57, 49, 102, 98, 55, 102, 100, 99, 101, 50, 57, 98, 53, 52, 52, 53, 48, 55, 98, 54, 56, 56, 53 }, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU", 1, "ahmeteminst" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewCount" },
                values: new object[] { 1, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec bibendum nibh, et hendrerit lorem. Quisque tempus nisl nec ex rhoncus, a tincidunt neque placerat. Ut ut enim ac odio vehicula aliquam nec eget lorem. Nulla ultricies turpis maximus massa faucibus rhoncus ac quis risus. Pellentesque dignissim libero vel odio consectetur, quis imperdiet nisl rutrum. Curabitur sed orci quam. Etiam quis tincidunt est, sed ultricies tortor. Fusce vitae ex pellentesque diam egestas volutpat. Nunc malesuada nulla et erat dapibus placerat. Nullam maximus ante in nibh tincidunt eleifend. Sed facilisis neque eu condimentum luctus.", "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(5573), new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(4452), true, false, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(6121), "C# 9.0 Yenilikleri", "AhmetEminST", "C# 9.0 Yenilikleri", "C#, C# 9, .net5", "default.jpg", "C# 9.0 Yenilikleri", 1, 95842 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewCount" },
                values: new object[] { 2, 2, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec bibendum nibh, et hendrerit lorem. Quisque tempus nisl nec ex rhoncus, a tincidunt neque placerat. Ut ut enim ac odio vehicula aliquam nec eget lorem. Nulla ultricies turpis maximus massa faucibus rhoncus ac quis risus. Pellentesque dignissim libero vel odio consectetur, quis imperdiet nisl rutrum. Curabitur sed orci quam. Etiam quis tincidunt est, sed ultricies tortor. Fusce vitae ex pellentesque diam egestas volutpat. Nunc malesuada nulla et erat dapibus placerat. Nullam maximus ante in nibh tincidunt eleifend. Sed facilisis neque eu condimentum luctus.", "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7353), new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7351), true, false, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7355), "JAVA Spring Yenilikleri", "AhmetEminST", "JAVA Spring Yenilikleri", "JAVA, JAVA SPRING, JAVA ILE MOBIL UYGULAMA", "default.jpg", "JAVA Spring Yenilikleri", 1, 157456 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "SeoAuthor", "SeoDescription", "SeoTags", "Thumbnail", "Title", "UserId", "ViewCount" },
                values: new object[] { 3, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse nec bibendum nibh, et hendrerit lorem. Quisque tempus nisl nec ex rhoncus, a tincidunt neque placerat. Ut ut enim ac odio vehicula aliquam nec eget lorem. Nulla ultricies turpis maximus massa faucibus rhoncus ac quis risus. Pellentesque dignissim libero vel odio consectetur, quis imperdiet nisl rutrum. Curabitur sed orci quam. Etiam quis tincidunt est, sed ultricies tortor. Fusce vitae ex pellentesque diam egestas volutpat. Nunc malesuada nulla et erat dapibus placerat. Nullam maximus ante in nibh tincidunt eleifend. Sed facilisis neque eu condimentum luctus.", "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7361), new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7360), true, false, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 897, DateTimeKind.Local).AddTicks(7363), "Python ile Instagram Botu Yazma", "AhmetEminST", "Python ile Instagram Botu Yazma", "Python, instagram, bot", "default.jpg", "Python ile Instagram Botu Yazma", 1, 1224875 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 1, 1, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8638), true, false, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8651), "C# Makale Yorumu", "Çok çokomel bir makale :)" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 2, 2, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8664), true, false, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8665), "JAVA Makale Yorumu", "Çok Çükülop bir makale :)" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "Text" },
                values: new object[] { 3, 3, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8669), true, false, "InitialCreate", new DateTime(2021, 10, 31, 6, 23, 3, 902, DateTimeKind.Local).AddTicks(8671), "Python Makale Yorumu", "Çok Çükübik bir makale :)" });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}

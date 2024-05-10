using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class initials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookShelves",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookShelves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7695)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7905)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635)),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "avatar-default.png"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublishedBooks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "default.png"),
                    PublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    PublishedYear = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Checkout_visit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishedBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublishedBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublishedBooks_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(8873)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Accounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedBookId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DueTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookDetails_PublishedBooks_PublishedBookId",
                        column: x => x.PublishedBookId,
                        principalTable: "PublishedBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookShelfDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PublishedBookId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BookShelfId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookShelfDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookShelfDetails_BookShelves_BookShelfId",
                        column: x => x.BookShelfId,
                        principalTable: "BookShelves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookShelfDetails_PublishedBooks_PublishedBookId",
                        column: x => x.PublishedBookId,
                        principalTable: "PublishedBooks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublishedBookId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 158, DateTimeKind.Local).AddTicks(166))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Accounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedBacks_PublishedBooks_PublishedBookId",
                        column: x => x.PublishedBookId,
                        principalTable: "PublishedBooks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(9229)),
                    ReplyCommentId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Accounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookRequests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookDetailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookCheckoutId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BorrowedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceivedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CanceledTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookRequests_Accounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookRequests_BookDetails_BookDetailId",
                        column: x => x.BookDetailId,
                        principalTable: "BookDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[] { new Guid("372ea575-2536-4076-9bab-3e3138de495f"), 0, "c4c65004-74a1-463f-853b-deb43e0964f9", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAjimhtQJPoZZ8x+EpOGS4BzrelQXYU8JcD6LCtodU+xNBiNWUCWG7cqTy56FDA7dw==", "0123456789", false, null, false, null, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "A001", "Đặng Hoàng Giang" },
                    { "A002", "Higashino Keigo" },
                    { "A003", "Nguyễn Công Danh" },
                    { "A004", "Trần Cao Đệ" },
                    { "A005", "Huỳnh Xuân Hiệp" }
                });

            migrationBuilder.InsertData(
                table: "BookShelves",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { "8a509337-277f-4c0d-94d8-e693ccf58a96", false, "SH-001-B" },
                    { "aedab447-dd1f-4dad-becf-aa74ed03fe7b", false, "SH-001-A" },
                    { "da29aa39-bfca-4405-b8fe-b21ee816f404", false, "SH-002-A" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tiểu thuyết" },
                    { 2, "Sách tâm lý" },
                    { 3, "Sách khoa học" },
                    { 4, "Từ điển" },
                    { 5, "Sách văn học" },
                    { 6, "Giáo trình" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1712E51B-0E16-41AC-8CC4-28BCDFCA9A98", "Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh" },
                    { "1E81F92D-2DB9-44CA-99B4-980B51D1E0C7", "Nhà xuất bản Trường Đại học Cần Thơ" },
                    { "4D9FF82E-2B49-47D8-B5ED-43FEE479883D", "Nhà xuất bản Kim Đồng" },
                    { "A1D207B4-F571-4447-8FE0-E00B2F2D2724", "Nhà xuất bản Hội Nhà Văn" },
                    { "B1049AEC-30EA-4C8C-8DCC-D35F3AC17C90", "Nhà xuất bản Trẻ" },
                    { "E1B5B1AB-69C9-4D5A-8148-3823605D855A", "Nhà xuất bản Đại học Cần Thơ" },
                    { "F28F2290-EE06-4831-9091-8124FE61DFB9", "Nhà xuất bản Lao động" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), "d8d3d56a-45c8-4a8f-a9f0-0880f491243a", "User", "USER" },
                    { new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"), "2006a84f-fe01-44de-99ed-17e781c7f99c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber", "UserCode" },
                values: new object[] { "8A820ADB-93D7-4C6F-9404-BDBFC14419F4", "Đường 3/2, phường Xuân Khánh, quận Ninh Kiều, TP. Cần Thơ", null, "Lê Minh Kha", "0398897634", "B2012213" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[] { new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"), 0, "8fdd1220-4260-4e43-88fd-d8d06477ffe0", null, false, false, null, "KHA@GMAIL.COM", "KHA@GMAIL.COM", "AQAAAAEAACcQAAAAEGJ3bCSB/gWe9cafxlQCVacgQ8YgM4a3oiowCFzcLI3ax8fdMXx7x8nvjwawPLiutw==", null, false, null, false, "8A820ADB-93D7-4C6F-9404-BDBFC14419F4", "kha@gmail.com" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { "0E9B5F1B-0C7B-4093-9559-D3A7FE380832", 2, "Tìm mình trong thế giới hậu tuổi thơ" },
                    { "34824C95-72D2-4861-A552-75BAC6F9508F  ", 2, "Rồi một ngày cuộc sống hóa hư vô" },
                    { "3ECC8999-CAEA-4C31-9A0E-37FF9158427E", 6, "Đảm bảo chất lượng phần mềm" },
                    { "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB", 4, "Từ điển tiếng Việt" },
                    { "507C99E1-1586-43C1-8831-E7B499C08EE0", 3, "Sapien lược sử loài người" },
                    { "90B5054A-9A37-4249-B1A1-209FFC7AE80D", 1, "Điều kỳ diệu của tiệm tạp hóa Namiya" },
                    { "A7A7CFF3-5B28-4921-9F06-599A3B14A776", 3, "Thần số học" },
                    { "ABF7E859-5FBA-4C19-B842-B442062C8909", 3, "Lược sử Trái Đất" },
                    { "AFE53773-D1B3-462D-B27E-8D37C1138639", 1, "Quán ăn nơi góc hẻm" },
                    { "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D", 5, "Đất rừng phương nam" },
                    { "B575681C-AD00-49E9-B85E-82F738439CBF", 4, "Từ điển Hán Việt" }
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "id", "372ea575-2536-4076-9bab-3e3138de495f", new Guid("372ea575-2536-4076-9bab-3e3138de495f") },
                    { 2, "email", "admin@gmail.com", new Guid("372ea575-2536-4076-9bab-3e3138de495f") },
                    { 3, "roles", "Admin", new Guid("372ea575-2536-4076-9bab-3e3138de495f") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"), new Guid("372ea575-2536-4076-9bab-3e3138de495f") });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "Image", "Title", "UpdatedDate", "UserAccountId" },
                values: new object[] { "BF001", "Test", "Test", "Test", null, new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { "A001", "0E9B5F1B-0C7B-4093-9559-D3A7FE380832" },
                    { "A003", "3ECC8999-CAEA-4C31-9A0E-37FF9158427E" },
                    { "A004", "3ECC8999-CAEA-4C31-9A0E-37FF9158427E" }
                });

            migrationBuilder.InsertData(
                table: "PublishedBooks",
                columns: new[] { "Id", "BookId", "Checkout_visit", "Code", "Description", "Image", "Pages", "PublishedYear", "PublisherId", "Rating" },
                values: new object[,]
                {
                    { "7F33BDA5-7C2B-447A-89E3-DC670ACC3646", "0E9B5F1B-0C7B-4093-9559-D3A7FE380832", 1, "PB20240331180721", null, "1.png", 404, 2020, "A1D207B4-F571-4447-8FE0-E00B2F2D2724", 4.2999999999999998 },
                    { "FB51AB25-2788-4B0E-996E-2A68282B2C88", "3ECC8999-CAEA-4C31-9A0E-37FF9158427E", 1, "PB20240331180721", null, "giaotrinhdbclpm.png", 312, 2012, "E1B5B1AB-69C9-4D5A-8148-3823605D855A", 2.2999999999999998 }
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 4, "id", "2a738bf3-a14b-488e-b04e-17f918e8d6a4", new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") },
                    { 5, "email", "kha@gmail.com", new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") },
                    { 6, "roles", "User", new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "Id", "Code", "CreatedTime", "DueTime", "IsAvailable", "IsDeleted", "LastModifiedTime", "PublishedBookId", "Status" },
                values: new object[,]
                {
                    { "4c0dc5ae-c609-4f5b-88eb-f8b81ab59439", "BD20240306202612", null, null, false, false, null, "7F33BDA5-7C2B-447A-89E3-DC670ACC3646", 0 },
                    { "da4b76e3-2d86-4f50-ab6e-c93a73d10e0e", "BD20240306202611", null, null, false, false, null, "7F33BDA5-7C2B-447A-89E3-DC670ACC3646", 0 },
                    { "eb7eae5e-c665-4635-aeb0-b05398f9ca87", "BD20240306202613", null, null, false, false, null, "7F33BDA5-7C2B-447A-89E3-DC670ACC3646", 0 }
                });

            migrationBuilder.InsertData(
                table: "BookShelfDetails",
                columns: new[] { "Id", "BookShelfId", "IsDeleted", "PublishedBookId" },
                values: new object[,]
                {
                    { "c5103159-813c-48a5-b5b0-b3d12185fb10", "aedab447-dd1f-4dad-becf-aa74ed03fe7b", false, "7F33BDA5-7C2B-447A-89E3-DC670ACC3646" },
                    { "e6ef33c8-e912-43ef-af95-03b07bc4f2e9", "8a509337-277f-4c0d-94d8-e693ccf58a96", false, "FB51AB25-2788-4B0E-996E-2A68282B2C88" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BlogId", "Content", "CreatedDate", "ReplyCommentId", "UserAccountId" },
                values: new object[] { 1, "BF001", "Test", new DateTime(2024, 3, 31, 18, 7, 21, 161, DateTimeKind.Local).AddTicks(5577), null, new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") });

            migrationBuilder.InsertData(
                table: "FeedBacks",
                columns: new[] { "Id", "Content", "CreatedDate", "PublishedBookId", "Rate", "UserAccountId" },
                values: new object[] { 1, "Test", new DateTime(2024, 3, 31, 18, 7, 21, 161, DateTimeKind.Local).AddTicks(5592), "7F33BDA5-7C2B-447A-89E3-DC670ACC3646", 5.0, new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") });

            migrationBuilder.InsertData(
                table: "BookRequests",
                columns: new[] { "Id", "ApprovedTime", "BookCheckoutId", "BookDetailId", "BorrowedTime", "CanceledTime", "Code", "CreatedTime", "DueTime", "IsDeleted", "Note", "ReceivedTime", "RejectedTime", "ReturnedTime", "Status", "UserAccountId" },
                values: new object[] { "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB", null, null, "da4b76e3-2d86-4f50-ab6e-c93a73d10e0e", null, null, "BR20240331180721", null, null, false, null, null, null, null, 3, new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Accounts",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Accounts",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserAccountId",
                table: "Blogs",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_PublishedBookId",
                table: "BookDetails",
                column: "PublishedBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRequests_BookDetailId",
                table: "BookRequests",
                column: "BookDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRequests_UserAccountId",
                table: "BookRequests",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookShelfDetails_BookShelfId",
                table: "BookShelfDetails",
                column: "BookShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_BookShelfDetails_PublishedBookId",
                table: "BookShelfDetails",
                column: "PublishedBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserAccountId",
                table: "Comments",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_PublishedBookId",
                table: "FeedBacks",
                column: "PublishedBookId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_UserAccountId",
                table: "FeedBacks",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishedBooks_BookId",
                table: "PublishedBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishedBooks_PublisherId",
                table: "PublishedBooks",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookRequests");

            migrationBuilder.DropTable(
                name: "BookShelfDetails");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropTable(
                name: "BookShelves");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "PublishedBooks");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

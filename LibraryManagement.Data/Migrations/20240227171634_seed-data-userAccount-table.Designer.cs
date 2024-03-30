﻿// <auto-generated />
using System;
using LibraryManagement.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagement.Data.Migrations
{
    [DbContext(typeof(LibraryManagementDbContext))]
    [Migration("20240227171634_seed-data-userAccount-table")]
    partial class seeddatauserAccounttable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryManagement.Data.Models.Author", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Blog", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(7365));

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserAccountId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Book", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(3334));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(3512));

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.BookAuthor", b =>
                {
                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AuthorId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthors");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.BookCheckout", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookDetailId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(8967));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("BookDetailId")
                        .IsUnique()
                        .HasFilter("[BookDetailId] IS NOT NULL");

                    b.ToTable("BookCheckouts");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.BookDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("PublishedBookId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PublishedBookId");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.BookRequest", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ApprovedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookCheckoutId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("BorrowedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CanceledTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PublishedBookId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ReceivedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RejectedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BookCheckoutId");

                    b.HasIndex("PublishedBookId");

                    b.HasIndex("UserAccountId");

                    b.ToTable("BookRequests");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(6363));

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(6545));

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BlogId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(7707));

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int?>("ReplyCommentId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("UserAccountId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.FeedBack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(8417));

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PublishedBookId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Rate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<Guid>("UserAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PublishedBookId");

                    b.HasIndex("UserAccountId");

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.PublishedBook", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("default.png");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int?>("PublishedYear")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("PublisherId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("PublisherId");

                    b.ToTable("PublishedBooks");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Publisher", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "8a820adb-93d7-4c6f-9404-bdbfc14419f4",
                            Name = "Lê Minh Kha",
                            PhoneNumber = "0398897634",
                            UserCode = "B2012213"
                        });
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.UserAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("avatar-default.png");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserPracticalId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("UserPracticalId")
                        .IsUnique()
                        .HasFilter("[UserPracticalId] IS NOT NULL");

                    b.ToTable("Accounts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e3d9a8f3-2150-4b6b-a199-049d4c14776c",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "KHA@GMAIL.COM",
                            NormalizedUserName = "KHA@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIoHbTmYB9oIPeacADuokeSxpEM1pTP6/cpUL2ecaf27hyrzlss/51faEGB1HdALcQ==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "kha@gmail.com",
                            UserPracticalId = "8A820ADB-93D7-4C6F-9404-BDBFC14419F4"
                        },
                        new
                        {
                            Id = new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "933ed77f-2f27-4223-a06f-11a3b696f2eb",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOSecR9NDWvwufbkKGy1kPBpMTUE/mQC066/LGQI8A9D2zuFPe8kOj4bDRVQ/Z+few==",
                            PhoneNumber = "0123456789",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                            ConcurrencyStamp = "3d8c78f8-ee28-4e94-88c1-63a121162d27",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                            ConcurrencyStamp = "0804fd11-179b-4d4a-b544-c765e6ab3e86",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "id",
                            ClaimValue = "372ea575-2536-4076-9bab-3e3138de495f",
                            UserId = new Guid("372ea575-2536-4076-9bab-3e3138de495f")
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "email",
                            ClaimValue = "admin@gmail.com",
                            UserId = new Guid("372ea575-2536-4076-9bab-3e3138de495f")
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "roles",
                            ClaimValue = "Admin",
                            UserId = new Guid("372ea575-2536-4076-9bab-3e3138de495f")
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "id",
                            ClaimValue = "2a738bf3-a14b-488e-b04e-17f918e8d6a4",
                            UserId = new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4")
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "email",
                            ClaimValue = "kha@gmail.com",
                            UserId = new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4")
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "roles",
                            ClaimValue = "User",
                            UserId = new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                            RoleId = new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22")
                        },
                        new
                        {
                            UserId = new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                            RoleId = new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Blog", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.UserAccount", "UserAccount")
                        .WithMany("Blogs")
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Book", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.BookAuthor", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagement.Data.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.BookCheckout", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.BookDetail", "BookDetail")
                        .WithOne("BookCheckout")
                        .HasForeignKey("LibraryManagement.Data.Models.BookCheckout", "BookDetailId");

                    b.Navigation("BookDetail");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.BookDetail", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.PublishedBook", "PublishedBook")
                        .WithMany("BookDetails")
                        .HasForeignKey("PublishedBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublishedBook");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.BookRequest", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.BookCheckout", "BookCheckout")
                        .WithMany()
                        .HasForeignKey("BookCheckoutId");

                    b.HasOne("LibraryManagement.Data.Models.PublishedBook", "PublishedBook")
                        .WithMany("BookRequests")
                        .HasForeignKey("PublishedBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagement.Data.Models.UserAccount", "UserAccount")
                        .WithMany("BookRequests")
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookCheckout");

                    b.Navigation("PublishedBook");

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Comment", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId");

                    b.HasOne("LibraryManagement.Data.Models.UserAccount", "UserAccount")
                        .WithMany("Comments")
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.FeedBack", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.PublishedBook", "PublishedBook")
                        .WithMany("FeedBacks")
                        .HasForeignKey("PublishedBookId");

                    b.HasOne("LibraryManagement.Data.Models.UserAccount", "UserAccount")
                        .WithMany("FeedBacks")
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PublishedBook");

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.PublishedBook", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.Book", "Book")
                        .WithMany("PublishedBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagement.Data.Models.Publisher", "Publisher")
                        .WithMany("PublishedBooks")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.UserAccount", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.User", "User")
                        .WithOne("UserAccount")
                        .HasForeignKey("LibraryManagement.Data.Models.UserAccount", "UserPracticalId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.UserAccount", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.UserAccount", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagement.Data.Models.UserAccount", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("LibraryManagement.Data.Models.UserAccount", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Blog", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("PublishedBooks");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.BookDetail", b =>
                {
                    b.Navigation("BookCheckout")
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.PublishedBook", b =>
                {
                    b.Navigation("BookDetails");

                    b.Navigation("BookRequests");

                    b.Navigation("FeedBacks");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.Publisher", b =>
                {
                    b.Navigation("PublishedBooks");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.User", b =>
                {
                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("LibraryManagement.Data.Models.UserAccount", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("BookRequests");

                    b.Navigation("Comments");

                    b.Navigation("FeedBacks");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeddatauserAccounttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(8417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(7707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(6545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(6363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(3512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 805, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(3334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 805, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(8967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(7365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserPracticalId" },
                values: new object[,]
                {
                    { new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"), 0, "e3d9a8f3-2150-4b6b-a199-049d4c14776c", null, false, false, null, "KHA@GMAIL.COM", "KHA@GMAIL.COM", "AQAAAAEAACcQAAAAEIoHbTmYB9oIPeacADuokeSxpEM1pTP6/cpUL2ecaf27hyrzlss/51faEGB1HdALcQ==", null, false, null, false, "kha@gmail.com", "8A820ADB-93D7-4C6F-9404-BDBFC14419F4" },
                    { new Guid("372ea575-2536-4076-9bab-3e3138de495f"), 0, "933ed77f-2f27-4223-a06f-11a3b696f2eb", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOSecR9NDWvwufbkKGy1kPBpMTUE/mQC066/LGQI8A9D2zuFPe8kOj4bDRVQ/Z+few==", "0123456789", false, null, false, "admin@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), "0804fd11-179b-4d4a-b544-c765e6ab3e86", "User", "USER" },
                    { new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"), "3d8c78f8-ee28-4e94-88c1-63a121162d27", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "id", "372ea575-2536-4076-9bab-3e3138de495f", new Guid("372ea575-2536-4076-9bab-3e3138de495f") },
                    { 2, "email", "admin@gmail.com", new Guid("372ea575-2536-4076-9bab-3e3138de495f") },
                    { 3, "roles", "Admin", new Guid("372ea575-2536-4076-9bab-3e3138de495f") },
                    { 4, "id", "2a738bf3-a14b-488e-b04e-17f918e8d6a4", new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") },
                    { 5, "email", "kha@gmail.com", new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") },
                    { 6, "roles", "User", new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") },
                    { new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"), new Guid("372ea575-2536-4076-9bab-3e3138de495f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"), new Guid("372ea575-2536-4076-9bab-3e3138de495f") });

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(2753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(1985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 805, DateTimeKind.Local).AddTicks(7746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 805, DateTimeKind.Local).AddTicks(7569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(3229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 8, 806, DateTimeKind.Local).AddTicks(1671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(7365));
        }
    }
}

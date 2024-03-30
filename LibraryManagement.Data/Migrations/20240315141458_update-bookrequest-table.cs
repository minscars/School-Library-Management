using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatebookrequesttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(6652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(5576),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(3744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "BookRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(7379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(5137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63db932a-a9f9-4190-bb4b-6aeb8860b1f9", "AQAAAAEAACcQAAAAEOYR3CEyOEF1aPyVuv3ft3qJfQhUF4TCj7XREDyM52SyStuxXcmysGpbAF+ttgBocg==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e6d26d5-847e-448d-bf43-7b3d80470624", "AQAAAAEAACcQAAAAEK+Jsbju2+B+xXQpkcDMUVDIVglFEAwpK25eH8hjnbqhUVUFE4+qRqcZ9nO5d2LmMg==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                columns: new[] { "Code", "Note" },
                values: new object[] { "BR20240315211457", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 21, 14, 57, 719, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 21, 14, 57, 719, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240315211457");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240315211457");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "7a49c580-06f9-47e4-939f-95567a089c89");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "6b2f068a-36cf-440a-9d93-13914512b257");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "BookRequests");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(5527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(4477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 713, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(6229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(4037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 21, 14, 57, 714, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "796d9482-248e-46bc-b7c1-f675bc556172", "AQAAAAEAACcQAAAAEE6N5Wt7L0qmYpuNZL76k7ikrnH4k0z3lyX2ESEOhVkEiu9FAQ6uopZjL2u+HaReXg==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3371e5f9-0c7d-4dc3-8908-3b16e44fc980", "AQAAAAEAACcQAAAAEBU41I9LW0o1UAmQgd2nRKB0OcDqjGumI0M2QaTkdezx4K3ZVBt9ypD63sOd2ogNIg==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240315201814");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2660), new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 20, 18, 14, 163, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 20, 18, 14, 163, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240315201814");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240315201814");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "134028d8-ea23-4bd5-9e0e-cbc48b5a8297");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "cbf1a66e-d950-4364-a92e-2651608161ce");
        }
    }
}

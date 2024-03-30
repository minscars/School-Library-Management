using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatebookdetailtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCheckouts_BookDetails_BookDetailId",
                table: "BookCheckouts");

            migrationBuilder.DropIndex(
                name: "IX_BookCheckouts_BookDetailId",
                table: "BookCheckouts");

            migrationBuilder.RenameColumn(
                name: "BookDetailId",
                table: "BookCheckouts",
                newName: "BookDetailCode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(5527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 683, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(4477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 683, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(6229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 683, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(4037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(9848));

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

            migrationBuilder.CreateIndex(
                name: "IX_BookCheckouts_BookDetailCode",
                table: "BookCheckouts",
                column: "BookDetailCode",
                unique: true,
                filter: "[BookDetailCode] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCheckouts_BookDetails_BookDetailCode",
                table: "BookCheckouts",
                column: "BookDetailCode",
                principalTable: "BookDetails",
                principalColumn: "Code");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCheckouts_BookDetails_BookDetailCode",
                table: "BookCheckouts");

            migrationBuilder.DropIndex(
                name: "IX_BookCheckouts_BookDetailCode",
                table: "BookCheckouts");

            migrationBuilder.RenameColumn(
                name: "BookDetailCode",
                table: "BookCheckouts",
                newName: "BookDetailId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 683, DateTimeKind.Local).AddTicks(2544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 683, DateTimeKind.Local).AddTicks(701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 158, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 683, DateTimeKind.Local).AddTicks(3826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(9848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 20, 18, 14, 159, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6ce2b2c-e699-44d9-a472-25ec6696692b", "AQAAAAEAACcQAAAAEJI+5Bk2Voc7AIaKtIR/3EgThcZ3jTr+Gg+9NwzYXmcjXYv55xQRCDjr1ACLR8Uiuw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2769996c-33c0-4fd3-a750-956505e8bffe", "AQAAAAEAACcQAAAAEAO11MyBxmQvRu52WhEP+EkxUDMxOKFJ6iNLsXwPRSoLHnPn+wdCA4yuO0+o2gI6yQ==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240315201647");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 681, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 3, 15, 20, 16, 47, 682, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 20, 16, 47, 690, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 15, 20, 16, 47, 690, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240315201647");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240315201647");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "498030b2-80ea-474a-8bc1-e7efc38e54da");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "52f5923d-eeee-4292-98d4-82a2c732d7a2");

            migrationBuilder.CreateIndex(
                name: "IX_BookCheckouts_BookDetailId",
                table: "BookCheckouts",
                column: "BookDetailId",
                unique: true,
                filter: "[BookDetailId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCheckouts_BookDetails_BookDetailId",
                table: "BookCheckouts",
                column: "BookDetailId",
                principalTable: "BookDetails",
                principalColumn: "Code");
        }
    }
}

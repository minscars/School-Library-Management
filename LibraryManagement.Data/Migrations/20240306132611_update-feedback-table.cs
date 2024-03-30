﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatefeedbacktable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rate",
                table: "FeedBacks",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 432, DateTimeKind.Local).AddTicks(253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(9091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(7218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(6973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 432, DateTimeKind.Local).AddTicks(1173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(8674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ebafd66-4243-4fed-87b3-b8efe653944b", "AQAAAAEAACcQAAAAEG0WcjHsiJkcnOZ79nVSaBJLZSBm13jP93+DVoFlMOgbQdVV2NG5/MSCTCDZ4DCbTw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49b1eea4-6106-4084-adc4-80b2b969c208", "AQAAAAEAACcQAAAAEMcZp4o+pQD70/ivHu+GmldCHg9R2nWke+5wNMhrOoat2j4Q2u/nk2Wwm0u6HUxY/g==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: "2E6E1A12-7B56-4288-AB5E-1381BD5902CA",
                column: "Code",
                value: "BD20240306202611");

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240306202611");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 6, 20, 26, 11, 435, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Rate" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 11, 435, DateTimeKind.Local).AddTicks(9064), 5.0 });

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240306202611");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240306202611");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "5cc67e46-17f1-4d20-a0f8-64a9e0596cdf");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "9b22dd48-05c3-4887-a524-771e5c2f51eb");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "FeedBacks",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(5397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 432, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(4357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(6062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 432, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(3857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 6, 20, 26, 11, 431, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06399388-c6c5-47fd-a357-9ca44763153b", "AQAAAAEAACcQAAAAEADsWmJCrP0sBeyNru/AR/4WWXrrsmOsMDUFQCe+YiVW2ZrQgs5Gt9xngiiNDE8T4w==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72de4d94-4bc4-41ed-a486-960b9fc389c3", "AQAAAAEAACcQAAAAEGyUiS+YT+UZoUkBTMlOxhvJvMgmBC2cCZmk25/RdnQ9HrUeNcui5CRre0rpkKiiGw==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: "2E6E1A12-7B56-4288-AB5E-1381BD5902CA",
                column: "Code",
                value: "BD20240304231944");

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240304231944");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 3, 4, 23, 19, 44, 472, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2457), new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2457), new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2457), new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2457), new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2457), new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2457), new DateTime(2024, 3, 4, 23, 19, 44, 473, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 4, 23, 19, 44, 477, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Rate" },
                values: new object[] { new DateTime(2024, 3, 4, 23, 19, 44, 477, DateTimeKind.Local).AddTicks(2552), 5 });

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240304231944");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240304231944");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "2ab7ccde-204e-4acf-ad13-565d5e833791");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "95d7dc25-a8a8-474f-b527-a38b4be420e8");
        }
    }
}

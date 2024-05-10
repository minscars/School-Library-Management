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
                defaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(6157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(5154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExtendedTime",
                table: "BookRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(4784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd7756f5-8bc5-4552-883a-38b5b69b9544", "AQAAAAEAACcQAAAAEL1CWNEherYPlI5OFSHmUByB6GD3dI2cSBFHkvbRvs3UCFQDv1v5FXu3/qKqqdxv1A==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1fa4cb0-50d4-4016-957b-ba5311b8df77", "AQAAAAEAACcQAAAAEP6wMMurgXVkz+TyiwSDzqyyVLB+NX16/3ha+xldYqFi2CYv8mr7u/Ju8V5nNXbGLw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afdf6aed-ae44-41b1-97a7-bf4b9840ab48", "AQAAAAEAACcQAAAAEMia4+g6OAiFYu9iZsSxpjILwgWjA8kEO4Uxl0nhahxUKDWLUX4EeEj4HmiF+SbtIQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa8e4d8f-cec2-49be-b9dc-4bd35a09609e", "AQAAAAEAACcQAAAAEOAa5b2uPyGGwLJtJ62Qgnt+WRgm8ErsHtumm/hlS6zXB1eGldCSkQNX7H528XPkQw==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                columns: new[] { "Code", "ExtendedTime" },
                values: new object[] { "BR20240416152902", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 15, 29, 2, 46, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 16, 15, 29, 2, 46, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240416152902");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240416152902");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "b1e7d07f-473c-4099-a8e5-dfad54822f56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "f53af6fc-33fb-44a5-8ff8-dc8d784f4f81");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtendedTime",
                table: "BookRequests");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(6283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(5258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(4876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 16, 15, 29, 2, 39, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "721928df-748c-43d7-91ec-394ec3ba1f6f", "AQAAAAEAACcQAAAAEMF3LeaHSTDzQxtiJa+MAGwfjPQqBBIQxs4hv501Q/fiHCQZldpnCdx1988V5OfodA==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "183a4693-d71f-4a1a-b1e8-5b0ec5fe7634", "AQAAAAEAACcQAAAAEB+qipKS4HGwxHKzZ9zZ+jLkXy43PRsoy8oMciQnrexM9TM1EA66k6E6BCvsfaLaIg==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed3f22f8-68d7-4c05-91f0-61e59f94ab58", "AQAAAAEAACcQAAAAEIxcNgbTrH+RWwMEGWTd20U8UNO57ibDxM8u9JWP/s4DqDVcyLs3/i5Ezf6kpgmaOw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "daaf654e-24fa-4dc9-8dc0-d7a4ebb57710", "AQAAAAEAACcQAAAAENUBL+J8LhDA6NyvG2TBgoInAfDOp3vwUbdrmiJ4MJBwcIJxHpEyocDfXcUskeQhZQ==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240415154252");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 42, 52, 604, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 42, 52, 604, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240415154252");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240415154252");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "a9cd0a06-a7e0-41a0-bc9c-d83286949bd8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "ade84458-eccd-4335-a0f9-221f104548a1");
        }
    }
}

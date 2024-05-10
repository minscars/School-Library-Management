using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeddatafortwousers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(6283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 158, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(5258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(4876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(8873));

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber", "UserCode" },
                values: new object[,]
                {
                    { "1B1BC693-F841-4B2D-9567-63710DA34F1D", "Cái Răng, TP. Cần Thơ", null, "Lưu Hoàng Lỉnh", "0123456789", "B2012223" },
                    { "BEFE5A8F-B2F6-48C4-AAA0-E4DDA7A3914C", "87 Lê Văn Huân, Phường 13, Quận Tân Bình, TP. Hồ Chí Minh", null, "Nguyễn Tùng Lâm", "0338307449", "B1809363" },
                    { "D8E5F8D4-09DE-42FA-9952-37AF9BF3EE9B", "Hẻm 51, TP. Cần Thơ", null, "Nguyễn Trung Nhẩn", "0122334455", "B2012237" },
                    { "F7AA67C1-B3CB-4CCE-9394-1630407343BF", "Ninh Kiều, TP. Cần Thơ", null, "Trần Chí Thể", "1234567890", "B2003923" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"), 0, "ed3f22f8-68d7-4c05-91f0-61e59f94ab58", null, false, false, null, "THE@GMAIL.COM", "THE@GMAIL.COM", "AQAAAAEAACcQAAAAEIxcNgbTrH+RWwMEGWTd20U8UNO57ibDxM8u9JWP/s4DqDVcyLs3/i5Ezf6kpgmaOw==", null, false, null, false, "F7AA67C1-B3CB-4CCE-9394-1630407343BF", "the@gmail.com" },
                    { new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"), 0, "daaf654e-24fa-4dc9-8dc0-d7a4ebb57710", null, false, false, null, "LAM@GMAIL.COM", "LAM@GMAIL.COM", "AQAAAAEAACcQAAAAENUBL+J8LhDA6NyvG2TBgoInAfDOp3vwUbdrmiJ4MJBwcIJxHpEyocDfXcUskeQhZQ==", null, false, null, false, "BEFE5A8F-B2F6-48C4-AAA0-E4DDA7A3914C", "lam@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 7, "id", "f5aa72ea-a563-4e89-a289-e290814f3c17", new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17") },
                    { 8, "email", "lam@gmail.com", new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17") },
                    { 9, "roles", "User", new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17") },
                    { 10, "id", "f4e9077d-d904-4c9e-860e-7c0373cfddff", new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff") },
                    { 11, "email", "the@gmail.com", new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff") },
                    { 12, "roles", "User", new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff") },
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1B1BC693-F841-4B2D-9567-63710DA34F1D");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "D8E5F8D4-09DE-42FA-9952-37AF9BF3EE9B");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "BEFE5A8F-B2F6-48C4-AAA0-E4DDA7A3914C");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "F7AA67C1-B3CB-4CCE-9394-1630407343BF");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 158, DateTimeKind.Local).AddTicks(166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(9229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(8873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 15, 15, 42, 52, 597, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8fdd1220-4260-4e43-88fd-d8d06477ffe0", "AQAAAAEAACcQAAAAEGJ3bCSB/gWe9cafxlQCVacgQ8YgM4a3oiowCFzcLI3ax8fdMXx7x8nvjwawPLiutw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4c65004-74a1-463f-853b-deb43e0964f9", "AQAAAAEAACcQAAAAEAjimhtQJPoZZ8x+EpOGS4BzrelQXYU8JcD6LCtodU+xNBiNWUCWG7cqTy56FDA7dw==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240331180721");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 3, 31, 18, 7, 21, 157, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 18, 7, 21, 161, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 18, 7, 21, 161, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240331180721");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240331180721");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "d8d3d56a-45c8-4a8f-a9f0-0880f491243a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "2006a84f-fe01-44de-99ed-17e781c7f99c");
        }
    }
}

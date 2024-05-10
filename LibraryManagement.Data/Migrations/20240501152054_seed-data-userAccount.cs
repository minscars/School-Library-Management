using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeddatauserAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(6696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(5474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(4938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2409dbd-ae12-453b-942d-bbbcde28f8d1", "AQAAAAEAACcQAAAAEFnw32G1041apBLD6NWxfQDYQ7/p6UwovNq52dQJMsXF2cbZv+/cN/6eo2R65j8jpw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e50f509-d9f6-4e29-ba33-574d94a4b1b7", "AQAAAAEAACcQAAAAEOE5RBB98c/5vqxsug0ypPFwj3NRRtVy+a1FwUvka5pJSPoEIIJqE8U7A/6rLKcb+w==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75d0ed3c-b7ac-46ff-ac02-ebfbbc123d34", "AQAAAAEAACcQAAAAEKvu/AEeqh7sxggo7/RzkzWn02ZwE4U01wE4674KWT8c3D+ZGB6kbipJaG6niNmCzQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "67947507-766f-474c-b261-cc34b464a643", "AQAAAAEAACcQAAAAEIM3tQIvFdNVqiT/XAJaIhILRFZ+Bg113f6Mks4am3mBP7cqXiaP+bTXiNgOI/htzg==" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732"), 0, "eaa58219-6ac3-4fe8-a6a3-41b41fd4a6af", null, false, false, null, "LINH@GMAIL.COM", "LINH@GMAIL.COM", "AQAAAAEAACcQAAAAEBWH8IbuT37hNGaIzv3eVchKcFD8nXBDX2fYERjA9JUCq5XDN1CxNU5+8UT4DHFM3w==", null, false, null, false, "1B1BC693-F841-4B2D-9567-63710DA34F1D", "linh@gmail.com" },
                    { new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac"), 0, "96304850-bf02-45c0-af97-8fe5ed3f1c35", null, false, false, null, "NHAN@GMAIL.COM", "NHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEJIg2YL/PqFs/eP8bRBOLZnuXUU05kqtwa7uJE8pHvMzpYQHZFgvW7zkiA2wToEalQ==", null, false, null, false, "D8E5F8D4-09DE-42FA-9952-37AF9BF3EE9B", "nhan@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240501222053");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 22, 20, 53, 641, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 22, 20, 53, 641, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240501222053");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240501222053");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "59bcc293-8a3c-4a64-ad29-8608b8c1988a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "31c4d1c4-f999-4011-b21b-cb3620390e3c");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber", "UserCode" },
                values: new object[] { "B03DE8D3-DFD7-4A25-B081-20FB1696DB22", "Ký túc xá A, Trường Đại học Cần Thơ", null, "Huỳnh Yến Nhung", "098769876", "B1914237" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[] { new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4"), 0, "d3d513a8-403b-4120-a9a6-3798c874b872", null, false, false, null, "NHUNG@GMAIL.COM", "NHUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEG9CsLuQmQWY3Np/NtOn07SM8Jk1PplYMwKgJU5pD5pudxCvqBWoFguHr1UuveJYuQ==", null, false, null, false, "B03DE8D3-DFD7-4A25-B081-20FB1696DB22", "nhung@gmail.com" });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 13, "id", "5bb18865-b42e-4ef0-844f-9ac649ab1732", new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732") },
                    { 14, "email", "linh@gmail.com", new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732") },
                    { 15, "roles", "User", new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732") },
                    { 16, "id", "d1f58d0a-78fc-4564-8642-3b63d71763ac", new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac") },
                    { 17, "email", "nhan@gmail.com", new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac") },
                    { 18, "roles", "User", new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac") },
                    { 19, "id", "d1f58d0a-78fc-4564-8642-3b63d71763ac", new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4") },
                    { 20, "email", "nhung@gmail.com", new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4") },
                    { 21, "roles", "User", new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "B03DE8D3-DFD7-4A25-B081-20FB1696DB22");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(4598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(3345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(2827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e576aae-3391-455e-96d9-940794742cda", "AQAAAAEAACcQAAAAEIkjH6qFlzAuDy9Q+SgtIq78Sn27kCIKsFi8QXn8cgtucL5QMVjHTEi5TDy+Crz94Q==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "369b4890-1389-45f0-8500-7976688c5afe", "AQAAAAEAACcQAAAAEI9EouqvlJTpVqMNw8L+QX1AoRU2clf6fEy6v/TcjjqJafnqcw3I1NidOOl/CVVLLQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "040eacf3-989a-4339-8686-b05b88b6647f", "AQAAAAEAACcQAAAAEDoZT794OWD13zlFp4QpDFVS0MuUU6J3RxZhoin4Jd/tL0BWxptMCc8iQ5KesPoi/w==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6429818-8f41-473e-a6a2-8e5396c3bb04", "AQAAAAEAACcQAAAAEIHmELRo8xhTPTEdjN3lQ+OM1Acj4u96yBb9+wfRkXKuYzVN9ksZqmRMXr5mIQZVgA==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240430151118");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(8842), new DateTime(2024, 4, 30, 15, 11, 18, 832, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1038), new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1038), new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1038), new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1038), new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1038), new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1038), new DateTime(2024, 4, 30, 15, 11, 18, 833, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 11, 18, 841, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 11, 18, 841, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240430151118");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240430151118");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "cddf3448-b7da-4032-8860-6fab79939372");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "ac7e52fa-4213-48dd-b5f0-a2c740e31f9a");
        }
    }
}

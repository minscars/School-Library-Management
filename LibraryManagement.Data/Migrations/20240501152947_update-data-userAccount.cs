using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedatauserAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(2629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(8021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(7614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(58),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1ee8acd-8155-4a35-a389-381f38f9cbf3", "AQAAAAEAACcQAAAAEHd7sAf7ud+A5m8mgX9TfQMqqka7m90012Xm8Iw6sHEwllVJ5k0rIRTv3oMjxaDUOQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "339bf850-6c20-4409-9cdd-f7ccdb2f5d57", "AQAAAAEAACcQAAAAEKza1krfuSlvErRBGLWocpdz0yZl4fGRZU0AGKFusuQgOyTIjdLgPvZd37HRtSLNfA==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c50cb086-8d0f-46e4-98ce-70fe978533a7", "AQAAAAEAACcQAAAAEMDOaWGwAPM8MOnLPsDKH1heOz6dt5+rO+R1ZgJj10THJTzhQ/fKzHMVvK3y4Ky61Q==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef223f16-fc15-41ba-a5a4-6d1c47373258", "AQAAAAEAACcQAAAAEP3AWx4bN3Nkc24iRWaHxJL7/+tVwSOH1dDDym88xstVjgK9Y3X0n97cJ7CZmtf96g==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e13fdced-f50b-4c01-83d6-8196cec5ba03", "AQAAAAEAACcQAAAAEF+Xa5+4qbFUr/hXn/R6Q0CKRLP+x2OZ7ijDaH4NtxY/p91PYkYM0s3yVg5n0IzRqw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af7762f9-df9d-4cf6-bc81-9a4bfa27d079", "AQAAAAEAACcQAAAAEDMs/l2HJlZk1p7OdRutQzgTMcjDCemmWFI9UFN8w+Qc3nxz76FEP00U2P3ZuEC0Kg==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1cf5d283-dda5-4026-a124-b1bfc5adcdd8", "AQAAAAEAACcQAAAAECqLr1EPz58SdbR88KMSctZh98O7QxxURn+VOeKpgfoZmtbpIz6XxlskmGg2hMMq8A==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240501222947");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(7614), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(7614), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(7614), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(7614), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(7614), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(7614), new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 22, 29, 47, 456, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 1, 22, 29, 47, 456, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240501222947");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240501222947");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "72e2934d-cd3f-467e-ab8e-7639f44f8c80");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "729f0487-ffd9-4762-b48d-37d8093041b5");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 19,
                column: "ClaimValue",
                value: "5b01ec43-afdc-4117-8212-fe47feb3a5f4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(5474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(1906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 20, 53, 626, DateTimeKind.Local).AddTicks(4938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(58));

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
                keyValue: new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3d513a8-403b-4120-a9a6-3798c874b872", "AQAAAAEAACcQAAAAEG9CsLuQmQWY3Np/NtOn07SM8Jk1PplYMwKgJU5pD5pudxCvqBWoFguHr1UuveJYuQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eaa58219-6ac3-4fe8-a6a3-41b41fd4a6af", "AQAAAAEAACcQAAAAEBWH8IbuT37hNGaIzv3eVchKcFD8nXBDX2fYERjA9JUCq5XDN1CxNU5+8UT4DHFM3w==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96304850-bf02-45c0-af97-8fe5ed3f1c35", "AQAAAAEAACcQAAAAEJIg2YL/PqFs/eP8bRBOLZnuXUU05kqtwa7uJE8pHvMzpYQHZFgvW7zkiA2wToEalQ==" });

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

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 19,
                column: "ClaimValue",
                value: "d1f58d0a-78fc-4564-8642-3b63d71763ac");
        }
    }
}

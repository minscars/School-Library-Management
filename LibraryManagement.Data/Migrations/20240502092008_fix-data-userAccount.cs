using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixdatauserAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(2055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "4462069a-fe27-4666-8612-f04fc80e2913", "KHAB2012213@STUDENT.CTU.EDU.VN", "KHAB2012213@STUDENT.CTU.EDU.VN", "AQAAAAEAACcQAAAAEJ2euWNsTcWtSSB2XYyRHmWOTvlO6HsuujtwAZ2zWRYDda/ElzjghrxClLpG1dVUnQ==", "khab2012213@student.ctu.edu.vn" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3fad0098-6ae7-4e15-a91c-65bfbb1984ad", "AQAAAAEAACcQAAAAEEDP4BBIdu7ItUfbquAWFLluPap7epC+7jiqDk5HHeJECYsPPProu+ZhivvA6s1UIw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "e23f1980-0caf-472b-99d3-468edc910d02", "NHUNGB1914237@STUDENT.CTU.EDU.VN", "NHUNGB1914237@STUDENT.CTU.EDU.VN", "AQAAAAEAACcQAAAAEJeWKdwPT8XF27efA2BqectbNS+vDbv/UYaF4MOFfY68FAqfQjx7h3N6kwAHpoMglQ==", "nhungb1914237@student.ctu.edu.vn" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "1cd7f195-db96-4427-91a2-19fcc9442b05", "LINHB2012223@STUDENT.CTU.EDU.VN", "LINHB2012223@STUDENT.CTU.EDU.VN", "AQAAAAEAACcQAAAAEKmK9Ks07igXr4YR+QMgVIErYqix7eBquKYLySg0CkCjPsd8iRwZjEf786C12qbg1w==", "linhb2012223@student.ctu.edu.vn" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "c34efc1c-9d05-4dcc-990b-f2295f73b14c", "NHANB2012237@STUDENT.CTU.EDU.VN", "NHANB2012237@STUDENT.CTU.EDU.VN", "AQAAAAEAACcQAAAAEFbVqcZgW/2goUvR/9FUtjvM1hz5Ft2JyM47/lkw/0CjPTOEbcVdjCdv1KtrwCET5A==", "nhanb2012237@student.ctu.edu.vn" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "683155e7-dc27-4de3-9d4e-28f51245adea", "THEB2003923@STUDENT.CTU.EDU.VN", "THEB2003923@STUDENT.CTU.EDU.VN", "AQAAAAEAACcQAAAAEHbjQvH4BPqqZJ8gxv3MPVuyLxWyEjBTwD3zF3SsDNSsdPBy/e95YBbdjKvyaRJ4XA==", "theb2003923@student.ctu.edu.vn" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "2874ed0b-8156-44e0-b173-6207d164f7cf", "LAMB1809363@STUDENT.CTU.EDU.VN", "LAMB1809363@STUDENT.CTU.EDU.VN", "AQAAAAEAACcQAAAAEAaBxkpeupOzl6QLBmGDK/s95CtVHILSYcf36aiMCKDSu6dxV91uXf8vjntHKmGcBQ==", "lamb1809363@student.ctu.edu.vn" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240502162008");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8967), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8967), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8967), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8967), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8967), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8967), new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 16, 20, 8, 132, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 16, 20, 8, 132, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240502162008");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240502162008");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "29f7cbea-45ec-4dba-bac3-acee8f41ad89");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "f7eaedaf-110d-4d15-87a5-ee5c5e9aa176");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "ClaimValue",
                value: "khab2012213@student.ctu.edu.vn");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "ClaimValue",
                value: "lamb1809363@student.ctu.edu.vn");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "ClaimValue",
                value: "theb2003923@student.ctu.edu.vn");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "ClaimValue",
                value: "linhb2012223@student.ctu.edu.vn");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 17,
                column: "ClaimValue",
                value: "nhanb2012237@student.ctu.edu.vn");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 20,
                column: "ClaimValue",
                value: "nhungb1914237@student.ctu.edu.vn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(8021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(7614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(6024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 434, DateTimeKind.Local).AddTicks(5588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 1, 22, 29, 47, 435, DateTimeKind.Local).AddTicks(58),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "e1ee8acd-8155-4a35-a389-381f38f9cbf3", "KHA@GMAIL.COM", "KHA@GMAIL.COM", "AQAAAAEAACcQAAAAEHd7sAf7ud+A5m8mgX9TfQMqqka7m90012Xm8Iw6sHEwllVJ5k0rIRTv3oMjxaDUOQ==", "kha@gmail.com" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "c50cb086-8d0f-46e4-98ce-70fe978533a7", "NHUNG@GMAIL.COM", "NHUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEMDOaWGwAPM8MOnLPsDKH1heOz6dt5+rO+R1ZgJj10THJTzhQ/fKzHMVvK3y4Ky61Q==", "nhung@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "ef223f16-fc15-41ba-a5a4-6d1c47373258", "LINH@GMAIL.COM", "LINH@GMAIL.COM", "AQAAAAEAACcQAAAAEP3AWx4bN3Nkc24iRWaHxJL7/+tVwSOH1dDDym88xstVjgK9Y3X0n97cJ7CZmtf96g==", "linh@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "e13fdced-f50b-4c01-83d6-8196cec5ba03", "NHAN@GMAIL.COM", "NHAN@GMAIL.COM", "AQAAAAEAACcQAAAAEF+Xa5+4qbFUr/hXn/R6Q0CKRLP+x2OZ7ijDaH4NtxY/p91PYkYM0s3yVg5n0IzRqw==", "nhan@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "af7762f9-df9d-4cf6-bc81-9a4bfa27d079", "THE@GMAIL.COM", "THE@GMAIL.COM", "AQAAAAEAACcQAAAAEDMs/l2HJlZk1p7OdRutQzgTMcjDCemmWFI9UFN8w+Qc3nxz76FEP00U2P3ZuEC0Kg==", "the@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "1cf5d283-dda5-4026-a124-b1bfc5adcdd8", "LAM@GMAIL.COM", "LAM@GMAIL.COM", "AQAAAAEAACcQAAAAECqLr1EPz58SdbR88KMSctZh98O7QxxURn+VOeKpgfoZmtbpIz6XxlskmGg2hMMq8A==", "lam@gmail.com" });

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
                keyValue: 5,
                column: "ClaimValue",
                value: "kha@gmail.com");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "ClaimValue",
                value: "lam@gmail.com");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 11,
                column: "ClaimValue",
                value: "the@gmail.com");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 14,
                column: "ClaimValue",
                value: "linh@gmail.com");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 17,
                column: "ClaimValue",
                value: "nhan@gmail.com");

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 20,
                column: "ClaimValue",
                value: "nhung@gmail.com");
        }
    }
}

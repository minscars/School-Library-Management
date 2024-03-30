using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedmoredataforbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 908, DateTimeKind.Local).AddTicks(1769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 908, DateTimeKind.Local).AddTicks(664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 908, DateTimeKind.Local).AddTicks(2540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 908, DateTimeKind.Local).AddTicks(118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df39f1e9-e944-40f5-b42e-51f710eb7215", "AQAAAAEAACcQAAAAEEab25A3pUntLOEv/BssBKFgcN8pZ6dZo5E5iv6FrUHW4y/lQJAKKutObRufZU5Bgw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92d79ecf-56e9-4d55-8a2a-5657b59d049b", "AQAAAAEAACcQAAAAEMUvQkdldZnOi/YkHQMDQ9eQYyWdNmlNEh21DKW0X5uB6pkbWp2FoHjUsq6li+5W3w==" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "A003", "Nguyễn Công Danh" },
                    { "A004", "Trần Cao Đệ" },
                    { "A005", "Huỳnh Xuân Hiệp" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 22, 12, 19, 908, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: "2E6E1A12-7B56-4288-AB5E-1381BD5902CA",
                column: "Code",
                value: "BD20240228221219");

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240228221219");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Giáo trình" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 22, 12, 19, 912, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 22, 12, 19, 912, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240228221219");

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[] { "E1B5B1AB-69C9-4D5A-8148-3823605D855A", "Nhà xuất bản Đại học Cần Thơ" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "8ef9666b-0786-4492-968d-9a291749b1e3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "f63ba6d5-dba2-4d4a-95a5-d285df5caa85");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { "3ECC8999-CAEA-4C31-9A0E-37FF9158427E", 6, "Đảm bảo chất lượng phần mềm" });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { "A003", "3ECC8999-CAEA-4C31-9A0E-37FF9158427E" },
                    { "A004", "3ECC8999-CAEA-4C31-9A0E-37FF9158427E" }
                });

            migrationBuilder.InsertData(
                table: "PublishedBooks",
                columns: new[] { "Id", "BookId", "Code", "Description", "Image", "Pages", "PublishedYear", "PublisherId" },
                values: new object[] { "FB51AB25-2788-4B0E-996E-2A68282B2C88", "3ECC8999-CAEA-4C31-9A0E-37FF9158427E", "PB20240228221219", null, "giaotrinhdbclpm.png", 312, 2012, "E1B5B1AB-69C9-4D5A-8148-3823605D855A" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "A005");

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { "A003", "3ECC8999-CAEA-4C31-9A0E-37FF9158427E" });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { "A004", "3ECC8999-CAEA-4C31-9A0E-37FF9158427E" });

            migrationBuilder.DeleteData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "A003");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "A004");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E");

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: "E1B5B1AB-69C9-4D5A-8148-3823605D855A");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(5238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 908, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(4451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 908, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 907, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(5835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 908, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(3952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 22, 12, 19, 908, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "94c8c6ed-9106-4aa7-95a4-f354aff00be7", "AQAAAAEAACcQAAAAEEJCHUF8pkXaqawLVTV9PcACre2c9VxEMDZGSoYynmZOf8xgmVU+6J1GKG0BFcr7pQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa1c9af1-a763-40d7-ae39-55c558ce3d72", "AQAAAAEAACcQAAAAEM8C4rCulesDQWh2+3PaA4rHLGVonBt8m9ZVqSDcNS+f3WvR4tG927PwWR15+WvQ7g==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: "2E6E1A12-7B56-4288-AB5E-1381BD5902CA",
                column: "Code",
                value: "BD20240228002453");

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240228002453");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 0, 24, 53, 688, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 0, 24, 53, 688, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240228002453");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "235e2396-2b8e-402f-b504-ba8be06f52b8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "3e1cbb83-7c29-4400-ad78-ea7d59e56638");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class alltalbesremain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(5238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(4451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(5835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(3952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(7365));

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

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "A001", "Đặng Hoàng Giang" },
                    { "A002", "Higashino Keigo" }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "Image", "Title", "UpdatedDate", "UserAccountId" },
                values: new object[] { "BF001", "Test", "Test", "Test", null, new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tiểu thuyết" },
                    { 2, "Sách tâm lý" },
                    { 3, "Sách khoa học" },
                    { 4, "Từ điển" },
                    { 5, "Sách văn học" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1712E51B-0E16-41AC-8CC4-28BCDFCA9A98", "Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh" },
                    { "1E81F92D-2DB9-44CA-99B4-980B51D1E0C7", "Nhà xuất bản Trường Đại học Cần Thơ" },
                    { "4D9FF82E-2B49-47D8-B5ED-43FEE479883D", "Nhà xuất bản Kim Đồng" },
                    { "A1D207B4-F571-4447-8FE0-E00B2F2D2724", "Nhà xuất bản Hội Nhà Văn" },
                    { "B1049AEC-30EA-4C8C-8DCC-D35F3AC17C90", "Nhà xuất bản Trẻ" },
                    { "F28F2290-EE06-4831-9091-8124FE61DFB9", "Nhà xuất bản Lao động" }
                });

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

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { "0E9B5F1B-0C7B-4093-9559-D3A7FE380832", 2, "Tìm mình trong thế giới hậu tuổi thơ" },
                    { "34824C95-72D2-4861-A552-75BAC6F9508F  ", 2, "Rồi một ngày cuộc sống hóa hư vô" },
                    { "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB", 4, "Từ điển tiếng Việt" },
                    { "507C99E1-1586-43C1-8831-E7B499C08EE0", 3, "Sapien lược sử loài người" },
                    { "90B5054A-9A37-4249-B1A1-209FFC7AE80D", 1, "Điều kỳ diệu của tiệm tạp hóa Namiya" },
                    { "A7A7CFF3-5B28-4921-9F06-599A3B14A776", 3, "Thần số học" },
                    { "ABF7E859-5FBA-4C19-B842-B442062C8909", 3, "Lược sử Trái Đất" },
                    { "AFE53773-D1B3-462D-B27E-8D37C1138639", 1, "Quán ăn nơi góc hẻm" },
                    { "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D", 5, "Đất rừng phương nam" },
                    { "B575681C-AD00-49E9-B85E-82F738439CBF", 4, "Từ điển Hán Việt" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BlogId", "Content", "CreatedDate", "ReplyCommentId", "UserAccountId" },
                values: new object[] { 1, "BF001", "Test", new DateTime(2024, 2, 28, 0, 24, 53, 688, DateTimeKind.Local).AddTicks(4914), null, new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[] { "A001", "0E9B5F1B-0C7B-4093-9559-D3A7FE380832" });

            migrationBuilder.InsertData(
                table: "PublishedBooks",
                columns: new[] { "Id", "BookId", "Code", "Description", "Image", "Pages", "PublishedYear", "PublisherId" },
                values: new object[] { "7F33BDA5-7C2B-447A-89E3-DC670ACC3646", "0E9B5F1B-0C7B-4093-9559-D3A7FE380832", "PB20240228002453", null, "1.png", 404, 2020, "A1D207B4-F571-4447-8FE0-E00B2F2D2724" });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "Id", "Code", "IsAvailable", "PublishedBookId" },
                values: new object[] { "2E6E1A12-7B56-4288-AB5E-1381BD5902CA", "BD20240228002453", false, "7F33BDA5-7C2B-447A-89E3-DC670ACC3646" });

            migrationBuilder.InsertData(
                table: "BookRequests",
                columns: new[] { "Id", "ApprovedTime", "BookCheckoutId", "BorrowedTime", "CanceledTime", "Code", "CreatedTime", "DueTime", "IsDeleted", "PublishedBookId", "ReceivedTime", "RejectedTime", "ReturnedTime", "Status", "UserAccountId" },
                values: new object[] { "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB", null, null, null, null, "BR20240228002453", null, null, false, "7F33BDA5-7C2B-447A-89E3-DC670ACC3646", null, null, null, 3, new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") });

            migrationBuilder.InsertData(
                table: "FeedBacks",
                columns: new[] { "Id", "Content", "CreatedDate", "PublishedBookId", "Rate", "UserAccountId" },
                values: new object[] { 1, "Test", new DateTime(2024, 2, 28, 0, 24, 53, 688, DateTimeKind.Local).AddTicks(4927), "7F33BDA5-7C2B-447A-89E3-DC670ACC3646", 5, new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "A002");

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { "A001", "0E9B5F1B-0C7B-4093-9559-D3A7FE380832" });

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "Id",
                keyValue: "2E6E1A12-7B56-4288-AB5E-1381BD5902CA");

            migrationBuilder.DeleteData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: "1712E51B-0E16-41AC-8CC4-28BCDFCA9A98");

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: "1E81F92D-2DB9-44CA-99B4-980B51D1E0C7");

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: "4D9FF82E-2B49-47D8-B5ED-43FEE479883D");

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: "B1049AEC-30EA-4C8C-8DCC-D35F3AC17C90");

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: "F28F2290-EE06-4831-9091-8124FE61DFB9");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "A001");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832");

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: "A1D207B4-F571-4447-8FE0-E00B2F2D2724");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(8417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(7707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(6545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(6363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(3512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(3334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 684, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "BookCheckouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(8967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 0, 16, 34, 169, DateTimeKind.Local).AddTicks(7365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 0, 24, 53, 685, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3d9a8f3-2150-4b6b-a199-049d4c14776c", "AQAAAAEAACcQAAAAEIoHbTmYB9oIPeacADuokeSxpEM1pTP6/cpUL2ecaf27hyrzlss/51faEGB1HdALcQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "933ed77f-2f27-4223-a06f-11a3b696f2eb", "AQAAAAEAACcQAAAAEOSecR9NDWvwufbkKGy1kPBpMTUE/mQC066/LGQI8A9D2zuFPe8kOj4bDRVQ/Z+few==" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "0804fd11-179b-4d4a-b544-c765e6ab3e86");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "3d8c78f8-ee28-4e94-88c1-63a121162d27");
        }
    }
}

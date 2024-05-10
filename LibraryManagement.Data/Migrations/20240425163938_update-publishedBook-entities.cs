using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatepublishedBookentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PublishedBooks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(5805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 50, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(4850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(4466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6060d0b3-d698-4fd2-b2f7-79bf721d46ef", "AQAAAAEAACcQAAAAEPeoc+ea9zmN2FMGuYYi2sFpk4XVvMAuSvq9iRpwTvD20LvVGLVKAvNgDv0UoZGHag==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1de8224-957b-40fa-a724-c9915aa3e317", "AQAAAAEAACcQAAAAECTTIT9uqK1Afh3KmykhAKsBCZXVoKAbqAgNTKLV0rMynbXuUgP5DSqVdIoAWtRBYw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6351dbd6-235d-4294-8911-3fb3b7fb83e3", "AQAAAAEAACcQAAAAEKZ33ZRy18kOoLPZyru4PLx7wswtzLV5Ie7UOVbxz+6tFO7MMikS0Vk4RAjzzCa3uA==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6c6ba7df-0f03-421c-b95c-92d8ee080544", "AQAAAAEAACcQAAAAEN+U6OhnrLyfPMcU1E2jgIHtfKpWYo8VQzvCL7i8Yq67sbsJthbaiRyM1NjHAdRpQA==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240425233938");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2645), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2645), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2645), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2645), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2645), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2645), new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 23, 39, 38, 213, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 23, 39, 38, 213, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240425233938");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240425233938");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "ef553d3e-614d-4e03-9a07-d6c969b45dfa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "f6f3539a-ba5e-4edf-819b-1685e02d7670");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PublishedBooks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 50, DateTimeKind.Local).AddTicks(309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(9061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(8508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ad27b5a-2738-4166-9b76-36995e4aad3b", "AQAAAAEAACcQAAAAEIMvBGX8FR7ck5bduJWtk9XXmuNOxi1Gw+74R+fOKocpJX2hSqPw38YrRj5wIbhpyQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8647bfaf-9dfa-48fd-a3a1-07f8e28140dc", "AQAAAAEAACcQAAAAEIzjGLz1i92YEl67ozhGw1Mt5p2PmIwEdPthBUR696MRq8FQq9N/bYlOKUWGg7zfhg==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44ac635c-b6b5-4161-93cd-35555b28e5ca", "AQAAAAEAACcQAAAAELHQ+QxOJICbmjJRUFUbVaeIMcymjzR7Fuv0EBeviHPvJWadh+U7V7Thk4o7nmH+Sw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46609a69-21dd-48e4-bad8-6aa81901fcfb", "AQAAAAEAACcQAAAAEB81gf7vlWIgoQ/bX1nqq2N8vZkRkqmqm9uBOyTzfJP3qyflF5jFLbfSd7jsCYOStA==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240425160835");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 4, 25, 16, 8, 35, 49, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 8, 35, 58, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 16, 8, 35, 58, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                columns: new[] { "Code", "Description" },
                values: new object[] { "PB20240425160835", null });

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                columns: new[] { "Code", "Description" },
                values: new object[] { "PB20240425160835", null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "977c3697-1875-48bc-a81d-f0c3ae6f4b0c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "a9761f07-9ad7-46ed-a9a1-e8748a14b2bd");
        }
    }
}

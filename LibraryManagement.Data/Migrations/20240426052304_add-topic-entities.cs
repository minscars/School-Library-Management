using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class addtopicentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(7838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(6879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(6506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.AddColumn<string>(
                name: "TopicId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbc6fb88-8707-4945-bd49-eb2322420a18", "AQAAAAEAACcQAAAAEIJFWROYqgxsqYSHpGbU7ylVhpPzGkbLiLlzLWcV+GHwp0IO/o2PVDABCdxRHXpS6Q==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e49b1598-1715-4212-81c8-2912457d1f3e", "AQAAAAEAACcQAAAAEJjYxzOQISfLvR9TeYRkShccHpYphV7nrI4y9w4ySogIwOHm6CxmmZsgMs956grFOg==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03f38d6d-8998-4683-ada0-4795f933dd4e", "AQAAAAEAACcQAAAAEGikyGAATpEcjwLxbyOCNlqx3YbUjrY0+B5HM44+HG41JdiGOKsrRyespAE6hZToSg==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0485474-2051-456c-ae10-a0f88a96a9f0", "AQAAAAEAACcQAAAAEJZ/AQSWzzxzlkrBMQ/wdQdc2zvvF2XwDtZssoYuj+SS/fn9HDKzlZO8hfrGR2DpBg==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                columns: new[] { "CreatedDate", "TopicId" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(6506), "3A1C8B8E-33AB-4DB7-826F-D58C8DF82C88" });

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240426122304");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4584), new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 23, 4, 295, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 12, 23, 4, 295, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240426122304");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240426122304");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "aad1ca5e-bada-4abf-9071-8f9558698f77");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "ae102f63-3685-4010-a811-9bd104f5d429");

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedTime", "IsDeleted", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { "3A1C8B8E-33AB-4DB7-826F-D58C8DF82C88", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Lập trình", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "D2AB6BB4-0A82-4D2C-B70E-03DD1C3BE23D", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Phỏng vấn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_TopicId",
                table: "Blogs",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Topics_TopicId",
                table: "Blogs",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Topics_TopicId",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_TopicId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Blogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(5805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(4850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(2645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(1588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 25, 23, 39, 38, 206, DateTimeKind.Local).AddTicks(4466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 26, 12, 23, 4, 286, DateTimeKind.Local).AddTicks(6506));

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
    }
}

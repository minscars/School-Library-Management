using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatebookRequetsentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 721, DateTimeKind.Local).AddTicks(481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 912, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(9235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 911, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.AddColumn<bool>(
                name: "IsExtended",
                table: "BookRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(8726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 911, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9b9fd8f-4a58-4f68-ba59-50ab7c6bd493", "AQAAAAEAACcQAAAAENGjd9vWcx7eskGUInfV0UCEOb5SSivP+9mGoLs/vZonlBynvkYI7SCYOIbYNq1Acg==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "340e1db4-051c-4815-b19d-d4fc310efeb9", "AQAAAAEAACcQAAAAEAfpOLDIZ/FeEQxutV5fxPTndqtJNCBHPPtt6EGVDKW0xMrwXCdD7BWR5ysa2zocSA==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5d0780c-7ab8-4c16-97e9-e9a062c62636", "AQAAAAEAACcQAAAAEH6GrrC59MwnaWemhvUukY+jGKBNsBE1CTyj+BbaFN5uZHDu/uIqUR3gZnk8BdqpsQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9fec500-8b3a-4754-9a45-b5e8f9627634", "AQAAAAEAACcQAAAAEN1GQnc+k1+tgYkK7Do6VWh1VsIj232GGLcDY0jLmtrqyqPqb5cdYB+lborFK6KnzA==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f77ae66d-f8eb-4e9f-b853-0fa7698391ad", "AQAAAAEAACcQAAAAEMd2ylwI7ngnmkKe3STiSWbn15IZ7shmyJCCJcD01s2+OYbQWLQyP+fOWlejUgsuYw==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "121618c5-4f65-4e67-ae10-0c6eda8564d1", "AQAAAAEAACcQAAAAEIisHHSh7bL3SzQgPwnufS9x56i4dsZJ8RRhZTCBnQlnhLkGxepaRaTCxOp36go7GQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f02526db-22dc-4bc1-a8e7-1a5afeb63f2b", "AQAAAAEAACcQAAAAEOXWcwFZCXCMr56o6tI1JTOmK9LrSz2ZnBG2zJ8KX1V36rOlae9sNlZojsojqR30Zw==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                columns: new[] { "Code", "IsExtended" },
                values: new object[] { "BR20240509224203", false });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 22, 42, 3, 732, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 9, 22, 42, 3, 732, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240509224203");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240509224203");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "fc732407-4445-4ae5-9411-c696d6c6f44a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "1c353de0-babd-40bb-a825-59faa88dd280");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExtended",
                table: "BookRequests");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 912, DateTimeKind.Local).AddTicks(246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 721, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 911, DateTimeKind.Local).AddTicks(5440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(8250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(7199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 911, DateTimeKind.Local).AddTicks(3530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 9, 22, 42, 3, 720, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eaede279-78ed-4850-a1af-a6e61c0ff4b1", "AQAAAAEAACcQAAAAENyzGOw28mZBUq5+7lKBbr/Qt/R9p2SRLFN4qTrIx01So7cmshrJhcDr2S7B/R+f7w==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c983698-390c-4428-bba2-809cec92d022", "AQAAAAEAACcQAAAAEKDVWtwsk0jhNu5laGoYhdtUPzsSXe7YQALiBYz1+oppABIjIO+e0nREMjTyw6B1wQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "262f960e-1664-44e5-9a1a-5eb7aeb1370a", "AQAAAAEAACcQAAAAEPAK3exHJCxwhSk8IRzseXVE+cjHW9GpA0wKbt9w9Hsgz4Xn/A2YD60RGFlPMwIKWA==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d375266d-e866-423f-8b82-5ad7a0288107", "AQAAAAEAACcQAAAAEKVyvleCddF54rwdSUVIivnXO/mvuymM//KuV1zX2dQPs7e290cvd6vohEJLUxXiLg==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8448126b-14ad-454e-a13a-922da38f4e48", "AQAAAAEAACcQAAAAEInnd6u+iXoNgXq0JgfaWOWsXqWFlZVS4j5ixCXhZAX3XfJhXOjK+zZmTFymo1E1oA==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "254487bc-0382-4422-bb49-39295ff7b62a", "AQAAAAEAACcQAAAAEMJ6J9d3nkbDBfK4H+lVQ5oTOaOnDxNJDrDj5acqu7r2uthHtrRabVxDd9X57KLdpA==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10b4d7bf-38a3-4305-b242-aaa287e1c97a", "AQAAAAEAACcQAAAAEMeekQH0rcyinkqy2JXq0s49Hx+8JYiRWbUQZx3HfSQ0/CtpcmAu6F0DwnQA7w8W/Q==" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: "BF001",
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 22, 11, 4, 911, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "BookRequests",
                keyColumn: "Id",
                keyValue: "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                column: "Code",
                value: "BR20240507221104");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "507C99E1-1586-43C1-8831-E7B499C08EE0",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "ABF7E859-5FBA-4C19-B842-B442062C8909",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "AFE53773-D1B3-462D-B27E-8D37C1138639",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "B575681C-AD00-49E9-B85E-82F738439CBF",
                columns: new[] { "CreatedTime", "UpdatedTime" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 22, 11, 4, 971, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "FeedBacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 22, 11, 4, 971, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                column: "Code",
                value: "PB20240507221104");

            migrationBuilder.UpdateData(
                table: "PublishedBooks",
                keyColumn: "Id",
                keyValue: "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                column: "Code",
                value: "PB20240507221104");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"),
                column: "ConcurrencyStamp",
                value: "a620d55f-9dcd-4f4d-9ab9-a99ef4982440");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"),
                column: "ConcurrencyStamp",
                value: "1a5107cb-4d08-4143-8529-e66c8982ea78");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateadminaccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FeedBacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 912, DateTimeKind.Local).AddTicks(246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 911, DateTimeKind.Local).AddTicks(5440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(8250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(7199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 911, DateTimeKind.Local).AddTicks(3530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(420));

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "0c983698-390c-4428-bba2-809cec92d022", "johnminscarslbm@gmail.com", "JOHNMINSCARSLBM@GMAIL.COM", "JOHNMINSCARSLBM@GMAIL.COM", "AQAAAAEAACcQAAAAEKDVWtwsk0jhNu5laGoYhdtUPzsSXe7YQALiBYz1+oppABIjIO+e0nREMjTyw6B1wQ==", "johnminscarslbm@gmail.com" });

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

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "johnminscarslbm@gmail.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 912, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 911, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(8051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 910, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 119, DateTimeKind.Local).AddTicks(7782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 909, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 2, 16, 20, 8, 120, DateTimeKind.Local).AddTicks(420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 7, 22, 11, 4, 911, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2a738bf3-a14b-488e-b04e-17f918e8d6a4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4462069a-fe27-4666-8612-f04fc80e2913", "AQAAAAEAACcQAAAAEJ2euWNsTcWtSSB2XYyRHmWOTvlO6HsuujtwAZ2zWRYDda/ElzjghrxClLpG1dVUnQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("372ea575-2536-4076-9bab-3e3138de495f"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "3fad0098-6ae7-4e15-a91c-65bfbb1984ad", "admin@gmail.com", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEDP4BBIdu7ItUfbquAWFLluPap7epC+7jiqDk5HHeJECYsPPProu+ZhivvA6s1UIw==", "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5b01ec43-afdc-4117-8212-fe47feb3a5f4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e23f1980-0caf-472b-99d3-468edc910d02", "AQAAAAEAACcQAAAAEJeWKdwPT8XF27efA2BqectbNS+vDbv/UYaF4MOFfY68FAqfQjx7h3N6kwAHpoMglQ==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5bb18865-b42e-4ef0-844f-9ac649ab1732"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1cd7f195-db96-4427-91a2-19fcc9442b05", "AQAAAAEAACcQAAAAEKmK9Ks07igXr4YR+QMgVIErYqix7eBquKYLySg0CkCjPsd8iRwZjEf786C12qbg1w==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d1f58d0a-78fc-4564-8642-3b63d71763ac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c34efc1c-9d05-4dcc-990b-f2295f73b14c", "AQAAAAEAACcQAAAAEFbVqcZgW/2goUvR/9FUtjvM1hz5Ft2JyM47/lkw/0CjPTOEbcVdjCdv1KtrwCET5A==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e9077d-d904-4c9e-860e-7c0373cfddff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "683155e7-dc27-4de3-9d4e-28f51245adea", "AQAAAAEAACcQAAAAEHbjQvH4BPqqZJ8gxv3MPVuyLxWyEjBTwD3zF3SsDNSsdPBy/e95YBbdjKvyaRJ4XA==" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f5aa72ea-a563-4e89-a289-e290814f3c17"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2874ed0b-8156-44e0-b173-6207d164f7cf", "AQAAAAEAACcQAAAAEAaBxkpeupOzl6QLBmGDK/s95CtVHILSYcf36aiMCKDSu6dxV91uXf8vjntHKmGcBQ==" });

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
                keyValue: 2,
                column: "ClaimValue",
                value: "admin@gmail.com");
        }
    }
}

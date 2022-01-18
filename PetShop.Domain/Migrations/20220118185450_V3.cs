using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Domain.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1020670a-1f84-4ab7-bc0e-00d4c1d068cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1eb48ed3-fac8-48f3-8d7b-de0d6c77dcb7");

            migrationBuilder.AlterColumn<string>(
                name: "ImageAddress",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8dae7960-5891-4af7-a175-22d176e11047", "bc1312f4-a754-4674-983f-bc0586ccb349", "Admin", "ADMIN" },
                    { "d992637c-998b-435b-be8f-1588ab401417", "0d041cbf-fdeb-406e-86b3-06c11e2a1e85", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 1, 18, 22, 24, 50, 27, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 1, 18, 22, 24, 50, 27, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 1, 18, 22, 24, 50, 27, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 1, 18, 22, 24, 50, 27, DateTimeKind.Local).AddTicks(1498));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dae7960-5891-4af7-a175-22d176e11047");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d992637c-998b-435b-be8f-1588ab401417");

            migrationBuilder.AlterColumn<string>(
                name: "ImageAddress",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1020670a-1f84-4ab7-bc0e-00d4c1d068cd", "983bf983-2fcb-47f6-bf37-f3fd5bfd74b9", "User", "USER" },
                    { "1eb48ed3-fac8-48f3-8d7b-de0d6c77dcb7", "4e561f18-3de8-4b20-81c3-33a29669a120", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 1, 17, 19, 33, 10, 527, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 1, 17, 19, 33, 10, 527, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 1, 17, 19, 33, 10, 527, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 1, 17, 19, 33, 10, 527, DateTimeKind.Local).AddTicks(1047));
        }
    }
}

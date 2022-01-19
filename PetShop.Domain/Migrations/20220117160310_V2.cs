using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Domain.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1020670a-1f84-4ab7-bc0e-00d4c1d068cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1eb48ed3-fac8-48f3-8d7b-de0d6c77dcb7");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 1, 16, 21, 47, 37, 395, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 1, 16, 21, 47, 37, 395, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 1, 16, 21, 47, 37, 395, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 1, 16, 21, 47, 37, 395, DateTimeKind.Local).AddTicks(1893));
        }
    }
}

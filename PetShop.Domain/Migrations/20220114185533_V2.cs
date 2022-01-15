using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Domain.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "City", "Email", "FirstName", "IsActive", "LastName", "Password", "PhoneNumber", "Street" },
                values: new object[] { 1, 23, "Tehran", "mamad@mamad.mamad", "Mamad", true, "Khani", "123", "09190777620", "Jeyhun" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Category", "City", "DateAdded", "Description", "ImageAddress", "IsActive", "Name", "Price", "UserId" },
                values: new object[] { 1, 2, "Husky", 1, "Tehran", new DateTime(2022, 1, 14, 22, 25, 32, 860, DateTimeKind.Local).AddTicks(4164), "A good boy", "https://barkingroyalty.com/wp-content/uploads/2016/02/Alaskan-Malamutes.jpg", true, "Stanley", "100", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

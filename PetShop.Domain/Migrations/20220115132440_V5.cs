using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop.Domain.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2022, 1, 15, 16, 54, 40, 746, DateTimeKind.Local).AddTicks(1463), "Playful and Lazy at the same time!" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Category", "City", "DateAdded", "Description", "Gender", "ImageAddress", "IsActive", "Name", "Price", "UserId" },
                values: new object[] { 2, 7, "Catahoula Leopard", 1, "Tehran", new DateTime(2022, 1, 15, 16, 54, 40, 746, DateTimeKind.Local).AddTicks(1520), "A *Very* polite gentleman", 0, "https://barkingroyalty.com/wp-content/uploads/2021/09/catahoula-leopard-dog.jpg", true, "Jackey", "0", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mhkhk@outlook.com", "Mohammad Hassan", "Khanipour" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "City", "Email", "FirstName", "IsActive", "LastName", "Password", "PhoneNumber", "Street" },
                values: new object[,]
                {
                    { 2, 29, "Shiraz", "h.kargar71@gmail.com", "Hossein", true, "Kargar", "456", "09357105475", "Shams" },
                    { 3, 23, "Pardis", "zeidimehran@gmail.com", "Mehran", true, "Zeidi", "789", "09386716209", "Mirzaee" },
                    { 4, 22, "Tehran", "mehdinaderi@gmail.com", "Mehdi", true, "Naderi", "135", "09225129985", "Piruzi" }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Category", "City", "DateAdded", "Description", "Gender", "ImageAddress", "IsActive", "Name", "Price", "UserId" },
                values: new object[] { 3, 2, "Domestic Medium-hair", 2, "Pardis", new DateTime(2022, 1, 15, 16, 54, 40, 746, DateTimeKind.Local).AddTicks(1531), "Snufkin is an affectionate, friendly lady who enjoys the quieter life (who doesn't?).", 1, "https://www.battersea.org.uk/sites/default/files/animal_images/00P8e000001EdwGEAS.jpeg", true, "Snufkin", "2000", 3 });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "Category", "City", "DateAdded", "Description", "Gender", "ImageAddress", "IsActive", "Name", "Price", "UserId" },
                values: new object[] { 4, 2, "Mastiff: Bull", 1, "Shiraz", new DateTime(2022, 1, 15, 16, 54, 40, 746, DateTimeKind.Local).AddTicks(1538), "Maisie is a young Bull breed full of energy and affection who is looking for a family who have experience with high energy dogs that require time, patience, and dedication towards their training. She is still developing and learning but has picked up some fantastic skills during her stay at Battersea Old Windsor. She has responded brilliantly to clicker training and this is being used to help her be a little calmer around other dogs.", 1, "https://www.battersea.org.uk/sites/default/files/animal_images/00P8e000001EdbrEAC.jpeg", true, "Maisie", "2000", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2022, 1, 15, 14, 40, 26, 828, DateTimeKind.Local).AddTicks(9649), "A good boy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "mamad@mamad.mamad", "Mamad", "Khani" });
        }
    }
}

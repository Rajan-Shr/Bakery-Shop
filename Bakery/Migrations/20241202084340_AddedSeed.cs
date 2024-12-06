using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bakery.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Products",
                newName: "ImageFileName");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A scrumptious carrot cake encrusted with sliced almonds", "carrot-cake.jpg", "Carrot Cake", 8.99m },
                    { 2, "A delicious lemon tart smothered with juicy fresh fruit", "lemon-tart.jpg", "Lemon Tart", 9.99m },
                    { 3, "Delectable vanilla and chocolate cupcakes", "cup-cakes.jpg", "Cupcakes", 5.99m },
                    { 4, "Fresh baked French-style bread, bagettes and cobs", "bread.jpg", "Bread", 2.49m },
                    { 5, "Deliciously chewy freshly made New York-style bagels.", "bagels.jpg", "Bagels", 5.99m },
                    { 6, "Rich chocolate frosting cover this chocolate lover's dream", "chocolate-cake.jpg", "Chocolate Cake", 8.99m },
                    { 7, "Fudgy, gooey and super chocolaty with a crispy top", "brownie.jpg", "Brownies", 5.99m },
                    { 8, "Sweet, light, airy and perfect with your afternoon tea", "buns.jpg", "Sweet Buns", 3.49m },
                    { 9, "Creamy and vibrant lemon cheesecake made with organic lemons", "cheesecake.jpg", "Cheesecake", 2.49m },
                    { 10, "Crisp on the outside, soft on the inside and full of chocolate chips", "chocolate-chip.jpg", "Chocolate Cookies", 3.49m },
                    { 11, "Big, fluffy, soft and delicious with warming cinnamon", "cinnamon-roll.jpg", "Cinnamon Rolls", 3.99m },
                    { 12, "Flaky and buttery, perfect for savoury or sweet", "croissant.jpg", "Croissants", 3.49m },
                    { 13, "Traditional ring doughnuts with a variety of toppings", "doughnuts.jpg", "Doughnuts", 5.49m },
                    { 14, "Packed full with ony the juiciest, plumpest fruit", "fruit-loaf.jpg", "Fruit Loaf", 8.49m },
                    { 15, "Light pastry with a selection of the freshest fruit", "fruit-tart.jpg", "Fruit Tart", 6.49m },
                    { 16, "Zingy lemon on a light pastry covered with light clouds of meringue", "lemon-meringue.jpg", "Lemon Meringue", 10.99m },
                    { 17, "Tiny, delicate meringue pillows with a variety of fillings", "macaron.jpg", "Macaron", 9.99m },
                    { 18, "The lighest pastry shot through with top quality chocolate", "pain-au-chocolate.jpg", "Pain Au Chocolate", 4.49m },
                    { 19, "A meaty treat based on traditional Cornish recipes", "pasty.jpg", "Cornish Pasty", 5.99m },
                    { 20, "Our top quality loaves sliced for your convenience", "sliced-bread.jpg", "Sliced Bread", 2.49m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.RenameColumn(
                name: "ImageFileName",
                table: "Products",
                newName: "ImageName");
        }
    }
}

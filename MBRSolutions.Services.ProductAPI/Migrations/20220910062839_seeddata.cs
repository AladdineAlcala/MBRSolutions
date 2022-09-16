using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MBRSolutions.Services.ProductAPI.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ImageUrl", "Price", "Prod_Desc", "Prod_Name" },
                values: new object[,]
                {
                    { 1, "https://www.pexels.com/photo/black-fujifilm-dslr-camera-90946/", 162.0, "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.", "Product One" },
                    { 2, "https://www.pexels.com/photo/woman-wearing-gold-pendant-necklace-8703414/", 112.0, "Since some online shoppers only scan text on websites, it might be helpful to use bullet points that cover the most important product details. Bullet points should generally be used for specs (like dimensions) or short phrases (like features) so they are quick and easy to read.", "Product Two" },
                    { 3, "https://www.pexels.com/photo/black-and-gray-pentax-bridge-camera-on-white-surface-821651/", 132.0, "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.", "Product Three" },
                    { 4, "https://www.pexels.com/photo/basket-blur-celebration-ceremony-265791/", 312.0, "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.", "Product Four" },
                    { 5, "https://www.pexels.com/photo/hands-with-rings-5565/", 512.0, "This is your opportunity to be a little creative and establish a voice (personality and tone) for your brand. Just imagine you’re at a party, telling someone you’ve just met about the product. How would you describe it so that they would understand how great it truly is?", "Product Five" },
                    { 6, "https://www.pexels.com/photo/silver-colored-ring-in-box-298852/", 132.0, "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.", "Product Six" },
                    { 7, "https://www.pexels.com/photo/person-holding-gold-colored-bird-pendant-necklace-59662/", 162.0, "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.", "Product Seven" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);
        }
    }
}

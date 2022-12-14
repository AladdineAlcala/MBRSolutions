// <auto-generated />
using MBRSolutions.Services.ProductAPI.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MBRSolutions.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ProductDBContext))]
    partial class ProductDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MBRSolutions.Services.ProductAPI.Model._DTO.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Prod_Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prod_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ImageUrl = "https://www.pexels.com/photo/black-fujifilm-dslr-camera-90946/",
                            Price = 162m,
                            Prod_Desc = "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.",
                            Prod_Name = "Product One"
                        },
                        new
                        {
                            ProductId = 2,
                            ImageUrl = "https://www.pexels.com/photo/woman-wearing-gold-pendant-necklace-8703414/",
                            Price = 112m,
                            Prod_Desc = "Since some online shoppers only scan text on websites, it might be helpful to use bullet points that cover the most important product details. Bullet points should generally be used for specs (like dimensions) or short phrases (like features) so they are quick and easy to read.",
                            Prod_Name = "Product Two"
                        },
                        new
                        {
                            ProductId = 3,
                            ImageUrl = "https://www.pexels.com/photo/black-and-gray-pentax-bridge-camera-on-white-surface-821651/",
                            Price = 132m,
                            Prod_Desc = "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.",
                            Prod_Name = "Product Three"
                        },
                        new
                        {
                            ProductId = 4,
                            ImageUrl = "https://www.pexels.com/photo/basket-blur-celebration-ceremony-265791/",
                            Price = 312m,
                            Prod_Desc = "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.",
                            Prod_Name = "Product Four"
                        },
                        new
                        {
                            ProductId = 5,
                            ImageUrl = "https://www.pexels.com/photo/hands-with-rings-5565/",
                            Price = 512m,
                            Prod_Desc = "This is your opportunity to be a little creative and establish a voice (personality and tone) for your brand. Just imagine you’re at a party, telling someone you’ve just met about the product. How would you describe it so that they would understand how great it truly is?",
                            Prod_Name = "Product Five"
                        },
                        new
                        {
                            ProductId = 6,
                            ImageUrl = "https://www.pexels.com/photo/silver-colored-ring-in-box-298852/",
                            Price = 132m,
                            Prod_Desc = "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.",
                            Prod_Name = "Product Six"
                        },
                        new
                        {
                            ProductId = 7,
                            ImageUrl = "https://www.pexels.com/photo/person-holding-gold-colored-bird-pendant-necklace-59662/",
                            Price = 162m,
                            Prod_Desc = "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.",
                            Prod_Name = "Product Seven"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

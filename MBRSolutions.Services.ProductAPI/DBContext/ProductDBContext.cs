using MBRSolutions.Services.ProductAPI.Model._DTO;
using Microsoft.EntityFrameworkCore;
using System;

namespace MBRSolutions.Services.ProductAPI.DBContext
{
    public class ProductDBContext : DbContext
    {

        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Prod_Name = "Product One",
                Prod_Desc = "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.",
                ImageUrl = "https://www.pexels.com/photo/black-fujifilm-dslr-camera-90946/",
                Price =Convert.ToDecimal(162.00)

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Prod_Name = "Product Two",
                Prod_Desc = "Since some online shoppers only scan text on websites, it might be helpful to use bullet points that cover the most important product details. Bullet points should generally be used for specs (like dimensions) or short phrases (like features) so they are quick and easy to read.",
                ImageUrl = "https://www.pexels.com/photo/woman-wearing-gold-pendant-necklace-8703414/",
                Price = Convert.ToDecimal(112.00)

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Prod_Name = "Product Three",
                Prod_Desc = "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.",
                ImageUrl = "https://www.pexels.com/photo/black-and-gray-pentax-bridge-camera-on-white-surface-821651/",
                Price = Convert.ToDecimal(132.00)

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Prod_Name = "Product Four",
                Prod_Desc = "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.",
                ImageUrl = "https://www.pexels.com/photo/basket-blur-celebration-ceremony-265791/",
                Price = Convert.ToDecimal(312.00)

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Prod_Name = "Product Five",
                Prod_Desc = "This is your opportunity to be a little creative and establish a voice (personality and tone) for your brand. Just imagine you’re at a party, telling someone you’ve just met about the product. How would you describe it so that they would understand how great it truly is?",
                ImageUrl = "https://www.pexels.com/photo/hands-with-rings-5565/",
                Price = Convert.ToDecimal(512.00)

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Prod_Name = "Product Six",
                Prod_Desc = "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.",
                ImageUrl = "https://www.pexels.com/photo/silver-colored-ring-in-box-298852/",
                Price = Convert.ToDecimal(132.00)

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Prod_Name = "Product Seven",
                Prod_Desc = "This can be anything from quality to value to features. Think about the product benefits to your customers and consider how images can complement your product copy.",
                ImageUrl = "https://www.pexels.com/photo/person-holding-gold-colored-bird-pendant-necklace-59662/",
                Price = Convert.ToDecimal(162.00)

            });
        }
    }
}

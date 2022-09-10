using MBRSolutions.Services.ProductAPI.Model._DTO;
using Microsoft.EntityFrameworkCore;

namespace MBRSolutions.Services.ProductAPI.DBContext
{
    public class ProductDBContext : DbContext
    {

        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}

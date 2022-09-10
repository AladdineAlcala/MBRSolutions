namespace MBRSolutions.Services.ProductAPI.Model._DTO
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Desc { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}

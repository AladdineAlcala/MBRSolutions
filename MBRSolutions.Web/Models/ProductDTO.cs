using System.ComponentModel.DataAnnotations;

namespace MBRSolutions.Web.Models
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Desc { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}

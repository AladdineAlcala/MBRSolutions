using MBRSolutions.Services.ProductAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MBRSolutions.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> GetAllProduct();
        Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO);
        Task<ProductDTO> GetProductById(int id);
        Task<bool> DeleteProductById(int id);

    }
}

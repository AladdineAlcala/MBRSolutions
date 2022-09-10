using AutoMapper;
using AutoMapper.Configuration;
using MBRSolutions.Services.ProductAPI.DBContext;
using MBRSolutions.Services.ProductAPI.Model;
using MBRSolutions.Services.ProductAPI.Model._DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBRSolutions.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDBContext _dbcontext;
        private IMapper _mapper;
        public ProductRepository(ProductDBContext dbcontext,IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }
        public async Task<ProductDTO> CreateUpdateProduct(ProductDTO productDTO)
        {
            var product = _mapper.Map<ProductDTO, Product>(productDTO);

            if (product.ProductId > 0)
            {
                _dbcontext.Update(product);
            }
            else
            {
                _dbcontext.Add(product);
            }
            await _dbcontext.SaveChangesAsync();

            return _mapper.Map<Product,ProductDTO>(product);
        }

        public async Task<bool> DeleteProductById(int id)
        {
            try
            {
                var product = await _dbcontext.Products.Where(t => t.ProductId == id).FirstOrDefaultAsync();
                if (product != null)
                {
                    _dbcontext.Remove(product);
                    await _dbcontext.SaveChangesAsync();    
                    return true;
                }
                else
                {
                    return false;  
                }
            }
            catch (System.Exception)
            {

                return false;
            }


        }

        public async Task<IEnumerable<ProductDTO>> GetAllProduct()
        {
            var productList = await _dbcontext.Products.ToListAsync();

            return _mapper.Map<IEnumerable<ProductDTO>>(productList);
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var product = await _dbcontext.Products.Where(t=>t.ProductId==id).FirstOrDefaultAsync();

            return _mapper.Map<ProductDTO>(product);
        }
    }
}

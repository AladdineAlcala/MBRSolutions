using MBRSolutions.Web.HelperClass;
using MBRSolutions.Web.Models;
using MBRSolutions.Web.Services.IServices;
using System.Net.Http;
using System.Threading.Tasks;

namespace MBRSolutions.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;
        public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory= clientFactory;
        }

        public async Task<T> GetAllProductAsync<T>(string token)
        {
           return await this.SendAsync<T>(new APIRequest()
            {
                APIType=APIType.GET,
                Url=SD.Product_API_Base + "/api/products",
                AccessToken= token
           });
        }

        public async Task<T> GetProductAsync<T>(int productId, string token)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                APIType = APIType.GET,
                Url = SD.Product_API_Base + "/api/products/" + productId,
                AccessToken = token
            });
        }
        public async Task<T> CreateProductAsync<T>(ProductDTO productDTO, string token)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                APIType = APIType.POST,
                Data = productDTO,
                Url = SD.Product_API_Base + "/api/products",
                AccessToken = token
            });
        }

        public async Task<T> DeleteProductAsync<T>(int productId, string token)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                APIType = APIType.DELETE,
                Url = SD.Product_API_Base + "/api/products/" + productId,
                AccessToken = token
            });
        }

       
        public async Task<T> UpdateProductAsync<T>(ProductDTO productDTO, string token)
        {
            return await this.SendAsync<T>(new APIRequest()
            {
                APIType = APIType.PUT,
                Data = productDTO,
                Url = SD.Product_API_Base + "/api/products",
                AccessToken = token
            });
        }
    }
}

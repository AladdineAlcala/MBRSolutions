using MBRSolutions.Services.ProductAPI.Model;
using MBRSolutions.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MBRSolutions.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        protected ResponseDTO _response;
        private IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            this._response = new ResponseDTO();
        }

        [HttpGet]
        [Authorize]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDTO> productDTO_List = await _productRepository.GetAllProduct();
                _response.IsSuccess = true;
                _response.Result = productDTO_List;
            }
            catch (System.Exception ex)
            {

                return this._response = new ResponseDTO()
                {
                    IsSuccess = false,
                    ErrorMessages = new List<string>()
                    {
                        ex.ToString()
                    }

                };
            }

            return _response;
        }

        [HttpGet]
        [Authorize]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                ProductDTO productDTO = await _productRepository.GetProductById(id);

                _response.IsSuccess = true;
                _response.Result = productDTO;

            }
            catch (System.Exception ex)
            {

                return this._response = new ResponseDTO()
                {
                    IsSuccess = false,
                    ErrorMessages = new List<string>()
                    {
                        ex.ToString()
                    }

                };
            }

            return _response;
        }


        [HttpPost]
        public async Task<object> Post([FromBody] ProductDTO productDTO)
        {
            try
            {
                ProductDTO _productDTO = await _productRepository.CreateUpdateProduct(productDTO);

                _response.IsSuccess = true;
                _response.Result = _productDTO;

            }
            catch (System.Exception ex)
            {

                return this._response = new ResponseDTO()
                {
                    IsSuccess = false,
                    ErrorMessages = new List<string>()
                    {
                        ex.ToString()
                    }

                };
            }

            return _response;
        }

        [HttpDelete]
        [Authorize(Roles ="Admin")]
        [Route("{id}")]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _productRepository.DeleteProductById(id);

                _response.Result = isSuccess;
               
            }
            catch (System.Exception ex)
            {

                return this._response = new ResponseDTO()
                {
                    IsSuccess = false,
                    ErrorMessages = new List<string>()
                    {
                        ex.ToString()
                    }

                };
            }

            return _response;
        }

    }
}

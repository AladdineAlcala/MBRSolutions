using MBRSolutions.Web.Models;
using MBRSolutions.Web.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MBRSolutions.Web.Controllers
{
    public class ProductController: Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;

        }
        [Route("products")]
        public async Task<IActionResult> ProductIndex()
        {
            var accesstoken = await HttpContext.GetTokenAsync("access_token");

            //var userId = User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value;

            List<ProductDTO> productList = new();
            var response = await _productService.GetAllProductAsync<ResponseDTO>(accesstoken);

            if(response!=null && response.IsSuccess)
            {
                productList = JsonConvert.DeserializeObject<List<ProductDTO>>(Convert.ToString(response.Result));
            }

            return View(productList.ToList());
        }

        [ActionName("deleteproduct")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> ProductDelete(int productId)
        {
            var accesstoken = await HttpContext.GetTokenAsync("access_token");

            //var userId = User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value;

            List<ProductDTO> productList = new();
            var response = await _productService.DeleteProductAsync<ResponseDTO>(productId,accesstoken);

            if (response != null && response.IsSuccess)
            {
                return Redirect(nameof(ProductIndex));
            }

            if (response.ErrorMessages.Any(t=>t.Equals("Forbidden")))
            {
                return StatusCode(403);
            }
            return View(productList.ToList());
        }

    }
}


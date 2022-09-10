using Microsoft.AspNetCore.Mvc;

namespace MBRSolutions.Services.ProductAPI.Controllers
{
    public class ProductController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

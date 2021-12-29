using Microsoft.AspNetCore.Mvc;
using Week3.Service.Product;

namespace Week3.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;


        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        public IActionResult Index()
        {
            return View();
        }


        

    }
}

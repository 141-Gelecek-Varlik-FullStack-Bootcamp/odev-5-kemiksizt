using Microsoft.AspNetCore.Mvc;
using Week3.Model.Product;
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

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var model = productService.GetById(id);
            return View(model.Entity);
        }

        [HttpPost]
        public IActionResult UpdateProduct(int id, ProductViewModel product)
        {
            var permission = productService.UpdateProduct(id, product);

            if(!permission.IsSuccess)
            {
                return View();
            }
            return RedirectToAction("ProductList", "Home");
        }
        




    }
}

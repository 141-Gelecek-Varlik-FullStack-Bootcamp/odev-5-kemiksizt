using Microsoft.AspNetCore.Mvc;
using Week3.Model.Product;
using Week3.Service.Product;

namespace Week3.Web.Controllers
{
    // API katmanının haricinde Web katmanı için ayrı bir controller oluşturdum. Butonlara basarak yönlendirmeler
    // burada yapılır.
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
      
        public IActionResult UpdateProduct(int id)
        {
            var product = productService.UpdateById(id);
            return View(product.Entity);
        }

        [HttpPost]
        public IActionResult UpdateProduct(ProductViewModel product)
        {
            var permission = productService.UpdateProductt(product);

            if(!permission.IsSuccess)
            {
                return View();
            }
            return RedirectToAction("ProductList", "Home");
        }

        public IActionResult InsertProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertProduct(ProductViewModel product)
        {
            var model = productService.InsertProductt(product);

            if (!model.IsSuccess)
            {
                return View();
            }

            return RedirectToAction("ProductList", "Home");
        }

        public IActionResult DeleteProduct(int id)
        {
            productService.DeleteProductPermanently(id);

            return RedirectToAction("ProductList", "Home");
        }





    }
}

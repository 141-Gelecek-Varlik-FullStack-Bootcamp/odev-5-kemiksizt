using Microsoft.AspNetCore.Mvc;
using Week3.API.Infrastructure;
using Week3.Model;
using Week3.Model.Product;
using Week3.Service.Product;

namespace Week3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        //[HttpGet("{id}")]
        //public General<ProductViewModel> GetById(int id)
        //{
        //    return productService.GetById(id);
        //}

        [HttpGet("{id}")]
        public General<ProductViewModel> UpdateById(int id)
        {
            return productService.UpdateById(id);
        }

        [HttpPost("Delete")]
        [ServiceFilter(typeof(LoginFilter))]
        public General<ProductViewModel> DeleteUser(int id, [FromBody] ProductViewModel product)
        {
            return productService.DeleteProduct(id, product);
        }

        //[HttpGet("{IUser}")]
        //public General<ProductViewModel> GetProductListById(int id)
        //{
        //    return productService.GetProductListById(id);
        //}


        [HttpPost]
        public General<ProductViewModel> InsertProductt([FromBody] ProductViewModel newProduct)
        {
            return productService.InsertProductt(newProduct);
        }

        [ServiceFilter(typeof(LoginFilter))]
        [HttpGet]
        public General<ProductViewModel> GetProducts()
        {
            return productService.GetProducts();
        }

        [HttpPut("{id}")]
        public General<ProductViewModel> UpdateProductt([FromBody] ProductViewModel product)
        {
            return productService.UpdateProductt(product);
        }
        /*
        [HttpDelete("{id}")]
        public General<ProductViewModel> DeleteProduct(int id)
        {
            return productService.DeleteProduct(id);
        }
        */


        [HttpGet]
        [Route("Sort")]
        public General<ListProductViewModel> SortProduct([FromQuery] string param)
        {
            return productService.SortProduct(param);
        }

        [HttpGet]
        [Route("Filter")]
        public General<ListProductViewModel> FilterProducts([FromQuery] string param)
        {
            return productService.FilterProduct(param);
        }

        [HttpGet]
        [Route("Paginate")]
        public General<ListProductViewModel> PaginateProduct([FromQuery] int productByPage, [FromQuery]  int pageNo)
        {
            return productService.PaginateProduct(productByPage, pageNo);
        }
    }
    
}

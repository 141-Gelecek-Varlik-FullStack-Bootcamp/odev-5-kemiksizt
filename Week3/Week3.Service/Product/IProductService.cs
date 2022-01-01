using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Model;
using Week3.Model.Product;

namespace Week3.Service.Product
{
    public interface IProductService
    {

        //ProductService içerisinde kullanılacak işlemleri bu interface içerisinde tanımladım.

        //public General<ProductViewModel> GetById(int id);
        public General<ProductViewModel> GetProducts();
        public General<ProductViewModel> InsertProductt(ProductViewModel newProduct);
        public General<ProductViewModel> UpdateProductt(ProductViewModel product);
        public General<ProductViewModel> DeleteProductPermanently(int id);
        //public General<ProductViewModel> GetProductListById(int id);

        public General<ProductViewModel> UpdateById(int id);
        public General<ProductViewModel> DeleteProduct(int id, ProductViewModel product);

        public General<ListProductViewModel> SortProduct(string sortingParameter);

        public General<ListProductViewModel> FilterProduct(string param);

        public General<ListProductViewModel> PaginateProduct(int prodcuctByPage, int pageNo);
    }
}

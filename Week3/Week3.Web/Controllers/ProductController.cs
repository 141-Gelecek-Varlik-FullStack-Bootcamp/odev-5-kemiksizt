using Microsoft.AspNetCore.Mvc;

namespace Week3.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

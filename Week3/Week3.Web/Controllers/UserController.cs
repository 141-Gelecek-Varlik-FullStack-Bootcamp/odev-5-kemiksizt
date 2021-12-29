using Microsoft.AspNetCore.Mvc;

namespace Week3.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

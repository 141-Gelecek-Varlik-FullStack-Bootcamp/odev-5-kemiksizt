using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Week3.Model.User;
using Week3.Service.Product;
using Week3.Service.User;
using Week3.Web.Models;

namespace Week3.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService userService;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger, IUserService _userService, IProductService _productService)
        {
            _logger = logger;
            userService = _userService;
            productService = _productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel loginUser)
        {
            var permission = userService.Login(loginUser);

            if (!permission.IsSuccess)
            {
                return View();
            }

            return RedirectToAction("ProductList", "Home");
        }


        public IActionResult ProductList()
        {
            var productList = productService.GetProducts().List;

            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

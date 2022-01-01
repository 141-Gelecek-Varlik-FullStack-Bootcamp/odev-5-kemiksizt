using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Week3.Model;
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
        private readonly IDistributedCache distributedCache;

        public HomeController(ILogger<HomeController> logger, IUserService _userService, IProductService _productService, IDistributedCache _distributedCache)
        {
            _logger = logger;
            userService = _userService;
            productService = _productService;
            distributedCache = _distributedCache;
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
            
            General<UserLoginViewModel> result = userService.Login(loginUser);
            if (!result.IsSuccess)
            {
                return View();
            }
            var cachedData = distributedCache.GetString("LoginUser");
            var cacheOptions = new DistributedCacheEntryOptions()
            {
                AbsoluteExpiration = DateTime.Now.AddMinutes(2)
            };
            if (string.IsNullOrEmpty(cachedData))
            {
                distributedCache.SetString("LoginUser", JsonConvert.SerializeObject(result.Entity), cacheOptions);
            }


            return RedirectToAction("ProductList", "Home");
        }




        public IActionResult ProductList()
        {
            var cachedData = distributedCache.GetString("LoginUser");
            var result = new UserViewModel();

            if (cachedData is not null)
            {
                result = JsonConvert.DeserializeObject<UserViewModel>(cachedData);
                ViewBag.Auth = result.IsAuth;
                ViewBag.Name = result.Name;
            }

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

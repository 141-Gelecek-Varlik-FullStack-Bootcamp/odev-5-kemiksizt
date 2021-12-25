using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using Week3.Model;
using Week3.Model.User;
using Week3.Service.User;

namespace Week3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly IUserService userService;
        private readonly IDistributedCache distributedCache;

        public LoginController( IUserService _userService, IDistributedCache _distributedCache)
        {
            userService = _userService;
            distributedCache = _distributedCache;
        }

        [HttpPost]
        public General<bool> Login([FromBody] UserLoginViewModel loginUser)
        {
            var cachedData = distributedCache.GetString("LoginUser");

            General<bool> response = new() { Entity = false };
            General<UserLoginViewModel> result = userService.Login(loginUser);

            if (result.IsSuccess)
            {
                var cacheOptions = new DistributedCacheEntryOptions()
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(1)
                };

                if (string.IsNullOrEmpty(cachedData))
                {
                    distributedCache.SetString("LoginUser", JsonConvert.SerializeObject(result.Entity), cacheOptions);
                }

                response.Entity = true;
                response.IsSuccess = true;
                response.Message = "İşlem başarılı";
            }
            else
            {
                response.ExceptionMessage = "Tekrar giriş yapın";
            }

            return response;
        }
    }
}

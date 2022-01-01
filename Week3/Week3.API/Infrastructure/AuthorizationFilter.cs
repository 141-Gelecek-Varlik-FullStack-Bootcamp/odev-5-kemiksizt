using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using Week3.Model.User;

namespace Week3.API.Infrastructure
{
    // API katmanı için distributed cache kullanarak kısıtlamalar getirdim. Cache içerisinde belirlenen süre içinde
    // kullanıcı bilgileri tutulur. Kullanıcı eğer yetkili ise istenen controller üzerine attribute olarak ekleyin.
    public class AuthorizationFilter : Attribute, IActionFilter
    {
        private readonly IDistributedCache distributedCache;

        public AuthorizationFilter(IDistributedCache _distributedCache)
        {
            distributedCache = _distributedCache;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var distCache = distributedCache.GetString("LoginUser");
            var response = new UserViewModel();

            if (!string.IsNullOrEmpty(distCache))
            {
                response = JsonConvert.DeserializeObject<UserViewModel>(distCache);

                if (!response.IsAuth)
                {
                    context.Result = new UnauthorizedObjectResult("Yalnızca adminler bu işlemi yapabilir!");
                }
            }

        }
    }
}

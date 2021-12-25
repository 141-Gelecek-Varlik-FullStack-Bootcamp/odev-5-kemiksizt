using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using System;
using Week3.Model.User;

namespace Week3.API.Infrastructure
{
    public class LoginFilter : Attribute, IActionFilter
    {
        private readonly IDistributedCache distributedCache;
        public LoginFilter(IDistributedCache _distributedCache)
        {
            distributedCache = _distributedCache;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            return;
        }

        public void OnActionExecuting(ActionExecutingContext context)//, IServiceProvider serviceProvider)
        {

            var cachedData = distributedCache.GetString("LoginUser");

            //var memoryCache = context.HttpContext.RequestServices.GetService<IMemoryCache>();

            if(string.IsNullOrEmpty(cachedData))
            {
                context.Result = new UnauthorizedObjectResult("Lütfen önce giriş yapın!");
            }

            
        }
    }
}

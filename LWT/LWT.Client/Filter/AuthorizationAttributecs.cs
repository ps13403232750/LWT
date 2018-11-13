using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using LWT.Common;
using Newtonsoft.Json;
using LWT.Model;

namespace LWT.Client.Filter
{
    public class AuthorizationAttributecs : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //获取访问路径
            var path = filterContext.HttpContext.Request.Path.ToString();
            //获取登录的用户
            var user = filterContext.HttpContext.User;
            //判断用户是否登录
            if (user.Claims.Count() > 0)
            {
                //获取用户的登录信息
                var result = int.Parse(user.Claims.Where(m => m.Type == "userrole").First().Value);
                var list = JsonConvert.DeserializeObject<List<Power>>(RedisHelper.Get("powerlist"));
                if (list.Exists(m => m.Url == path)) return;
            }
            filterContext.Result = new RedirectResult("/Home/Login");
            base.OnActionExecuting(filterContext);
        }

    }
}

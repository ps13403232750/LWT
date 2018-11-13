using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using LWT.Common;
using LWT.Client.Models;
using Newtonsoft.Json;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LWT.Client.Controllers
{
    public  class BaseController : Controller
    {
        private UserData _loginInfo;

        public UserData LoginInfo
        {
            get
            {
                //当前请求的用户身份是否合法
                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    var strUserData = User.Claims.ToList().Where(m => m.Type == "userinfo").FirstOrDefault().Value;
                    
                    _loginInfo = JsonConvert.DeserializeObject<UserData>(strUserData);

                    _loginInfo = RedisHelper.Get<UserData>(_loginInfo.Id.ToString());
                }
                return _loginInfo;
            }
        }

        /// <summary>
        /// 动作过滤器-动作执行之前的事件
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            ViewBag.LoginInfo = LoginInfo;
            base.OnActionExecuting(filterContext);
        }

        public static void WriteDataToCookieAsync(UserData userData,HttpContext httpContext)
        {
            string strUserData = JsonConvert.SerializeObject(userData);
            //构造ClaimsIdentity 对象
            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            //创建 Claim 类型,传入 ClaimsIdentity 中
            identity.AddClaim(new Claim("userrole", userData.RoleId.ToString()));
            identity.AddClaim(new Claim("userinfo", strUserData));

            //创建ClaimsPrincipal对象,传入ClaimsIdentity 对象,调用HttpContext.SignInAsync完成登录
            httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

            //存储redis
            RedisHelper.Set<UserData>(userData.Id.ToString(), userData);
        }
    }
}
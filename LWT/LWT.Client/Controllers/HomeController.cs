using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using LWT.Client.Models;
using LWT.Common;
using LWT.Model;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace LWT.Client.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public int Login(string username,string userpwd)
        {
            string url = string.Format($"Values/Login?name={username}&pwd={userpwd}");
            var user = JsonConvert.DeserializeObject<UserData>(Common.Client.GetApi("get", url));
            if (user!=null)
            {
                WriteDataToCookieAsync(user, HttpContext);
                //获取登录用户拥有的权限
                string power = Common.Client.GetApi("get", "Values/GetUserPower?roleid=" + user.RoleId);
                RedisHelper.Set("powerlist", power);
                return 1;
            }
            return 0;
        }
       
    }
}

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

namespace LWT.Client.Controllers
{
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
            WriteDataToCookieAsync(user,HttpContext);
            return 1;
        }
       
    }
}

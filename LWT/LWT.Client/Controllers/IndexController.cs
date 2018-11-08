using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using LWT.Common;
using LWT.Model;

namespace LWT.Client.Controllers
{
    public class IndexController : Controller
    {
        /// <summary>
        /// 主页面权限列表信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            string getpower = Common.Client.GetApi("get","Values/GetPower");
            return View(JsonConvert.DeserializeObject<List<Power>>(getpower));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LWT.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace LWT.Client.Controllers
{
    public class SettleController : Controller
    {
        /// <summary>
        /// 额度管理表
        /// </summary>
        /// <returns></returns>
        public IActionResult GetManageLimit()
        {   
            return View();
        }

        /// <summary>
        /// 采购结算列表
        /// </summary>
        /// <returns></returns>
        public IActionResult GetPurChaseSettle()
        {
            string getPurChaseSettle =Common.Client.GetApi("get", "Values/GetPurChaseSettle",null);
            return View(JsonConvert.DeserializeObject<List<PurChaseSettle>>(getPurChaseSettle));
        }
    }
}
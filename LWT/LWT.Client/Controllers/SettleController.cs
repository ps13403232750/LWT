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
            string getManageLimit = Common.Client.GetApi("get", "Settle/GetManageLimits");
            var list = JsonConvert.DeserializeObject<List<ManageLimit>>(getManageLimit);
            return View(list);
        }

        /// <summary>
        /// 采购结算列表
        /// </summary>
        /// <returns></returns>
        public IActionResult GetPurChaseSettle()
        {
            string getPurChaseSettle =Common.Client.GetApi("get", "Settle/GetPurChaseSettle");
            var list = JsonConvert.DeserializeObject<List<PurChaseSettle>>(getPurChaseSettle);
            return View(list);
        }

        /// <summary>
        /// 采购结算列表详情显示
        /// </summary>
        /// <returns></returns>
        public IActionResult ThinPurState()
        {
            string thinPurState = Common.Client.GetApi("get", "Settle/ThinPurState");
            var list = JsonConvert.DeserializeObject<List<PurChaseNumber>>(thinPurState);
            return View(list);
        }
    }
}
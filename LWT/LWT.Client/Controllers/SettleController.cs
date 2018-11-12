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
        public IActionResult GetLimit()
        {
            string getLimit = Common.Client.GetApi("get", "Settle/GetLimit");
            var list = JsonConvert.DeserializeObject<List<Limit>>(getLimit);
            return View(list);
        }

        /// <summary>
        /// 额度管理表查询
        /// </summary>
        /// <returns></returns>
        public IActionResult Inquire(string Name)
        {
            string inquire = Common.Client.GetApi("get", "Settle/Inquire");
            var list = JsonConvert.DeserializeObject<List<Limit>>(inquire);
            return View(list);
        }

        /// <summary>
        /// 采购结算列表
        /// </summary>
        /// <returns></returns>
        public IActionResult GetPurChaseSettle()
        {
            string getPurChaseSettle =Common.Client.GetApi("get", "Settle/GetPurchaseSettle");
            var list = JsonConvert.DeserializeObject<List<PurchaseSettle>>(getPurChaseSettle);
            return View(list);
        }

        /// <summary>
        /// 采购结算列表详情显示
        /// </summary>
        /// <returns></returns>
        public IActionResult ThinPurState()
        {
            string thinPurState = Common.Client.GetApi("get", "Settle/ThinPurState");
            var list = JsonConvert.DeserializeObject<List<Orders>>(thinPurState);
            return View(list);
        }

        /// <summary>
        /// 额度详情
        /// </summary>
        /// <returns></returns>
        public IActionResult ThinMaLimite()
        {
            string thinMaLimite = Common.Client.GetApi("get", "Settle/ThinMaLimite");
            var list = JsonConvert.DeserializeObject<List<Limit>>(thinMaLimite);
            return View(list);
        }

        /// <summary>
        /// 修改额度审批状态
        /// </summary>
        public string UpdateState(int id)
        {
            var result = Common.Client.GetApi("Put", "Settle/UpdateState?Id=" + id);
            return result;
        }

        /// <summary>
        /// 获取额度表审批状态的下拉
        /// </summary>
        public string GetState()
        {
            string result = Common.Client.GetApi("Get", "Settle/GetState");
            return result;
        }
    }
}
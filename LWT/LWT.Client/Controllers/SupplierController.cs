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
    public class SupplierController : Controller
    {
        //显示商品视图
        public IActionResult Index()
        {
            var getgoods= Common.Client.GetApi("get", "Supplier/GetGoods");
            return View(JsonConvert.DeserializeObject<List<Goods>>(getgoods));
        }
        
        //审核商品视图
        public IActionResult ReviewOfGoods()
        {
            return View();
        }

        /// <summary>
        /// 获取商品表数据
        /// </summary>
        public string GetGoods()
        {
            var result= Common.Client.GetApi("get", "Supplier/GetGoods");
            return result;
        }
        
        /// <summary>
        /// 审核商品信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public string UpdateGoods(int Id)
        {
            var result = Common.Client.GetApi("Put", "Supplier/UpdateGoods?Id="+Id);
            return result;
        }

        //订单显示视图
        public IActionResult Order()
        {
            return View();
        }

        //订单从表显示视图
        public IActionResult OrderList(int OrderNum)
        {
            ViewBag.OrderNum = OrderNum;
            return View();
        }

        /// <summary>
        /// 审核商品信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public string OrderLists(int OrderNum)
        {
            var result = Common.Client.GetApi("Get", "Supplier/GetOrderList?OrderNum=" + OrderNum);
            return result;
        }

        //添加商品视图
        public IActionResult AddGoods()
        {
            return View();
        }
    }
}
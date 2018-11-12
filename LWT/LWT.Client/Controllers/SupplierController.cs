using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using LWT.Common;
using LWT.Model;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting.Internal;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace LWT.Client.Controllers
{
    public class SupplierController : Controller
    {
        private IHostingEnvironment hostingEnvironment;
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

        /// <summary>
        /// 添加新商品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddGoods( Goods goods,IFormFile fileinput)
        {            
            var result = Common.Client.GetApi("post", "Supplier/AddGoods",goods);
            return int.Parse(result);
        }

        //数据统计视图
        public IActionResult OrderStatistics()
        {
            return View();
        }

        /// <summary>
        /// 数据统计
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public string CountOrder(string OrderTime)
        {
            var result = Common.Client.GetApi("Get", "Supplier/CountOrder?OrderTime=" + OrderTime);
            return result;
        }
    }
}
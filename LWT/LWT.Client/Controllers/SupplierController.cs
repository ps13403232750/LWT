using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using LWT.Model;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using LWT.Client.Models;

namespace LWT.Client.Controllers
{
    public class SupplierController : Controller
    {
        private IHostingEnvironment Environment { get; set; }
        //显示商品视图
        public IActionResult Index()
        {
            var getgoods = Common.Client.GetApi("get", "Supplier/GetGoods");
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
            var result = Common.Client.GetApi("get", "Supplier/GetGoods");
            return result;
        }

        /// <summary>
        ///商品表分页显示 
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        public string PageGoods(PageParams pageParams)
        {
            pageParams.TableName = "Goods";
            var result = Common.Client.GetApi("post", "Supplier/PageGoods", pageParams);
            return result;
        }

        /// <summary>
        /// 审核商品信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public string UpdateGoods(int Id)
        {
            var result = Common.Client.GetApi("Put", "Supplier/UpdateGoods?Id=" + Id);
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
        ///订单表分页显示 
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        public string PageOrders(PageParams pageParams)
        {
            pageParams.TableName = "Orders";
            var result = Common.Client.GetApi("post", "Supplier/PageOrders", pageParams);
            return result;
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
        public IActionResult AddGoods(Goods goods, IFormFile formFile)
        {
            // 文件大小
            //long size = 0;
            // 原文件名（包括路径）
            var filename = ContentDispositionHeaderValue.Parse(formFile.ContentDisposition).FileName;
            // 扩展名
            var extName = filename.Substring(filename.LastIndexOf('.')).Replace("\"", "");
            // 新文件名
            string shortfilename = $"{Guid.NewGuid()}{extName}";
            // 新文件名（包括路径）
            filename = Environment.WebRootPath + @"\Images\" + shortfilename;
            //数据库添加对象
            goods.Img = shortfilename;
            var result = Common.Client.GetApi("post", "Supplier/AddGoods", goods);
            if (Int32.Parse(result) > 0)
            {
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    // 复制文件
                    formFile.CopyTo(fs);
                    // 清空缓冲区数据
                    fs.Flush();
                }
                return Content("<script>alert('添加成功');location.href='/Supplier/ReviewOfGoods'</script>", "text/html;charset=utf-8");
            }
            else
            {
                return Content("<script>alert('添加商品失败！请联系客服，核对重要信息');location.href='/Supplier/AddGoods'</script>", "text/html;charset=utf-8");
            }
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
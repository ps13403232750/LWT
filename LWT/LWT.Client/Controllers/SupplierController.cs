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

        /// <summary>
        /// 添加新商品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddGoods(Goods goods,IFormFile fileinput)
        {
            
            // 文件大小
            //long size = 0;
            // 原文件名（包括路径）
            var filename = ContentDispositionHeaderValue.Parse(fileinput.ContentDisposition).FileName;
            // 扩展名
            var extName = filename.Substring(filename.LastIndexOf('.')).Replace("\"", "");
            // 新文件名
            string shortfilename = $"{Guid.NewGuid()}{extName}";
            // 新文件名（包括路径）
            filename = hostingEnvironment.WebRootPath + @"\Images\" + shortfilename;
            // 设置文件大小
            //size += signature.Length;
            // 创建新文件
            //数据库添加对象
            goods.Img = shortfilename;
            var result = _student.AddCallPolice(alarm);
            if (result > 0)
            {
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    // 复制文件
                    fileinput.CopyTo(fs);
                    // 清空缓冲区数据
                    fs.Flush();
                }
                return Content("<script>alert('报案成功,请保护好自己,耐心等待周队长处理!');location.href='/Center/Index'</script>", "text/html;charset=utf-8");
            }
            else
            {
                return Content("<script>alert('报案失败,请检查网络!如遇经济情况请直接联系周队长: 18513121113');location.href='/Center/Index'</script>", "text/html;charset=utf-8");
            }
            var result = Common.Client.GetApi("post", "Supplier/AddGoods",goods);
            return int.Parse(result);
        }

        //数据统计视图
        public IActionResult Statistics()
        {
            return View();
        }
    }
}
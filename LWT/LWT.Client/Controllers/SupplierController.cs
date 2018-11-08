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
        public IActionResult Index()
        {
           // ViewBag.goods= Common.Client.GetApi("get", "Supplier/GetGoods");
            var getgoods= Common.Client.GetApi("get", "Supplier/GetGoods");
            
            return View(JsonConvert.DeserializeObject<List<Goods>>(getgoods));
        }
        public IActionResult ReviewOfGoods()        {
            
           // ViewBag.goods = GetGoods();
            return View();
        }
        public string GetGoods()
        {
            var result= Common.Client.GetApi("get", "Supplier/GetGoods");
            return result;
        }

    }
}
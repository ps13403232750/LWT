using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LWT.Client.Models;

namespace LWT.Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public int Login(string username,string userpwd)
        {
            string getpower = Common.Client.GetApi("get", "Values/GetPower");
            return 1;
        }
       
    }
}

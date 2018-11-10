using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using LWT.Common;
using LWT.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public int Add(Users user)
        {
            var data = Common.Client.GetApi("Post", "Values/AddUser",user);
            return int.Parse(data);
        }

        /// <summary>
        /// 根据角色添加权限
        /// </summary>
        /// <returns></returns>
        public IActionResult AddRole()
        {
            string getpower = Common.Client.GetApi("get", "Values/GetPower");
            return View(JsonConvert.DeserializeObject<List<Power>>(getpower));
        }
        [HttpPost]
        public int AddRole(RoleAndPowerHelper roleAndPowerHelper)
        {
            var data = Common.Client.GetApi("post", "Values/AddRoleAndPower",roleAndPowerHelper);
            return int.Parse(data);
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <returns></returns>
        public IActionResult AddUsersRole()
        {
            return View();
        }

        public int AddUsersRole(Supplier supplier)
        {
            var data = Common.Client.GetApi("post", "Values/AddRole", supplier);
            return int.Parse(data);
        }

        /// <summary>
        /// 添加供应商角色
        /// </summary>
        /// <returns></returns>
        public IActionResult AddSupplier()
        {
            return View();
        }

        public int AddSupplier(Supplier supplier)
        {
            var data = Common.Client.GetApi("post", "Values/AddSupplier");
            return int.Parse(data);
        }

        #region 所有下拉菜单
        /// <summary>
        /// 获取角色名称的下拉菜单
        /// </summary>
        public string GetRoles()
        {
            string sql = Common.Client.GetApi("Get", "Values/GetRoles");
            return sql;
           
        }

        /// <summary>
        /// 获取所有用户的主要信息
        /// </summary>
        /// <returns></returns>
        public string GetUsers()
        {
            string data = Common.Client.GetApi("Get", "Values/GetUsers");
            return data;
        }

        /// <summary>
        /// 获取品牌名称的下拉菜单
        /// </summary>
        public void GetBrand()
        {
            string sql = Common.Client.GetApi("Get", "Values/GetBrand");
            List<Brand> list = JsonConvert.DeserializeObject<List<Brand>>(sql);
            var data = from s in list
                       select new SelectListItem
                       {
                           Text = s.BrandName,
                           Value = s.Id.ToString()
                       };
            ViewBag.brand = data.ToList();

        }
        #endregion
    }
}
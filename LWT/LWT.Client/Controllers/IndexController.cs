using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using LWT.Common;
using LWT.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using LWT.Client.Models;

namespace LWT.Client.Controllers
{
    
    public class IndexController : Controller
    {
        private IHostingEnvironment Environment { get; set; }

        public IndexController(
            IHostingEnvironment environment
        )
        {
            this.Environment = environment;
        }
        #region 主界面

        /// <summary>
        /// 主页面权限列表信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            string getpower = Common.Client.GetApi("get", "Values/GetPower");
            return View(JsonConvert.DeserializeObject<List<Power>>(getpower));
        }

        public IActionResult HomePage()
        {
            return View();
        }
        #endregion
        #region //权限模块
        
        /// <summary>
        /// 权限菜单维护
        /// </summary>
        /// <returns></returns>
        public IActionResult PowerManage()
        {
            return View();
        }

        public string GetPowerList(PageParams pageParams)
        {
            pageParams.TableName = "Power";
            if (!string.IsNullOrEmpty(pageParams.StrWhere))
            {
                pageParams.StrWhere = " and PowerName like '%" + pageParams.StrWhere + "%'";
            }
            var result = Common.Client.GetApi("post", "values/GetPowerPaged", pageParams);
            return result;
        }

        /// <summary>
        /// 权限菜单维护
        /// </summary>
        /// <returns></returns>
        public IActionResult UsersManage()
        {
            return View();
        }

        public string GetUsersList(PageParams pageParams)
        {
            pageParams.TableName = "Users";
            var result = Common.Client.GetApi("post", "values/GetUsersPageed", pageParams);
            return result;
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
        [HttpPost]
        public int AddUsersRole(Roles roles)
        {
            var data = Common.Client.GetApi("post", "Values/AddRole", roles);
            return int.Parse(data);
        }
        #endregion

        #region //合作伙伴管理模块
        /// <summary>
        /// 添加供应商角色
        /// </summary>
        /// <returns></returns>
        public IActionResult AddSuppliers()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddSuppliers(Supplier supplier,IFormFile formFile)
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
            supplier.BusinessLicence = shortfilename;
            var result = Common.Client.GetApi("post", "Values/AddSupplier", supplier);
            if (Int32.Parse(result) > 0)
            {
                using (FileStream fs = System.IO.File.Create(filename))
                {
                    // 复制文件
                    formFile.CopyTo(fs);
                    // 清空缓冲区数据
                    fs.Flush();
                }
                return Content("<script>alert('供应商添加成功');location.href='/Center/Index'</script>", "text/html;charset=utf-8");
            }
            else
            {
                return Content("<script>alert('添加供应商失败！请联系客服，核对重要信息');location.href='/Center/Index'</script>", "text/html;charset=utf-8");
            }
            
        }

        #endregion

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
        /// 获取区域的下拉菜单
        /// </summary>
        public string GetArea()
        {
            string sql = Common.Client.GetApi("Get", "Values/GetAreas");
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
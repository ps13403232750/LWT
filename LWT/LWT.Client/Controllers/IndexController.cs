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
        /// 权限信息维护
        /// </summary>
        /// <returns></returns>
        public IActionResult PowerManage()
        {
            return View();
        }

        public string GetPowerList(PageParams pageParams)
        {
            pageParams.TableName = "Power";
            pageParams.SortRow = "id";
            if (!string.IsNullOrEmpty(pageParams.StrWhere))
            {
                pageParams.StrWhere = " and PowerName like '%" + pageParams.StrWhere + "%'";
            }
            var result = Common.Client.GetApi("post", "values/GetPowerPaged", pageParams);
            return result;
        }

        /// <summary>
        /// 获取全部父级菜单
        /// </summary>
        /// <returns></returns>
        public string GetParentPower()
        {
            var result = Common.Client.GetApi("get", "values/GetParentPower");
            return result;
        }

        /// <summary>
        /// 修改菜单信息
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        [HttpPost]
        public int EditPower(Power power)
        {
            var i = Common.Client.GetApi("post", "values/EditPower",power);
            return int.Parse(i);
        }

        /// <summary>
        /// 启停用权限
        /// </summary>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int PowerAbled(int status, int id)
        {
            string url = string.Format($"values/PowerAbled?status={status}&id={id}");
            var i = Common.Client.GetApi("get", url);
            return int.Parse(i);
        }

        #endregion

        #region //角色模块

        /// <summary>
        /// 用户信息维护
        /// </summary>
        /// <returns></returns>
        public IActionResult RolesManage()
        {
            return View();
        }

        public string GetRolesList(PageParams pageParams)
        {
            pageParams.TableName = "Roles";
            if (!string.IsNullOrEmpty(pageParams.StrWhere))
            {
                pageParams.StrWhere = "and UserName like '%" + pageParams.StrWhere + "%'";
            }
            var result = Common.Client.GetApi("post", "values/GetRolesPaged", pageParams);
            return result;
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
            var data = Common.Client.GetApi("post", "Values/AddRoleAndPower", roleAndPowerHelper);
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

        #region //用户模块

        /// <summary>
        /// 用户信息维护
        /// </summary>
        /// <returns></returns>
        public IActionResult UsersManage()
        {
            return View();
        }

        public string GetUsersList(PageParams pageParams)
        {
            pageParams.TableName = "Users s join Roles r on s.roleid = r.roleid";
            if (!string.IsNullOrEmpty(pageParams.StrWhere))
            {
                pageParams.StrWhere = "and UserName like '%" + pageParams.StrWhere + "%'";
            }
            var result = Common.Client.GetApi("post", "values/GetUsersPaged", pageParams);
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
            var data = Common.Client.GetApi("Post", "Values/AddUser", user);
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
        public IActionResult AddSuppliers(Supplier supplier, IFormFile formFile)
        {
            var extension = Path.GetExtension(formFile.FileName);
            var root = Environment.WebRootPath;
            var fullPath = $@"{root}\images\{formFile.FileName + extension}";
            var result = Common.Client.GetApi("post", "Values/AddSupplier", supplier);
            if (Int32.Parse(result) > 0)
            {
                // 创建新文件
                using (FileStream fs = System.IO.File.Create(fullPath))
                {
                    supplier.BusinessLicence = "/images/" + new Guid() + formFile.FileName;
                    // 复制文件
                    formFile.CopyTo(fs);
                    // 清空缓冲区数据
                    fs.Flush();
                }
                return Content("<script>alert('供应商入驻成功');location.href='/index/SupplierManage'</script>", "text/html;charset=utf-8");
            }
            else
            {
                return Content("<script>alert('添加供应商入驻失败！请联系客服，核对重要信息');location.href='/index/SupplierManage'</script>", "text/html;charset=utf-8");
            }

        }

        /// <summary>
        /// 用户信息维护
        /// </summary>
        /// <returns></returns>
        public IActionResult SupplierManage()
        {
            return View();
        }

        public string GetSupplierList(PageParams pageParams)
        {
            pageParams.TableName = "Supplier s join brand b on s.brand = b.bid join Area a on s.aid = a.aid";
            if (!string.IsNullOrEmpty(pageParams.StrWhere))
            {
                pageParams.StrWhere = "and UserName like '%" + pageParams.StrWhere + "%'";
            }
            var result = Common.Client.GetApi("post", "values/GetSupplierPaged", pageParams);
            return result;
        }

        /// <summary>
        /// 添加企业采购
        /// </summary>
        /// <returns></returns>
        public IActionResult AddPurChase()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPurChase(Purchase purchase)
        {
            // 文件大小
            //long size = 0;
            // 原文件名（包括路径）
            //var filename = ContentDispositionHeaderValue.Parse(formFile.ContentDisposition).FileName;
            //// 扩展名
            //var extName = filename.Substring(filename.LastIndexOf('.')).Replace("\"", "");
            //// 新文件名
            //string shortfilename = $"{Guid.NewGuid()}{extName}";
            //// 新文件名（包括路径）
            //filename = Environment.WebRootPath + @"\Images\" + shortfilename;
            ////数据库添加对象
            //purchase.BusinessLicence = shortfilename;
            var result = Common.Client.GetApi("post", "Values/AddPurChase", purchase);
            if (Int32.Parse(result) > 0)
            {
                //using (FileStream fs = System.IO.File.Create(filename))
                //{
                //    // 复制文件
                //    formFile.CopyTo(fs);
                //    // 清空缓冲区数据
                //    fs.Flush();
                //}
                return Content("<script>alert('企业采购入驻成功');location.href='/index/SupplierManage'</script>", "text/html;charset=utf-8");
            }
            else
            {
                return Content("<script>alert('企业采购入驻失败！请联系客服，核对重要信息');location.href='/Center/Index'</script>", "text/html;charset=utf-8");
            }

        }
        #endregion

        #region 三级类目模块

        /// <summary>
        /// 用户信息维护
        /// </summary>
        /// <returns></returns>
        public IActionResult CategoryManage()
        {
            return View();
        }

        public string GetCategoryList(PageParams pageParams)
        {

            pageParams.TableName = "Category";
            if (!string.IsNullOrEmpty(pageParams.StrWhere))
            {
                pageParams.StrWhere = "and UserName like '%" + pageParams.StrWhere + "%'";
            }
            var result = Common.Client.GetApi("post", "values/GetCategory", pageParams);
            return result;
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
        /// 获取品牌名称的下拉菜单
        /// </summary>
        public string GetBrand()
        {
            string sql = Common.Client.GetApi("Get", "Values/GetBrand");
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
        //public void GetBrand()
        //{
        //    string sql = Common.Client.GetApi("Get", "Values/GetBrand");
        //    List<Brand> list = JsonConvert.DeserializeObject<List<Brand>>(sql);
        //    var data = from s in list
        //               select new SelectListItem
        //               {
        //                   Text = s.BrandName,
        //                   Value = s.Id.ToString()
        //               };
        //    ViewBag.brand = data.ToList();

        //}
        #endregion


    }
}
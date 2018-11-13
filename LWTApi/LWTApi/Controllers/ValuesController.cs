﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using IServices;
using Model;

namespace LWTApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUserServices userServices;
        public ValuesController(IUserServices _userServices)
        {
            userServices = _userServices;       
        }

        #region //权限模块
        /// <summary>
        /// 权限列表信息显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Power>> GetPower()
        {
            return userServices.GetPower().ToList();
        } 

        /// <summary>
        /// 分页权限列表信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public ActionResult<PageResult<Power>> GetPowerPaged(PageParams pageParams)
        {
            var list = userServices.GetPowerPageList(pageParams);
            return list;
        }

        /// <summary>
        /// 用户列表分页
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public ActionResult<PageResult<UsersHelper>> GetUsersPaged(PageParams pageParams)
        {
            var list = userServices.GetUsersPageList(pageParams);
            return list;
        }

        /// <summary>
        /// 角色列表分页
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public ActionResult<PageResult<Roles>> GetRolesPaged(PageParams pageParams)
        {
            var list = userServices.GetRolesPageList(pageParams);
            return list;
        }

        /// <summary>
        /// 获取用户角色信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Roles>> GetRoles()
        {
            return userServices.GetRoles().ToList();
        }

        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        // POST api/values
        [Route("[action]")]
        [HttpPost]
        public int AddUser(Users user)
        {
            var i = userServices.Add(user);
            return i;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
        [Route("[action]")]
        [HttpPost]
        public int AddRole(Roles roles)
        {
            var i = userServices.AddRole(roles);
            return i;
        }

        /// <summary>
        /// 根据角色添加权限
        /// </summary>
        /// <param name="roleAndPower"></param>
        /// <returns></returns>
        [Route("[action]")]
        [HttpPost]
        public int AddRoleAndPower(RoleAndPowerHelper roleAndPowerHelper)
        {
            var i = userServices.AddRoleAndPower(roleAndPowerHelper);
            return i;
        }
        #endregion

        #region //三级类目模块
        /// <summary>
        /// 获取类目信息
        /// </summary>
        /// <param name="classe"></param>
        /// <returns></returns>
        [Route("[action]")]
        [HttpGet]
        public List<Category> GetClass()
        {
            var data = userServices.GetCategory().ToList();
            return data;
        }
        #endregion

        #region //合作伙伴模块

        /// <summary>
        /// 企业采购入驻
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns></returns>
        [Route("[action]")]
        [HttpPost]
        public int Add(Purchase purchase)
        {
            var i = userServices.Add(purchase);
            return i;
        }

        /// <summary>
        /// 获取品牌的信息
        /// </summary>
        /// <returns></returns>
        [Route("[action]")]
        [HttpGet]
        public List<Brand> GetBrand()
        {
            return userServices.GetBrand().ToList();
        }

        /// <summary>
        /// 获取所有供应商信息
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        public PageResult<SupplierHelper> GetSupplierPaged(PageParams pageParams)
        {
            return userServices.GetSupplierPageList(pageParams); 
        }

        /// <summary>
        /// 供应商入驻
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        [Route("[action]")]
        [HttpPost]
        public int AddSupplier(Supplier supplier)
        {
            var i = userServices.AddSupplier(supplier);
            return i;
        }

        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        [Route("[action]")]
        [HttpPost]
        public int AddBrand(Brand brand)
        {
            var i = userServices.AddBrand(brand);
            return i;
        }

        /// <summary>
        /// 获取区域的信息
        /// </summary>
        /// <returns></returns>
        [Route("[action]")]
        [HttpGet]
        public List<Area> GetAreas()
        {
            return userServices.GetAreas();
        }

        /// <summary>
        /// 添加企业采购员
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns></returns>
        [Route("[action]")]
        [HttpPost]
        public int AddPurChase(Purchase purchase)
        {
            return userServices.AddPurChase(purchase);
        }

        /// <summary>
        /// 企业采购员分页显示
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        [Route("[action]")]
        [HttpGet]
        public PageResult<Purchase> GetPurchasePaged(PageParams pageParams)
        {
            return userServices.GetPurchasePageList(pageParams);
        }
        #endregion

        }
}

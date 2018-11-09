using IServices;
using Model;
using System;
using System.Collections.Generic;

using SqlSugar;

namespace Services
{
    public class UserServices :BaseDB, IUserServices
    {
        
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Add(Users user)
        {
            var i = SqlSugarHelper<Users>.Insert(user);
            return i;
        }

        /// <summary>
        /// 企业采购入驻
        /// </summary>
        /// <param name="Purchase"></param>
        /// <returns></returns>
        public int Add(Purchase purchase)
        {
            var i = SqlSugarHelper<Purchase>.Insert(purchase);
            return i;
        }

        /// <summary>
        /// 添加品牌
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public int AddBrand(Brand brand)
        {
            var i = SqlSugarHelper<Brand>.Insert(brand);
            return i;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
        public int AddRole(Roles roles)
        {
            var i = SqlSugarHelper<Roles>.Insert(roles);
            return i;
        }

        /// <summary>
        /// 供应商入驻
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        public int AddSupplier(Supplier supplier)
        {
            var i = SqlSugarHelper<Supplier>.Insert(supplier);
            return i;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int AddUser(Users users)
        {
            var i = SqlSugarHelper<Users>.Insert(users);
            return i;
        }

        /// <summary>
        /// 获取类目信息
        /// </summary>
        /// <param name="classe"></param>
        /// <returns></returns>
        public List<Category> GetCategory()
        {
            var list = SqlSugarHelper<Category>.FindAll();
            return list;
        }

        /// <summary>
        /// 获取权限列表信息
        /// </summary>
        /// <returns></returns>
        public List<Power> GetPowerMessage()
        {
            var list = SqlSugarHelper<Power>.FindAll();
            return list;
        }

        /// <summary>
        /// 获取用户角色的所有信息
        /// </summary>
        /// <returns></returns>
        public List<Roles> GetRoles()
        {
            var list = SqlSugarHelper<Roles>.FindAll();
            return list;
        }

        /// <summary>
        /// 获取品牌的信息
        /// </summary>
        /// <returns></returns>
        public List<Brand> GetBrand()
        {
            var list = SqlSugarHelper<Brand>.FindAll();
            return list;
        }

        /// <summary>
        /// 获取所有用户注册信息的名称
        /// </summary>
        /// <returns></returns>
        public List<Users> GetUsers()
        {
            var list = SqlSugarHelper<Users>.FindAll();
            return list;
        }

        /// <summary>
        /// 根据角色添加权限
        /// </summary>
        /// <param name="roleAndPower"></param>
        /// <returns></returns>
        public int AddRoleAndPower(int name, string ids)
        {
            return 1;
        }
    }
}

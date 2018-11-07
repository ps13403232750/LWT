using IServices;
using Model;
using System;
using System.Collections.Generic;

using SqlSugar;

namespace Services
{
    public class UserServices :BaseDB, IUserServices
    {
        
        
        public int Add(Users user)
        {
            var i = SqlSugarHelper<Users>.Insert(user);
            return 1;
        }

        /// <summary>
        /// 企业采购入驻
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns></returns>
        public int Add(PurChase purchase)
        {
            var i = SqlSugarHelper<PurChase>.Insert(purchase);
            return 1;
        }

        public int AddBrand(Brand brand)
        {
            var i = SqlSugarHelper<Brand>.Insert(brand);
            return 1;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
        public int AddRole(Roles roles)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据角色添加权限
        /// </summary>
        /// <param name="roleAndPower"></param>
        /// <returns></returns>
        public int AddRoleAndPower(RoleAndPower roleAndPower)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 供应商入驻
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        public int AddSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int AddUser(Users users)
        {
            throw new NotImplementedException();
        }

        public Brand GetBrand()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取类目信息
        /// </summary>
        /// <param name="classe"></param>
        /// <returns></returns>
        public List<Class> GetClass(Class classe)
        {
            throw new NotImplementedException();
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
    }
}

using IServices;
using Model;
using System;
using System.Collections.Generic;

using SqlSugar;

namespace Services
{
    public class UserServices :BaseDB, IUserServices
    {

        SimpleClient<Power> Sdb = new SimpleClient<Power>(GetInstance());
        SimpleClient<Brand> brand = new SimpleClient<Brand>(GetInstance());
        SimpleClient<Roles> roles = new SimpleClient<Roles>(GetInstance());
        SimpleClient<RoleAndPower> roleandpower = new SimpleClient<RoleAndPower>(GetInstance());
        SimpleClient<Supplier> supplier = new SimpleClient<Supplier>(GetInstance());
        public int Add(Users user)
        {
            var dbset = BaseDB.GetInstance();
            var quary = dbset.Insertable(user);
            return 1;
        }

        /// <summary>
        /// 企业采购入驻
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns></returns>
        public int Add(PurChase purchase)
        {
            var dbset = BaseDB.GetInstance();
            var result = dbset.Insertable(purchase);
            return 1;
        }

        public int AddBrand(Brand brand)
        {
            var dbset = BaseDB.GetInstance();
            var result = dbset.Insertable(brand);
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
            return Sdb.GetList();
        }
    }
}

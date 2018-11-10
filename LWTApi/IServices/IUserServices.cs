using Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace IServices
{
    public interface IUserServices
    {
        int Add(Users user);

        /// <summary>
        /// 获取权限列表信息
        /// </summary>
        /// <returns></returns>
        List<Power> GetPowerMessage();

        /// <summary>
        /// 企业采购入驻
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns></returns>
        int Add(Purchase purchase);

        /// <summary>
        /// 供应商入驻
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        int AddSupplier(Supplier supplier);

        /// <summary>
        /// 获取三级类目
        /// </summary>
        /// <param name="classe"></param>
        /// <returns></returns>
        List<Category> GetCategory();

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        int AddUser(Users users);

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
        int AddRole(Roles roles);

        /// <summary>
        /// 根据角色添加权限
        /// </summary>
        /// <param name="roleAndPower"></param>
        /// <returns></returns>
        int AddRoleAndPower(RoleAndPowerHelper roleAndPowerHelper);

        /// <summary>
        /// 获取品牌信息
        /// </summary>
        /// <returns></returns>
        List<Brand> GetBrand();

        /// <summary>
        /// 添加品牌信息
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        int AddBrand(Brand brand);

        /// <summary>
        /// 获取用户角色信息
        /// </summary>
        /// <returns></returns>
        List<Roles> GetRoles();

        /// <summary>
        /// 获取用户注册的信息
        /// </summary>
        /// <returns></returns>
        List<Users> GetUsers();

    }
}

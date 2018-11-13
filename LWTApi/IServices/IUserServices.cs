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
        /// 获取全部权限列表
        /// </summary>
        /// <returns></returns>
        List<Power> GetUserPower(int roleid);

        /// <summary>
        /// 获取权限列表
        /// </summary>
        /// <returns></returns>
        List<Power> GetPower();

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

        /// <summary>
        /// 获取权限分页列表
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        PageResult<Power> GetPowerPageList(PageParams pageParams);

        /// <summary>
        /// 获取所有用户分页列表
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        PageResult<UsersHelper> GetUsersPageList(PageParams pageParams);


        /// <summary>
        /// 获取所有用户分页列表
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        PageResult<Roles> GetRolesPageList(PageParams pageParams);

        /// <summary>
        /// 获取区域信息
        /// </summary>
        /// <returns></returns>
        List<Area> GetAreas();


        /// <summary>
        /// 获取所有供应商分页列表
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        PageResult<SupplierHelper> GetSupplierPageList(PageParams pageParams);

        /// <summary>
        /// 企业采购员入驻
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        int AddPurChase(Purchase purchase);

        /// <summary>
        /// 获取所有供应商分页列表
        /// </summary>
        /// <param name="pageParams"></param>
        /// <returns></returns>
        PageResult<Purchase> GetPurchasePageList(PageParams pageParams);

        /// <summary>
        /// 修改菜单详情
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        int EditPower(Power power);

        /// <summary>
        /// 启停用权限
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        int PowerAbled(int status,int id);

        /// <summary>
        /// 获取全部父级权限
        /// </summary>
        /// <returns></returns>
        List<Power> GetParentPower();

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        UserData Login(string name, string pwd);

    }
}

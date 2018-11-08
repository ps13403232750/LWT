using System;
using System.Collections.Generic;
using System.Text;

using SqlSugar;
using Model;
using IServices;
namespace Services
{
    public class SettleServices : BaseDB, ISettleServices
    {
        /// <summary>
        /// 额度表显示
        /// </summary>
        /// <returns></returns>
        public List<ManageLimit> GetManageLimits()
        {
            var list = SqlSugarHelper<ManageLimit>.FindAll();
            return list;
        }

        /// <summary>
        /// 结算次数
        /// </summary>
        /// <returns></returns>
        public List<PurChaseNumber> GetPurChaseNumber()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 采购付款结算列表
        /// </summary>
        /// <returns></returns>
        public List<PurChasePay> GetPurChasePay()
        {
            var list = SqlSugarHelper<PurChasePay>.FindAll();
            return list;
        }

        /// <summary>
        /// 采购结算列表
        /// </summary>
        /// <returns></returns>
        public List<PurChaseSettle> GetPurChaseSettle()
        {
            var list = SqlSugarHelper<PurChaseSettle>.FindAll();
            return list;
        }

        /// <summary>
        /// 额度审批状态
        /// </summary>
        /// <returns></returns>
        //public int UpdateSettle(int id,int states)
        //{
        //    var i = SqlSugarHelper<ManageLimit>.Update(id, states);
        //    return 1; 
        //}
    }
}

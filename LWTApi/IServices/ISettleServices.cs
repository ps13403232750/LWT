using System;
using System.Collections.Generic;
using System.Text;

using Model;
namespace IServices
{
   public interface ISettleServices
    {
        /// <summary>
        /// 额度管理表
        /// </summary>
        /// <returns></returns>
        List<ManageLimit> GetManageLimits();

        /// <summary>
        /// 结算次数
        /// </summary>
        /// <returns></returns>
        List<PurChaseNumber> GetPurChaseNumber();

        /// <summary>
        /// 采购结算列表
        /// </summary>
        /// <returns></returns>
        List<PurChasePay> GetPurChasePay();

        /// <summary>
        /// 采购付款结算列表
        /// </summary>
        /// <returns></returns>
        List<PurChaseSettle> GetPurChaseSettle();

        ///// <summary>
        ///// 修改审批状态
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="states"></param>
        ///// <returns></returns>
        //int UpdateSettle(int id, int states);
    }
}

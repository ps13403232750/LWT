using System;
using System.Collections.Generic;
using System.Text;

using Model;
namespace IServices
{
   public interface ISettleServices
    {
        /// <summary>
        /// 额度管理表分页
        /// </summary>
        /// <returns></returns>
        PageResult<Limits> GetLimitPageList(PageParams pageParams);

        /// <summary>
        /// 额度管理表
        /// </summary>
        /// <returns></returns>
        List<Limits> GetLimit();

        /// <summary>
        /// 结算次数
        /// </summary>
        /// <returns></returns>
        List<PurchaseNumber> GetPurchaseNumber();

        /// <summary>
        /// 额度详情
        /// </summary>
        /// <returns></returns>
        List<Limits> ThinMaLimite();

        /// <summary>
        /// 详情
        /// </summary>
        /// <returns></returns> 
        List<Orders> ThinPurState();

        /// <summary>
        /// 采购结算列表
        /// </summary>
        /// <returns></returns>
        List<PurchasePay> GetPurchasePay();

        /// <summary>
        /// 采购付款结算列表
        /// </summary>
        /// <returns></returns>
        List<PurchaseSettle> GetPurchaseSettle();

        /// <summary>
        /// 修改审批状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="states"></param>
        /// <returns></returns>
        bool  UpdateState(int id, int states);

        /// <summary>
        ///审批状态下拉 
        /// </summary>
        /// <returns></returns>
        List<Limits> GetState();
    }
}

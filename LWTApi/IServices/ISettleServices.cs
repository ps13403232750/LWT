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
        List<ManageLimit> GetManageLimit();

        /// <summary>
        /// 结算次数
        /// </summary>
        /// <returns></returns>
        List<PurChaseNumber> GetPurChaseNumber();

        /// <summary>
        /// 额度详情
        /// </summary>
        /// <returns></returns>
        List<ManageLimit> ThinMaLimite();

        /// <summary>
        /// 详情
        /// </summary>
        /// <returns></returns>
        List<PurChaseNumber> ThinPurState();

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

        /// <summary>
        /// 修改审批状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="states"></param>
        /// <returns></returns>
        bool  UpdateState(int id, int states);
    }
}

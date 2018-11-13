using System;
using System.Collections.Generic;
using System.Text;

using SqlSugar;
using Model;
using IServices;
using Common;

namespace Services
{
    public class SettleServices : BaseDB, ISettleServices
    {
        /// <summary>
        /// 额度管理表分页
        /// </summary>
        /// <returns></returns>
        public PageResult<Limits> GetSettlePageList(PageParams pageParams)
        {
            var list = OraclePaging.QuickPage<Limits>(pageParams);
            return list;
        }

        /// <summary>
        /// 额度管理表
        /// </summary>
        /// <returns></returns>
        public List<Limits> GetLimit()
        {
            var list = SqlSugarHelper<Limits>.FindAll();
            return list;
        }

        /// <summary>
        /// 结算次数
        /// </summary>
        /// <returns></returns>
        public List<PurchaseNumber> GetPurchaseNumber()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 结算详情
        /// </summary>
        /// <returns></returns>

        public List<Orders> ThinPurState()
        {
            var list = SqlSugarHelper<Orders>.FindAll();
            return list;
        }

        /// <summary>
        /// 结算列表详情
        /// </summary>
        /// <returns></returns>
        public List<PurchasePay> GetPurchasePay()
        {
            var list = SqlSugarHelper<PurchasePay>.FindAll();
            return list;
        }

        /// <summary>
        /// 采购结算列表
        /// </summary>
        /// <returns></returns>
        public List<Settle> GetPurchaseSettle()
        {
            var list = SqlSugarHelper<Settle>.FindAll();
            return list;
        }

        /// <summary>
        /// 采购结算列表分页
        /// </summary>
        /// <returns></returns>
        public PageResult<Settle> SettlePageList(PageParams pageParams)
        {
            var list = OraclePaging.QuickPage<Settle>(pageParams);
            return list;
        }

        /// <summary>
        /// 额度详情
        /// </summary>
        /// <returns></returns>
        public List<Limits> ThinMaLimite()
        {
            var list = SqlSugarHelper<Limits>.FindAll();
            return list;
        }

        /// <summary>
        ///额度修改状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="states"></param>
        /// <returns></returns>
        public bool UpdateState(int id, int states)
        {
            var result = GetSimpleInstance<Limits>().Update(it => new Limits() { State = states }, it => it.Id == id);
            return (result);
        }
    }
}

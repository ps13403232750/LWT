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
        public List<Limit> GetLimit()
        {
            var list = SqlSugarHelper<Limit>.FindAll();
            return list;
        }

        /// <summary>
        /// 额度表查询
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="states"></param>
        /// <returns></returns>
        public List<Limit> Inquire(string Name)
        {
            var db = BaseDB.GetInstance();
            var entities = db.Queryable<Limit>().Where(Name).ToList();
            return entities;
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
        public List<PurchaseSettle> GetPurchaseSettle()
        {
            var list = SqlSugarHelper<PurchaseSettle>.FindAll();
            return list;
        }

        /// <summary>
        /// 额度详情
        /// </summary>
        /// <returns></returns>
        public List<Limit> ThinMaLimite()
        {
            var list = SqlSugarHelper<Limit>.FindAll();
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
            var result = GetSimpleInstance<Limit>().Update(it => new Limit() { State = states }, it => it.Id == id);
            return (result);
        } 
    }
}

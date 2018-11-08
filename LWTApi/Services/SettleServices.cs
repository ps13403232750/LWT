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
        /// 结算详情
        /// </summary>
        /// <returns></returns>
        public List<PurChaseNumber> ThinPurState()
        {
            var list = SqlSugarHelper<PurChaseNumber>.FindAll();
            return list;
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
        ///额度审核状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="states"></param>
        /// <returns></returns>
        public int UpdateSettle(int id, int states)
        {         
            ManageLimit ml = new ManageLimit();
            ml.Id = id;
            ml.BuyerState = states;
            var reslut = SqlSugarHelper<ManageLimit>.Update(ml);
            //var i = SqlSugarHelper<ManageLimit>.Update(id, states);
            return Convert.ToInt32(reslut);
        }
    }
}

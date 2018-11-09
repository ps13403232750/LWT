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
        public List<ManageLimit> GetManageLimit()
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
        public List<Orders> ThinPurState()
        {
            var list = SqlSugarHelper<Orders>.FindAll();
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
        /// 额度详情
        /// </summary>
        /// <returns></returns>
        public List<ManageLimit> ThinMaLimite()
        {
            var list = SqlSugarHelper<ManageLimit>.FindAll();
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
            var result = GetSimpleInstance<ManageLimit>().Update(it => new ManageLimit() { State = states }, it => it.Id == id);
            return (result);
        } 
    }
}

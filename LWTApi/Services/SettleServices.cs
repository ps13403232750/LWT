using System;
using System.Collections.Generic;
using System.Text;

using SqlSugar;
using Model;
using IServices;
namespace Services
{
   public  class SettleServices: BaseDB,ISettleServices
    {
        SimpleClient<ManageLimit> ML = new SimpleClient<ManageLimit>(GetInstance());
        SimpleClient<PurChaseNumber> CN = new SimpleClient<PurChaseNumber>(GetInstance());
        SimpleClient<PurChasePay> CP = new SimpleClient<PurChasePay>(GetInstance());
        SimpleClient<PurChaseSettle> CS = new SimpleClient<PurChaseSettle>(GetInstance());

        /// <summary>
        /// 额度表显示
        /// </summary>
        /// <returns></returns>
        public List<ManageLimit> GetManageLimits()
        {
            return ML.GetList();
        }

        /// <summary>
        /// 结算次数
        /// </summary>
        /// <returns></returns>
        public List<PurChaseNumber>GetPurChaseNumber()
        {
            return CN.GetList();
        }

        /// <summary>
        /// 采购付款结算列表
        /// </summary>
        /// <returns></returns>
        public List<PurChasePay> GetPurChasePay()
        {
            return CP.GetList();
        }

        /// <summary>
        /// 采购结算列表
        /// </summary>
        /// <returns></returns>
        public List<PurChaseSettle> GetPurChaseSettle()
        {
            return CS.GetList();
        }
    }
}

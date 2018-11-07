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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// 采购结算列表
        /// </summary>
        /// <returns></returns>
        public List<PurChaseSettle> GetPurChaseSettle()
        {
            throw new NotImplementedException();
        }
    }
}

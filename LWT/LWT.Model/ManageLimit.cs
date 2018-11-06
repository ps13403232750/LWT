using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
   public class ManageLimit
    {
        /// <summary>
        /// 额度id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 企业采购名称
        /// </summary>
        public string BuyerName { get; set; }

        /// <summary>
        /// 结算方式
        /// </summary>
        public string SettLemeny { get; set; }

        /// <summary>
        /// 总额度额度
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// 申请额度
        /// </summary>
        public int  ApplyAmount { get; set; }

        /// <summary>
        /// 运营商审核状态
        /// </summary>
        public int BuyerState { get; set; }

        /// <summary>
        /// 审批额度
        /// </summary>
        public int AppRoveLimit { get; set; }
    }
}

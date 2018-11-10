using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
    /// <summary>
    /// 采购商结算详情列表
    /// </summary>
   public class PurChasePay
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 企业采购名称
        /// </summary>
        public string BuyerName { get; set; }

        /// <summary>
        /// 结算方式
        /// </summary>
        public string SettleMeny { get; set; }

        /// <summary>
        /// 结算周期
        /// </summary>
        public string SettleDays { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
    }
}

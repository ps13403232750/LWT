using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
    /// <summary>
    /// 采购商列表
    /// </summary>
   public class PurChaseSettle
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 采购商名称
        /// </summary>
        public string BuyerName { get; set; }

        /// <summary>
        /// 结算类型
        /// </summary>
        public string SettleMeny { get; set; }

        /// <summary>
        /// 结算周期
        /// </summary>
        public string SettleDays { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int SettleState { get; set; }
    }

}

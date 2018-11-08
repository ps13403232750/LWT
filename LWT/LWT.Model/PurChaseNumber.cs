using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
    /// <summary>
    /// 结算次数
    /// </summary>
   public class PurChaseNumber
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 采购商
        /// </summary>
        public string BuyerName{ get; set; }

        /// <summary>
        /// 结算年数
        /// </summary>
        public int Years { get; set; }

        /// <summary>
        /// 结算次数
        /// </summary>
        public string SettleNumber { get; set; }

        /// <summary>
        /// 结算状态
        /// </summary>
        public int SettleState { get; set; }
    }
}

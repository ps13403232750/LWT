using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LWT.Client.Models
{
    /// <summary>
    /// 额度管理表
    /// </summary>
    public class ManageLimit
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 企业采购名称
        /// </summary>
        public string BuyerName { get; set; }
        /// <summary>
        /// 结算方式
        /// </summary>
        public string Settlemeny { get; set; }
        /// <summary>
        /// 总额度
        /// </summary>
        public string TotalAmount { get; set; }
        /// <summary>
        /// 申请额度
        /// </summary>
        public string ApplyAmount { get; set; }
        /// <summary>
        /// 审核状态
        /// </summary>
        public int BuyerState { get; set; }
        /// <summary>
        /// 审批额度
        /// </summary>
        public string ApproveLimit { get; set; }
    }
}

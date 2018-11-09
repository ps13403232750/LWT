﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Limit
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
        public string AccountMode { get; set; }

        /// <summary>
        /// 总额度
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// 申请额度
        /// </summary>
        public int  ApplyAmount { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 审批额度
        /// </summary>
        public int ApproveAmount { get; set; }
    }
}
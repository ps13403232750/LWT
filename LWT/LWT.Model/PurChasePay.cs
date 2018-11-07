﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
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
        /// 确认方式
        /// </summary>
        public string AffirmWay { get; set; }

        /// <summary>
        /// 结算周期
        /// </summary>
        public string SettleDays { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime createTime { get; set; }
    }
}
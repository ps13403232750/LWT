using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
   public class PurChase
    {
        /// <summary>
        /// 采购员id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        public string LinkManName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        public string LinkPhone { get; set; }

        /// <summary>
        /// 年营业额
        /// </summary>
        public string YearTurnove { get; set; }

        /// <summary>
        /// 结算账期
        /// </summary>
        public DateTime SettleDateTime { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        public string LinkManEmail { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        public string BusinessLicence { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 企业logo
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// 商家简介
        /// </summary>
        public string BusinessMark { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }
    }
}

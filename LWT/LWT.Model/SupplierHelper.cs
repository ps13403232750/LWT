using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
   public class SupplierHelper
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 公司名称    
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string StoreName { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string LinkMan { get; set; }

        /// <summary>
        ///  联系邮箱   
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
        /// 销售类目
        /// </summary>
        public string SalesId { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// 销售区域
        /// </summary>
        public int Aid { get; set; }

        /// <summary>
        /// 商家简介
        /// </summary>
        public string BusinessMark { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 地域名称
        /// </summary>
        public string AreaName { get; set; }
    }
}

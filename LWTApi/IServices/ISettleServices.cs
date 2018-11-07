using System;
using System.Collections.Generic;
using System.Text;

using Model;
namespace IServices
{
   public  interface ISettleServices
    {
        /// <summary>
        /// 额度管理表
        /// </summary>
        /// <returns></returns>
        List<ManageLimit> GetManageLimits();
        /// <summary>
        /// 结算次数
        /// </summary>
        /// <returns></returns>
        List<PurChaseNumber> GetPurChaseNumber();
    }
}

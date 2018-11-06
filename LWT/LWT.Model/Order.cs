using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
  public class Order
    {
        /// <summary>
        /// 订单id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNum { get; set; }

        /// <summary>
        /// 订货日期
        /// </summary>
        public string OrderTime { get; set; }

        /// <summary>
        /// 订单总价
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 采购商Id
        /// </summary>
        public int UserId { get; set; }
    }
}

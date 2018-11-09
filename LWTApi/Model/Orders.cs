using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
<<<<<<< HEAD:LWTApi/Model/Orders.cs
    /// <summary>
    /// 订单表
    /// </summary>
=======
>>>>>>> 682a16cf446d1ad0f0432d91973e042bd148449a:LWTApi/Model/Orders.cs
  public class Orders
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
        public float Price { get; set; }

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

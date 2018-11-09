using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 订单从表
    /// </summary>
   public class OrderList
    {
        /// <summary>
        /// 订单从表ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 关联订单
        /// </summary>
        public int OrderNum { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        public float GoodsPrice { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int GoodsNum { get; set; }
    }
}

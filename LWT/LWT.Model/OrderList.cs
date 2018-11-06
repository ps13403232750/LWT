using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
   public class OrderList
    {
        public int Id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 关联订单
        /// </summary>
        public string OrderNum { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        public int GoodsPrice { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        public int GoodsNum { get; set; }
    }
}

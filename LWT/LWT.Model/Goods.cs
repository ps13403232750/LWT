using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
   public class Goods
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 商品名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商品图片
        /// </summary>
        public string Img { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        public string Band { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 规格属性
        /// </summary>
        public string Attribute { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 库存量
        /// </summary>
        public int Inventory  { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public int Isable { get; set; }
    }
}

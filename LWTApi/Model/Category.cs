using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Category
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 父级Id
        /// </summary>
        public int Pid { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
    }
}

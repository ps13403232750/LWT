using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class PageResult<T>
    {
        /// <summary>
        /// 总条数
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPage { get; set; }
        /// <summary>
        /// 返回的数据集合
        /// </summary>
        public List<T> DataList { get; set; }
    }
}

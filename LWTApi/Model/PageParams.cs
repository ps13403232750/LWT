using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class PageParams
    {
        public PageParams()
        {
            StrWhere = "";
            SortRow = "";
            SortMethod = "";
            CurPage = 1;
            PageSize = 5;

        }
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// 查询条件
        /// </summary>
        public string StrWhere { get; set; }
        /// <summary>
        /// 排序列
        /// </summary>
        public string SortRow { get; set; }
        /// <summary>
        /// 排序方式
        /// </summary>
        public string SortMethod { get; set; }
        /// <summary>
        /// 当前页
        /// </summary>
        public int CurPage { get; set; }
        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int PageSize { get; set; }

    }
}

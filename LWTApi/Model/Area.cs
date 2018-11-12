using System;

namespace Model
{
    public class Area
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int AId { get; set; }

        /// <summary>
        /// 地域名称
        /// </summary>
        public string AreaName { get; set; }

        /// <summary>
        /// 父级Id
        /// </summary>
        public string FatherId { get; set; }
    }
}

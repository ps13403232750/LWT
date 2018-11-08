using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Roles
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
    }
}

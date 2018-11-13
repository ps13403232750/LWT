using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class UserData
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 用户角色ID
        /// </summary>
        public int RoleId { get; set; }
    }
}

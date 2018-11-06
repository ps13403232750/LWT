﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LWT.Model
{
   public class Power
    {
        /// <summary>
        /// 权限id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        public string PowerName { get; set; }

        /// <summary>
        /// 父级id
        /// </summary>
        public int Pid { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 页面地址路径
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}

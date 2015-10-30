﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChuanQi.Web.Models
{

    public class SaleInfo
    {
        public string ID { get; set; }
        /// <summary>
        /// 角色名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 寄卖物品
        /// </summary>
        public string Product { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime SubTime { get; set; }
        /// <summary>
        /// 所在分区
        /// </summary>
        public string Place { get; set; }

    }
}

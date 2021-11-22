using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class SysDept : BaseModel
    {
        /// <summary>
        /// 组织机构表
        /// </summary>
        public SysDept()
        {
            ID = Guid.NewGuid().ToString("N");
            DelFlag = 0;
            OrderIndex = 99;
            status = 0;
            memo = "";
            Name = "";
            PID = "";
            BH = "";
        }
        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("名称")]
        public string Name { get; set; }

        /// <summary>
        /// 父级
        /// </summary>

        [DisplayName("父级")]
        public string PID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>

        [DisplayName("编号")]
        public string BH { get; set; }
       
        /// <summary>
        /// 排序
        /// </summary>

        [DisplayName("排序")]
        public int OrderIndex { get; set; }

        [DisplayName("删除标志")]
        public int DelFlag { get; set; }

        /// <summary>
        /// 备注
        /// </summary>

        [DisplayName("备注")]
        public string memo { get; set; }

        /// <summary>
        /// 状态0-在用 1-停用
        /// </summary>
        [DisplayName("状态0-在用 1-停用")]
        public int status { get; set; }



    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;

namespace BusModels
{
    public partial class SysDictCode : BaseModel
    {
        /// <summary>
        /// 字典类别表
        /// </summary>
        public SysDictCode()
        {
            ID = Guid.NewGuid().ToString("N");

            State = 1;
            OrderIndex = 0;
            Code = "";
            Name = "";


        }

        /// <summary>
        /// 字典类别值
        /// </summary>
        [DisplayName("字典类别值")]
        public string Code { get; set; }


        /// <summary>
        /// 字典类别名称
        /// </summary>
        [DisplayName("字典类别名称")]
        public string Name { get; set; }


        /// <summary>
        /// 字典类别排序
        /// </summary>
        [DisplayName("类别排序")]
        public int OrderIndex { get; set; }

        /// <summary>
        /// 字典状态
        /// </summary>
        [DisplayName("类别状态")]
        public int State { get; set; }


    }
}

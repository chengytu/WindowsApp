using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class SysDict : BaseModel
    {
        /// <summary>
        /// 字典属性值表
        /// </summary>
        public SysDict()
        {
            ID = Guid.NewGuid().ToString("N");
            State =1;
            OrderIndex = 99;
        }


        public string DictCode { get; set; }

        /// <summary>
        /// 类型值
        /// </summary>
       
        [DisplayName("类型值")]
        public string DValue { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
       
        [DisplayName("类型名称")]
        public string DText { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
     
        [DisplayName("排序")]
        public int OrderIndex { get; set; }



        [DisplayName("状态")]
        public int State { get; set; }

    }
}

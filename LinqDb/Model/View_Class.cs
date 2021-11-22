using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class View_Class : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public View_Class()
        {

            ID = Guid.NewGuid().ToString("N");
            ClassName = "";
           
        }


        ///// <summary>
        ///// 名称
        ///// </summary>
        //[DisplayName("名称")]
        //public string guid { get; set; }


        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("num")]
        public int num { get; set; }

       

        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("班级")]
        public string ClassName { get; set; }


        
    }
}


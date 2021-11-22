using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class View_word_college : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public View_word_college()
        {

            ID = Guid.NewGuid().ToString("N");
            cword = "";
            cexpression = "";
           
        }


        ///// <summary>
        ///// 名称
        ///// </summary>
        //[DisplayName("名称")]
        //public string guid { get; set; }


        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("单词序")]
        public string ID { get; set; }



        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("单词")]
        public string cword { get; set; }


        /// <summary>
        /// 单词解释
        /// </summary>
        [DisplayName("解释")]
        public string cexpression { get; set; }



    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class View_WordPart : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public View_WordPart()
        {
            ID = Guid.NewGuid().ToString("N");
            type = "";
            num = 0;
        }


        ///// <summary>
        ///// 名称
        ///// </summary>
        //[DisplayName("名称")]
        //public string guid { get; set; }


        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("单词数量")]
        public int num { get; set; }



        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("单词类别")]
        public string type { get; set; }





    }
}


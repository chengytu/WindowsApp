using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class View_graduword_len : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public View_graduword_len()
        {
            ID = Guid.NewGuid().ToString("N");
            wordlen = 1;
            num = 0;
        }


        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("单词数量")]
        public int num { get; set; }



        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("单词长度")]
        public int wordlen { get; set; }





    }
}


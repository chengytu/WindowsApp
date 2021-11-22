using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class word_graduate : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public word_graduate()
        {
            IID = 0;
            ID = Guid.NewGuid().ToString("N");
            word = "";
            exp = "";
            testrank = 10;
            wordlen = 0;
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
        public int IID { get; set; }



        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("单词")]
        public string word { get; set; }



        /// <summary>
        /// 单词解释
        /// </summary>
        [DisplayName("解释")]
        public string exp { get; set; }



        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("单词级别")]
        public int testrank { get; set; }

        /// <summary>
        /// 单词长度
        /// </summary>
        [DisplayName("单词长度")]
        public int wordlen { get; set; }



    }
}


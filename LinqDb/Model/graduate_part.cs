
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class graduate_part : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public graduate_part()
        {
           ID = Guid.NewGuid().ToString("N");
            word = "";
            type = "";
            ctxt = "";
            etxt = "";
            type = "";
            num = 10;
          

        }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("单词")]
        public string word { get; set; }



        /// <summary>
        /// 单词解释
        /// </summary>
        [DisplayName("类型")]
        public string type { get; set; }



        /// <summary>
        /// 单词解释
        /// </summary>
        [DisplayName("类型")]
        public string ctxt { get; set; }

        /// <summary>
        /// 单词解释
        /// </summary>
        [DisplayName("类型")]
        public string etxt { get; set; }



        /// <summary>
        /// 单词长度
        /// </summary>
        [DisplayName("数量")]
        public int num { get; set; }



    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class word_page_syn : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public word_page_syn()
        {
            ID = Guid.NewGuid().ToString("N");
            type = "";
            word = "";
            exp = "";
            memo = "";
           


        }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("页面编号")]
        public string type { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("句子编号")]
        public string word { get; set; }


        /// <summary>
        /// 句子内容
        /// </summary>
        [DisplayName("句子内容")]
        public string exp { get; set; }

        /// <summary>
        /// 句子音频
        /// </summary>
        [DisplayName("句子音频")]
        public string memo { get; set; }

       
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class view_word_page_syn_type : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public view_word_page_syn_type()
        {
            ID = Guid.NewGuid().ToString("N");
            type = "";
           
            num =0;



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
        public int num { get; set; }


    }
}


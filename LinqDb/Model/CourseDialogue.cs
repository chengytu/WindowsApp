using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class CourseDialogue : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public CourseDialogue()
        {
            ID = Guid.NewGuid().ToString("N");
            PageBH = "";
            SentenceBH = "";
            Sentence = "";            
            SentenceMp3 = "";
            Memo = "";
            SentencePic = "";
            PicArea = "";
            ShowIndex = "";
            State = 0;
            


        }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("页面编号")]
        public string PageBH { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("句子编号")]
        public string SentenceBH { get; set; }


        /// <summary>
        /// 句子内容
        /// </summary>
        [DisplayName("句子内容")]
        public string Sentence { get; set; }
       
        /// <summary>
        /// 句子音频
        /// </summary>
        [DisplayName("句子音频")]
        public string SentenceMp3 { get; set; }

        /// <summary>
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        public string  Memo { get; set; }

        /// <summary>
        /// 句子图片
        /// </summary>
        [DisplayName("句子图片")]
        public string  SentencePic { get; set; }

        /// <summary>
        /// 图片区域
        /// </summary>
        [DisplayName("图片区域")]
        public string PicArea { get; set; }


        /// <summary>
        /// 索引
        /// </summary>
        [DisplayName("索引")]
        public string  ShowIndex { get; set; }

        /// <summary>
        /// 状态0-在用 1-停用
        /// </summary>
        [DisplayName("状态0-在用 1-停用")]
        public int State { get; set; }


    }
}


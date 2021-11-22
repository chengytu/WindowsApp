using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;



namespace BusModels
{
    public partial class CourseWord : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public CourseWord()
        {
            ID = Guid.NewGuid().ToString("N");
            PageBH = "";
            WordBH = "";
            Word = "";           
            WordMp3 = "";
            Memo = "";
            WordPic = "";
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
        [DisplayName("单词编号")]
        public string WordBH { get; set; }

        /// <summary>
        /// 单词内容
        /// </summary>
        [DisplayName("单词内容")]
        public string Word { get; set; }

        /// <summary>
        /// 单词音频
        /// </summary>
        [DisplayName("单词音频")]
        public string WordMp3 { get; set; }

        /// <summary>
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        public string Memo { get; set; }

        /// <summary>
        /// 单词图片
        /// </summary>
        [DisplayName("单词图片")]
        public string WordPic { get; set; }

        /// <summary>
        /// 图片区域
        /// </summary>
        [DisplayName("图片区域")]
        public string PicArea { get; set; }

        /// <summary>
        /// 索引
        /// </summary>
        [DisplayName("索引")]
        public string ShowIndex { get; set; }
      
        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName("状态0-在用 1-停用")]
        public int State { get; set; }


    }
}


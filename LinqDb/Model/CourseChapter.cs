using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class CourseChapter : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public CourseChapter()
        {
            ID = Guid.NewGuid().ToString("N");
            CourseBH = "";
            ChapterBH = "";
            Title = "";
            Pic = "";
            Memo = "";
            IsHaveExpand = 0;
            State = 0;
        }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("编号")]
        public string CourseBH { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("单元编号")]
        public string ChapterBH { get; set; }


        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("单元名称")]
        public string Title { get; set; }

        /// <summary>
        /// 父级
        /// </summary>

        [DisplayName("单元图片")]
        public string Pic { get; set; }

        /// <summary>
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        public string Memo { get; set; }


        /// <summary>
        /// 是否有教材拓展   0-没有 1-有
        /// </summary>
        [DisplayName("有无拓展 0-无 1-有")]
        public int IsHaveExpand { get; set; }


        /// <summary>
        /// 状态0-在用 1-停用
        /// </summary>
        [DisplayName("状态0-在用 1-停用")]
        public int State { get; set; }



    }
}


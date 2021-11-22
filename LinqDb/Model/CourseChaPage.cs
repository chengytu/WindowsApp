using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class CourseChaPage : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public CourseChaPage()
        {
            ID = Guid.NewGuid().ToString("N");
            ChapterBH = "";
            PageBH = "";
            Name = "";
            SongUrl = "";
            bkPicUrl = "";
            bkHeight = 0;
            bkWidth = 0;
            Showcontent = "";
            State = 0;
            IsExpand = 0;
            OrderIndex = 0;
           
           
        }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("单元编号")]
        public string ChapterBH { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("页面编号")]
        public string PageBH { get; set; }


        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("名称")]
        public string Name { get; set; }

        // <summary>
        /// 歌曲
        /// </summary>
        [DisplayName("歌曲")]
        public string SongUrl { get; set; }

        /// <summary>
        /// 页面图片
        /// </summary>
        [DisplayName("PagePic")]
        public string bkPicUrl { get; set; }

        /// <summary>
        /// <summary>
        /// 图片高度
        /// </summary>
        [DisplayName("图片高度")]
        public int bkHeight { get; set; }

        /// <summary>
        /// 图片宽度
        /// </summary>
        [DisplayName("图片宽度")]
        public int bkWidth { get; set; }

        /// <summary>
        /// 展示类型
        /// </summary>
        [DisplayName("展示类型")]
        public string Showcontent { get; set; }

        /// <summary>
        /// 状态0-在用 1-停用
        /// </summary>
        [DisplayName("状态0-在用 1-停用")]
        public int State { get; set; }

        /// <summary>
        /// 教材拓展标识   0-教材 1-拓展
        /// </summary>
        [DisplayName("教材拓展标识 0-教材 1-拓展")]
        public int IsExpand { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("OrderIndex")]
        public int OrderIndex { get; set; }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class CourseVideo : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public CourseVideo()
        {
            ID = Guid.NewGuid().ToString("N");
            PageBH = "";
            VideoBH = "";
            VideoName = "";
            VideoUrl = "";
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
        [DisplayName("视频编号")]
        public string VideoBH { get; set; }


        /// <summary>
        /// 视频名称
        /// </summary>
        [DisplayName("视频名称")]
        public string VideoName { get; set; }

        // <summary>
        /// 视频路径
        /// </summary>
        [DisplayName("视频路径")]
        public string VideoUrl { get; set; }

       
        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName("状态0-在用 1-停用")]
        public int State { get; set; }


    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class view_Course_ChapPage : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public view_Course_ChapPage()
        {
            ID = Guid.NewGuid().ToString("N");
            Coursebh = "";
            bh = "";
            name = "";



        }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("课程编号")]
        public string Coursebh { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("编号")]
        public string bh { get; set; }


        /// <summary>
        /// 句子内容
        /// </summary>
        [DisplayName("名称")]
        public string name { get; set; }





    }
}


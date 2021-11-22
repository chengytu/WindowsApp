using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class View_gWord_lenTspace : BaseModel
    {
        /// <summary>
        /// 单词长度表
        /// </summary>
        public View_gWord_lenTspace()
        {
            ID = Guid.NewGuid().ToString("N");
            ch = "";
            c1 = "";
            c2 = "";
            c3 = "";
            c4 = "";
            c5 = "";
            c6 = "";
            c7 = "";
            c8 = "";
            c9 = "";
            c10 = "";
            c11 = "";
            c12 = "";
            c13 = "";
            c14 = "";
            c15 = "";
            c16 = "";
        }


        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("单词首字符")]
        public string ch { get; set; }



        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度1数量")]
        public string c1 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为2数量")]
        public string c2 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为3数量")]
        public string c3 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为4数量")]
        public string c4 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为5数量")]
        public string c5 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为6数量")]
        public string c6 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为7数量")]
        public string c7 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为8数量")]
        public string c8 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为9数量")]
        public string c9 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为10数量")]
        public string c10 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为11数量")]
        public string c11 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为12数量")]
        public string c12 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为13数量")]
        public string c13 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为14数量")]
        public string c14 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为15数量")]
        public string c15 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为16数量")]
        public string c16 { get; set; }





    }
}


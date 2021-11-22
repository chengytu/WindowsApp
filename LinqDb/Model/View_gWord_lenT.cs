using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class View_gWord_lenT : BaseModel
    {
        /// <summary>
        /// 单词长度表
        /// </summary>
        public View_gWord_lenT()
        {
            ID = Guid.NewGuid().ToString("N");
            ch ="";
            c1 = 0;
            c2 = 0;
            c3 = 0;
            c4 = 0;
            c5 = 0;
            c6 = 0;
            c7 = 0;
            c8 = 0;
            c9 = 0;
            c10 = 0;
            c11 = 0;
            c12 = 0;
            c13 = 0;
            c14 = 0;
            c15 = 0;
            c16 = 0;
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
        public int c1 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为2数量")]
        public int c2 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为3数量")]
        public int c3 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为4数量")]
        public int c4 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为5数量")]
        public int c5 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为6数量")]
        public int c6 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为7数量")]
        public int c7 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为8数量")]
        public int c8 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为9数量")]
        public int c9 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为10数量")]
        public int c10 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为11数量")]
        public int c11 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为12数量")]
        public int c12 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为13数量")]
        public int c13 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为14数量")]
        public int c14 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为15数量")]
        public int c15 { get; set; }


        /// <summary>
        /// 单词
        /// </summary>
        [DisplayName("长度为16数量")]
        public int c16 { get; set; }





    }
}


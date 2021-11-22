using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class easy : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public easy()
        {
            ProjectName = Guid.NewGuid().ToString("N");
            ProjectCode = "";
            MicroBarCode = "";
            TestTime = "";
            Reagentmanufacturer = "";
            Reagentlotnumber = "";
            Operator = "";
            Wave = "";
            Reference = "";
            CUTOFF = "";
               sign= 0;
            Abnormal  = "";
            normal  = "";





        }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("项目名称")]
        public string ProjectName  { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [DisplayName("项目代码")]
        public string ProjectCode { get; set; }


        /// <summary>
        /// 句子内容
        /// </summary>
        [DisplayName("微板条码")]
        public string MicroBarCode  { get; set; }

        /// <summary>
        /// 句子音频
        /// </summary>
        [DisplayName("测试时间")]
        public string TestTime { get; set; }

        /// <summary>
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("试剂厂家")]
        public string Reagentmanufacturer { get; set; }

        /// <summary>
        /// 句子图片
        /// </summary>
        [DisplayName("试剂批号")]
        public string  Reagentlotnumber { get; set; }

        /// <summary>
        /// 图片区域
        /// </summary>
        [DisplayName("操作人")]
        public string Operator { get; set; }
[DisplayName("波长")]
public string Wave { get; set; }
[DisplayName("参考波长")]
public string Reference { get; set; }






        /// <summary>
        /// 索引
        /// </summary>
        [DisplayName("CUTOFF")]
        public string CUTOFF { get; set; }

        /// <summary>
        /// 状态0-在用 1-停用
        /// </summary>
        [DisplayName("标志0-在用 1-无效")]
        public int sign{ get; set; }
        [DisplayName("异常样本")]
public string Abnormal { get; set; }
[DisplayName("正常样本")]
public string normal { get; set; }
 

    }
}


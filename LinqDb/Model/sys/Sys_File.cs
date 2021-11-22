using System;
using System.Collections.Generic;

namespace BusModels
{
    /// <summary>
    /// 文件Model
    /// </summary>
    public partial class SysFile : BaseModel
    {
        public SysFile()
        {
            RelID = "";
            CreateTime = DateTime.Now;
            Ispc = 0;
            FileName = "";
            Url = "";
            FType = "";
            Ispc = 0;

        }
        /// <summary>
        /// 关联ID
        /// </summary>
        public string RelID { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string FType { get; set; }


        
        /// <summary>
        /// 0文件   1 图片
        /// </summary>
        public int Ispc { get; set; }


        /// <summary>
        /// 文件创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }


        /// <summary>
        /// 备注名称
        /// </summary>
        public string RelName { get; set; }

        
    }
}

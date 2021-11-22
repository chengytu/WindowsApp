using System;
using System.Collections.Generic;

namespace BusModels
{
    /// <summary>
    /// �ļ�Model
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
        /// ����ID
        /// </summary>
        public string RelID { get; set; }

        /// <summary>
        /// �ļ�����
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// ��ַ
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string FType { get; set; }


        
        /// <summary>
        /// 0�ļ�   1 ͼƬ
        /// </summary>
        public int Ispc { get; set; }


        /// <summary>
        /// �ļ�����ʱ��
        /// </summary>
        public DateTime CreateTime { get; set; }


        /// <summary>
        /// ��ע����
        /// </summary>
        public string RelName { get; set; }

        
    }
}

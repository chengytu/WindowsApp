using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class SysDict : BaseModel
    {
        /// <summary>
        /// �ֵ�����ֵ��
        /// </summary>
        public SysDict()
        {
            ID = Guid.NewGuid().ToString("N");
            State =1;
            OrderIndex = 99;
        }


        public string DictCode { get; set; }

        /// <summary>
        /// ����ֵ
        /// </summary>
       
        [DisplayName("����ֵ")]
        public string DValue { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
       
        [DisplayName("��������")]
        public string DText { get; set; }

        /// <summary>
        /// ����
        /// </summary>
     
        [DisplayName("����")]
        public int OrderIndex { get; set; }



        [DisplayName("״̬")]
        public int State { get; set; }

    }
}

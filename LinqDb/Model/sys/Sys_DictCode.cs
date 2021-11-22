using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;

namespace BusModels
{
    public partial class SysDictCode : BaseModel
    {
        /// <summary>
        /// �ֵ�����
        /// </summary>
        public SysDictCode()
        {
            ID = Guid.NewGuid().ToString("N");

            State = 1;
            OrderIndex = 0;
            Code = "";
            Name = "";


        }

        /// <summary>
        /// �ֵ����ֵ
        /// </summary>
        [DisplayName("�ֵ����ֵ")]
        public string Code { get; set; }


        /// <summary>
        /// �ֵ��������
        /// </summary>
        [DisplayName("�ֵ��������")]
        public string Name { get; set; }


        /// <summary>
        /// �ֵ��������
        /// </summary>
        [DisplayName("�������")]
        public int OrderIndex { get; set; }

        /// <summary>
        /// �ֵ�״̬
        /// </summary>
        [DisplayName("���״̬")]
        public int State { get; set; }


    }
}

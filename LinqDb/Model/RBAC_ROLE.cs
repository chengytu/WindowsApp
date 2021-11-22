using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class RBAC_ROLE : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public RBAC_ROLE()
        {
            ID = Guid.NewGuid().ToString("N");
            ROLENAME = "";
            Memo = "";
            CREATEDATE = DateTime.Now;
            State = 0;
        }
        /// <summary>
        /// 权限名称
        /// </summary>
        [DisplayName("权限名称")]
        public string ROLENAME { get; set; }


        /// <summary>
        /// 说明
        /// </summary>
        [DisplayName("说明")]
        public string Memo { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CREATEDATE { get; set; }


        /// <summary>
        /// 状态0-在用 1-停用
        /// </summary>
        [DisplayName("状态0-在用 1-停用")]
        public int State { get; set; }



    }
}


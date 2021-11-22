using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class SYS_USER : BaseModel
    {
        /// <summary>
        /// 课程表
        /// </summary>
        public SYS_USER()
        {
            ID = Guid.NewGuid().ToString("N");
            Login = "";
            UserName = "";
            Pwd = "";
            RoleID = "";
            CreateDate = DateTime.Now;
            State = 0;
        }
        /// <summary>
        /// 登录名
        /// </summary>
        [DisplayName("登录名")]
        public string Login { get; set; }


        /// <summary>
        /// 用户名
        /// </summary>
        [DisplayName("用户名")]
        public string UserName { get; set; }


        /// <summary>
        /// 密码
        /// </summary>
        [DisplayName("密码")]
        public string  Pwd { get; set; }


        /// <summary>
        /// 权限
        /// </summary>
        [DisplayName("权限")]
        public string RoleID { get; set; }


        /// <summary>
        /// 创建
        /// </summary>
        [DisplayName("创建")]
        public DateTime  CreateDate { get; set; }


        /// <summary>
        /// 状态0-在用 1-停用
        /// </summary>
        [DisplayName("状态0-在用 1-停用")]
        public int State { get; set; }

        //public virtual RBAC_ROLE UserRole { get; set; }

    }
}


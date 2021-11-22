using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public partial class SysUser : BaseModel
    {
        /// <summary>
        /// 用户表
        /// </summary>
        public SysUser()
        {
            ID = Guid.NewGuid().ToString("N");

            CreateDate = DateTime.Now;
            Login = "";
            OrderIndex = 99;
            State = 1;
        }
        /// <summary>
        /// 姓名
        /// </summary>
        [DisplayName("姓名")]
        public string UserName { get; set; }

        /// <summary>
        /// 登陆账号
        /// </summary>

        [DisplayName("登陆账号")]
        public string Login { get; set; }

        /// <summary>
        /// 密码
        /// </summary>

        [DisplayName("密码")]
        public string Pwd { get; set; }
        /// <summary>
        /// 所在部门
        /// </summary>


        [DisplayName("角色")]
        public string RoleID { get; set; }

        /// <summary>
        /// 文件创建时间
        /// </summary>
        [DisplayName("入驻时间")]
        public DateTime CreateDate { get; set; }

        
        /// <summary>
        /// 排序
        /// </summary>

        [DisplayName("排序")]
        public int OrderIndex { get; set; }



        [DisplayName("状态")]
        public int State { get; set; }


    }
}


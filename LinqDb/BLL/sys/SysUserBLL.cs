
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusModels;
using System.Threading.Tasks;

namespace BLLFactory
{
    public class SysUserBLL : BaseBLL<SysUser>
    {
        /// <summary>
        /// 此方法只在登陆时使用一次
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public SysUser CopyUseToBase(SysUser model)
        {
            if (model == null)
                return null;
            SysUser user = new SysUser();

            user.ID = model.ID;

            user.Login = model.Login;
            user.Pwd = model.Pwd;
            user.OrderIndex = model.OrderIndex;
            user.RoleID = model.RoleID;
            user.UserName = model.UserName;
            user.State = model.State;

            return user;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class RBAC_ROLEBLL : BaseBLL<RBAC_ROLE>
    {
        public RBAC_ROLE getDataById(string tid)
        {
            return this.Fetch().FirstOrDefault(t => t.ID == tid);

        }

        public List<RBAC_ROLE> getAllRoleId()
        {
            return this.Fetch(t => t.State == 1).OrderBy(t => t.ID).ToList();

        }

    }
}

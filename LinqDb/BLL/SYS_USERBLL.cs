using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class SYS_USERBLL : BaseBLL<SYS_USER>
    {
        public SYS_USER getDataByID(string tid)
        {
            return this.Fetch().FirstOrDefault(t => t.ID == tid);

        }

        //public List<dict_LiquidType> getAllCourse()
        //{
        //    return this.Fetch(t => t.State == 1).OrderBy(t => t.CourseBH).ToList();

        //}

    }
}

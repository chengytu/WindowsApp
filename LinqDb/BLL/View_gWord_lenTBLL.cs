using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class View_gWord_lenTBLL : BaseBLL<View_gWord_lenT>
    {

        public List<View_gWord_lenT> getALLData()
        {
            List<View_gWord_lenT> lst = this.Fetch().OrderBy(t => t.ch).ToList();
            return lst;

        }

    }
}

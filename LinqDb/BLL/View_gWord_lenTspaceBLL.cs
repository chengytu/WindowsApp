using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class View_gWord_lenTspaceBLL : BaseBLL<View_gWord_lenTspace>
    {

        public List<View_gWord_lenTspace> getALLData()
        {
            List<View_gWord_lenTspace> lst = this.Fetch().OrderBy(t => t.ch).ToList();
            return lst;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{

    public class View_ClassBLL : BaseBLL<View_Class>
    {

        /*
        public word_collegeBLL getDataById(string tid)
        {
            return this.Fetch().FirstOrDefault(t => t.ID == tid);

        }
        */
       
       public List<View_Class> getALLData()
       {
                List<View_Class> lst = this.Fetch().OrderBy(t => t.ClassName).ToList();
                return lst;
       }

    }
}




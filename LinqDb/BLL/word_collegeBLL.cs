using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{

    public class word_collegeBLL : BaseBLL<View_word_college>
    {

        /*
        public word_collegeBLL getDataById(string tid)
        {
            return this.Fetch().FirstOrDefault(t => t.ID == tid);

        }
        */
       
       public List<View_word_college> getALLData()
       {
                List<View_word_college> lst = this.Fetch().OrderBy(t => t.ID).ToList();
                return lst;
       }

    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class View_graduword_lenBLL : BaseBLL<View_graduword_len>
    {
      
        public List<View_graduword_len> getALLData()
        {
            List <View_graduword_len> lst= this.Fetch().OrderBy(t => t.wordlen).ToList();
            return lst;

        }

    }
}

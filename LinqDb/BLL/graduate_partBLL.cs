
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class graduate_partBLL : BaseBLL<graduate_part>
    {
        public graduate_part getDataByID(string tid)
        {
            return this.Fetch().FirstOrDefault(t => t.ID == tid);

        }

        public List<graduate_part> getWordByType(string type)
        {
            List <graduate_part> lst= this.Fetch(t => t.type == type).OrderBy(t => t.word).ToList();
            return lst;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class word_page_synBLL : BaseBLL<word_page_syn>
    {
        public word_page_syn getDataById(string tid)
        {
            return this.Fetch().FirstOrDefault(t => t.ID == tid);

        }

        public List<word_page_syn> getDataByType(string ttype)
        {
            return this.Fetch(t => t.type == ttype).OrderBy(t => t.word).ToList();

        }

    }
}

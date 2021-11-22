
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class word_graduateBLL : BaseBLL<word_graduate>
    {
        public word_graduate getDataByID(string tid)
        {
            return this.Fetch().FirstOrDefault(t => t.ID == tid);

        }

       public List<word_graduate> getWordByLen(int len)
        {
            return this.Fetch(t => t.wordlen == len).OrderBy(t => t.word).ToList();

        }

    }
}

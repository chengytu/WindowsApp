using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class view_word_page_syn_typeBLL : BaseBLL<view_word_page_syn_type>
    {
      

        public List<view_word_page_syn_type> getAllData()
        {
            return this.Fetch().OrderBy(t => t.type).ToList();

        }

    }
}

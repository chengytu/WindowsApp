
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class View_WordPartBLL : BaseBLL<View_WordPart>
    {
        public List<View_WordPart> getAllData()
        {
            return this.Fetch().OrderBy(t => t.type).ToList();

        }


    }
}

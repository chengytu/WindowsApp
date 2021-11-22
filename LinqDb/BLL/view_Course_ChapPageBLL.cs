using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class view_Course_ChapPageBLL : BaseBLL<view_Course_ChapPage>
    {
        public List<view_Course_ChapPage> getDataByCoursebh(string tbh)
        {
            return this.Fetch(t => t.Coursebh == tbh).OrderBy(t=>t.bh).ToList();

        }

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;

namespace BLLFactory
{
    public class easyBLL : BaseBLL<easy>
    {
        public easy getMicroBarCode(string tmicrobarcode)
        {
            return this.Fetch().FirstOrDefault(t => t.MicroBarCode == tmicrobarcode);
        }

        public List<easy> gettMicroBarCode(string tpagebh)
        {
            return this.Fetch().Where(t => t.ProjectName == tpagebh).OrderBy(t => t.MicroBarCode).ToList();
            //return this.Fetch().Where(m => m.DictCode == strcode && m.DelFlag == 0).OrderBy(p => p.OrderIndex).ToList();
        }



    }
}

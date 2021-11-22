using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusModels
{
    [Serializable]
    public class BaseModelExt
    {
        IList<string> _UpdateFields = new List<string>();
        public IList<string> UpdateFields { get { return _UpdateFields; } set { _UpdateFields = value; } }
    }
}

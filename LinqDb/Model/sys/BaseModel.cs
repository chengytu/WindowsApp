using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BusModels
{
    /// <summary>
    /// 所有model必须继承此类
    /// </summary>
    [Serializable]
    public class BaseModel: BaseModelExt
    {
        public BaseModel() {
            ID = Guid.NewGuid().ToString("N");
            
        }
        [DisplayName("主键")]
        public string ID { get; set; }

        ///// <summary>
        ///// 需要更新的字段
        ///// </summary>
        //public IList<string> UpdateFields { get; set; }
       
    }
}

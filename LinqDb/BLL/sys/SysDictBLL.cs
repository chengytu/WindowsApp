using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusModels;
namespace BLLFactory
{
    public class SysDictBLL : BaseBLL<SysDict>
    {



        /*
         此表主键不是id因此 this.Find 失效，
         * 
         */

        /// <summary>
        /// 根据ID获取一个记录  
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        public override SysDict GetById(string keyValue)
        {
            return this.dbSet.Find(keyValue);
           // return this.Fetch().FirstOrDefault(m => m.ID == keyValue);
        }
        public SysDict GetByValue(string Value,string code)
        {
            return this.Fetch().FirstOrDefault(m => m.DValue == Value && m.DictCode == code);
        }
        /// <summary>
        /// 按dictcode 取类型
        /// </summary>
        /// <param name="sCode"></param>
        /// <returns></returns>
        public IList<SysDict> GetByCode(SysDictType sCode)
        {
            string strcode = sCode.ToString();
            return this.Fetch().Where(m => m.DictCode == strcode &&m.State==1 ).OrderBy(p => p.OrderIndex).ToList();
        }



        /// <summary>
        /// 根据ID获取一个记录  
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        public IQueryable<SysDict> GetListByCode(string code)
        {
            return this.Fetch(m => m.DictCode == code && m.State == 0, o => o.Asc(p => p.OrderIndex));
        }


    }


    /// <summary>
    /// 通用字典 类型
    /// </summary>
    public enum SysDictType
    {
        /// <summary>
        /// 客户等级
        /// </summary>
        khdj,
        /// <summary>
        /// 客户分类
        /// </summary>
        khfl,
        /// <summary>
        /// 入库类型
        /// </summary>
        rklx,
        /// <summary>
        /// 知识库分类
        /// </summary>
        zsfl,
        /// <summary>
        /// 支付类型
        /// </summary>
        zflx,
        /// <summary>
        /// 交通方式
        /// </summary>
        jtfs,
        /// <summary>
        /// 费用类型
        /// </summary>
        fylx,
        /// <summary>
        /// 职位管理
        /// </summary>
        zwgl,
        /// <summary>
        /// 行业分类
        /// </summary>
        khgslx,
        /// <summary>
        /// 计价单位
        /// </summary>
        jjdw,
        /// <summary>
        /// 发货方式
        /// </summary>
        fhfs,
        /// <summary>
        /// 配件下单类型
        /// </summary>
        pjxdlx,

        /// <summary>
        /// 出库类型
        /// </summary>
        cklx,

        /// <summary>
        /// 机构类型
        /// </summary>
        depttype,
        /// <summary>
        /// 文章类别
        /// </summary>
        ArticleType,
     

    }
}

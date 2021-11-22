using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusModels;
using DataFactory;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Runtime.Remoting.Messaging;

namespace BLLFactory
{


    
    /// <summary>
    /// 所有BLL必须继承此类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract  class BaseBLL<T> where T : BaseModel
    {
        protected readonly DbContext dbContent;
        private  DbSet<T> _dbSet;
        protected BaseBLL()
        {
            //dbContent = new WSDContext();
            object efDbContext = CallContext.GetData("DbContext");
            if (efDbContext == null)
            {
                efDbContext = new WSDContext();
                //存入到这个线程缓存中
                CallContext.SetData("DbContext", efDbContext);
            }

            dbContent = efDbContext as DbContext;

        }
        protected virtual DbSet<T> dbSet
        {
            get
            {
                if (_dbSet == null)
                    _dbSet = dbContent.Set<T>();
                return _dbSet;
            }
        }

        public virtual bool Save(T model)
        {
            if (dbContent.Entry(model).State == EntityState.Detached)
            {
                dbSet.Add(model);
            }

            if (dbContent.Entry(model).State == EntityState.Unchanged)
            {
                return true;
            }
           bool sign = dbContent.SaveChanges() > 0;

            //T foundItem = dbSet.AsNoTracking().FirstOrDefault(m => m.ID == model.ID);
            //bool sign = false;
            //if (foundItem == null)
            //{
            //    //INSERT
            //    sign = Insert(model);
            //}
            //else
            //{

            //    sign = Update(model);
            //}
            return sign;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual bool Insert(T model)
        {
            //return true;
            bool sign = false;
            try
            {
                dbSet.Add(model);
                sign= dbContent.SaveChanges() > 0;
            }
            catch (DbEntityValidationException dbex)
            {
                //Debug.WriteLine("CJLG INSERT===DbEntityValidationException>" + dbex.EntityValidationErrors.ElementAt0) + "<<<>>>");
                string strerr = "";
                if (dbex.EntityValidationErrors.Count() > 0)
                {
                    foreach (var item in dbex.EntityValidationErrors)
                    {
                        if (item.ValidationErrors.Count > 0)
                        {
                            foreach (var _err in item.ValidationErrors)
                            {
                                //strerr += _err.ErrorMessage;
                            }
                        }
                    }
                }
                string t = "";
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
              //  System.Data.Entity.db
                string t="";
            }


            return sign;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual bool Update(T model)
        {
            return true;
            //先判断是否已加载了
            try
            {

                EntityObject t= model as EntityObject;
                var _local = dbSet.Local.Where(x => x.ID == model.ID).FirstOrDefault();
                if (_local == null)
                {
                    dbSet.Attach(model);
                }
                IList<string> lstUpFiles = (model as BaseModelExt).UpdateFields;

                //Type _type = model.GetType();
                //foreach (var item in _type.GetProperties())
                //{
                //    string strProName = item.Name;
                //    if (strProName.ToUpper() == "UPDATEUSERID" || strProName.ToUpper() == "UPDATEDATE"
                //        || strProName.ToUpper() == "UPDATEDEPTID")
                //    {
                //        if (!lstUpFiles.Contains(strProName))
                //            lstUpFiles.Add(strProName);
                //    }

                //}

                if (lstUpFiles.Count > 0)
                {
                    foreach (var item in lstUpFiles)
                    {
                        dbContent.Entry(model).Property(item).IsModified = true;
                    }
                }

                return dbContent.SaveChanges() > 0;
            }
            catch (DbEntityValidationException dbex)
            {
                //Debug.WriteLine("CJLG INSERT===DbEntityValidationException>" + dbex.EntityValidationErrors.ElementAt0) + "<<<>>>");
                string strerr = "";
                if (dbex.EntityValidationErrors.Count() > 0)
                {
                    foreach (var item in dbex.EntityValidationErrors)
                    {
                        if (item.ValidationErrors.Count > 0)
                        {
                            foreach (var _err in item.ValidationErrors)
                            {
                                strerr += _err.ErrorMessage;
                            }
                        }
                    }
                }
                Debug.WriteLine("CJLG INSERT===DbEntityValidationException>" + strerr + "<<<>>>");
                //  System.Data.Entity.db
                string t = "";
            }
            catch (Exception ex)
            {
                Debug.WriteLine("CJLG INSERT===>" + ex.Message + "<<<>>>");

                throw ex.InnerException;
                //  System.Data.Entity.db
                string t = "";
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual bool Delete(T model)
        {
            dbSet.Remove(model);
            return dbContent.SaveChanges() > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual bool Delete(string id)
        {
            return Delete(GetById(id));
        }

        public virtual bool Delete(IEnumerable<T> list)
        {
            dbSet.RemoveRange(list);
            return dbContent.SaveChanges() > 0;
        }

        /// <summary>
        ///     获取单个记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetById(string id)
        {
            return dbSet.Find(id);
        }

       


        /// <summary>
        /// 获取IQueryable
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual IQueryable<T> Fetch()
        {
            return dbSet.AsQueryable();
        }


        public virtual IQueryable<T> FetchAsNoTracking() 
        {
            return dbSet.AsNoTracking().AsQueryable();
        }

        /// <summary>
        /// 获取IQueryable
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate)
        {
           return dbSet.Where(predicate);
        }


        

        /// <summary>
        /// 返回排序后的IQueryable
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order)
        {
            var orderable = new Orderable<T>(Fetch(predicate));
            if (order == null)
                order = new Action<Orderable<T>>(o => o.Asc(r => r.ID));
            order(orderable);


            return orderable.Queryable;
        }

        /// <summary>
        /// 获取分页IQueryable
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public virtual IQueryable<T> Fetch(int pageindex,
                                           int count)
        {
            pageindex = pageindex < 1 ? 1 : pageindex;
            int skip = pageindex;// (pageindex - 1) * count;
            return Fetch().Skip(skip).Take(count);
        }

        /// <summary>
        /// 获取分页IQueryable
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="skip"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate, int pageindex,
                                           int count)
        {
            // Action<Orderable<T>> order = new Action<Orderable<T>>();

            return Fetch(predicate, null, pageindex, count);
        }

        /// <summary>
        /// 获取分页IQueryable
        /// </summary>
        /// <param name="order"></param>
        /// <param name="skip"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public virtual IQueryable<T> Fetch(Action<Orderable<T>> order, int pageindex,
                                           int count)
        {
            // pageindex = pageindex < 1 ? 1 : pageindex;
            int skip = pageindex;// (pageindex - 1) * count;

            var orderable = new Orderable<T>(Fetch());
            order(orderable);

            return orderable.Queryable.Skip(skip).Take(count);
        }

        /// <summary>
        /// 获取分页IQueryable
        /// </summary>
        /// <param name="order"></param>
        /// <param name="skip"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order, int pageindex,
                                           int count)
        {
            //pageindex = pageindex < 1 ? 1 : pageindex;
            int skip = pageindex;// (pageindex - 1) * count;
            return Fetch(predicate, order).Skip(skip).Take(count);
        }

        /// <summary>
        /// 获取IQueryable
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual IQueryable<T> FetchAsNoTracking(Expression<Func<T, bool>> predicate)
        {
            return dbSet.AsNoTracking().Where(predicate);
        }


        /// <summary>
        /// 获取IQueryable
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual IQueryable<T> FetchAsNoTracking(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order)
        {
            var orderable = new Orderable<T>(FetchAsNoTracking(predicate));
            if (order == null)
                order = new Action<Orderable<T>>(o => o.Asc(r => r.ID));
            order(orderable);


            return orderable.Queryable;
        }

        public virtual IQueryable<T> FetchAsNoTracking(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order, int pageindex,
                                           int count)
        {
            //pageindex = pageindex < 1 ? 1 : pageindex;
            int skip = pageindex;// (pageindex - 1) * count;
            return FetchAsNoTracking(predicate, order).Skip(skip).Take(count);
        }

        /// <summary>
        /// 返回数量
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual int Count(Expression<Func<T, bool>> predicate)
        {
            return Fetch(predicate).Count();
        }


    }

    
}

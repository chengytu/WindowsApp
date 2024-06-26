﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLLFactory
{
    public class Orderable<T>
    {
        private IOrderedQueryable<T> _queryable;

        public Orderable(IQueryable<T> enumerable)
        {
            _queryable = enumerable.OrderBy(p => 0);
        }

        public IOrderedQueryable<T> Queryable
        {
            get { return _queryable; }
        }

        public Orderable<T> Asc<TKey>(Expression<Func<T, TKey>> keySelector)
        {
            _queryable = _queryable
                .ThenBy(keySelector);
            //.OrderBy(keySelector);
            return this;
        }
        public Orderable<T> Desc<TKey>(Expression<Func<T, TKey>> keySelector)
        {
            _queryable = _queryable
                .ThenByDescending(keySelector);
            return this;
        }

        //public Orderable<T> Asc<TKey1, TKey2>(Expression<Func<T, TKey1>> keySelector1,
        //                                      Expression<Func<T, TKey2>> keySelector2)
        //{
        //    _queryable = _queryable
        //        .OrderBy(keySelector1)
        //        .OrderBy(keySelector2);
        //    return this;
        //}

        //public Orderable<T> Asc<TKey1, TKey2, TKey3>(Expression<Func<T, TKey1>> keySelector1,
        //                                             Expression<Func<T, TKey2>> keySelector2,
        //                                             Expression<Func<T, TKey3>> keySelector3)
        //{
        //    _queryable = _queryable
        //        .OrderBy(keySelector1)
        //        .OrderBy(keySelector2)
        //        .OrderBy(keySelector3);
        //    return this;
        //}

        //public Orderable<T> Desc<TKey>(Expression<Func<T, TKey>> keySelector)
        //{
        //    _queryable = _queryable
        //        .OrderByDescending(keySelector);
        //    return this;
        //}

        //public Orderable<T> Desc<TKey1, TKey2>(Expression<Func<T, TKey1>> keySelector1,
        //                                       Expression<Func<T, TKey2>> keySelector2)
        //{
        //    _queryable = _queryable
        //        .OrderByDescending(keySelector1)
        //        .OrderByDescending(keySelector2);
        //    return this;
        //}

        //public Orderable<T> Desc<TKey1, TKey2, TKey3>(Expression<Func<T, TKey1>> keySelector1,
        //                                              Expression<Func<T, TKey2>> keySelector2,
        //                                              Expression<Func<T, TKey3>> keySelector3)
        //{
        //    _queryable = _queryable
        //        .OrderByDescending(keySelector1)
        //        .OrderByDescending(keySelector2)
        //        .OrderByDescending(keySelector3);
        //    return this;
        //}
    }

}

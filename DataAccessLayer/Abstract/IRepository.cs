﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        List<T> List(Expression<Func<T, bool>> filter);
        T Get(Expression<Func<T, bool>> filter);
        void Add (T p);
        void Remove (T p);
        void Update (T p);

    }
}

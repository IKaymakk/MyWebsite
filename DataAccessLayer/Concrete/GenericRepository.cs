﻿using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public void Add(T p)
        {
            var addedEntity = context.Entry(p);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Remove(T p)
        {
            var removedEntity = context.Entry(p);
            removedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void Update(T p)
        {
            var updatedEntity = context.Entry(p);   
            updatedEntity.State= EntityState.Modified;
            context.SaveChanges();
        }
    }
}

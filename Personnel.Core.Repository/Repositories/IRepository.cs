using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Personnel.Core.Repository.Repositories
{
    public interface IRepository<TEntity> where TEntity:class
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}

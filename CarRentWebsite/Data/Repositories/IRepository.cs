using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentWebsite.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll(params Expression<Func<TEntity, object>>[] includes);

        Task<TEntity> GetById(object id, params Expression<Func<TEntity, object>>[] includes);

        Task<TEntity> Add(TEntity fuel);

        Task<TEntity> Update(TEntity fuel);

        Task Delete(object id);

        bool Exist(object id);

    }
}
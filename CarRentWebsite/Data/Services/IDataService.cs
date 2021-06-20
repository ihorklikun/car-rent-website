using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Data.Services
{
    public interface IDataService<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> Get(object id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task Delete(object id);
        bool Exist(object id);
    }
}

using CarRentWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CarRentWebsite.Data.Repositories.Abstract;

namespace CarRentWebsite.Data.Repositories
{
    public class CarRepository : Repository<Car>, IRepository<Car>
    {
        public CarRepository(ApplicationDbContext context) : base(context) { }

        public override async Task<Car> GetById(object id, params Expression<Func<Car, object>>[] includes)
        {
            IQueryable<Car> query = dbSet;
            var entity = dbSet.Find(id);
            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return await query.FirstOrDefaultAsync(e => e.Id == (int)id);
        }
    }
}

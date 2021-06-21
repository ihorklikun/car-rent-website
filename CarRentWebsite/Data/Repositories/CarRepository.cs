using CarRentWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentWebsite.Data.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        internal ApplicationDbContext context;
        internal DbSet<Car> dbSet;

        public CarRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Car>();
        }

        public async Task<IEnumerable<Car>> GetAll(params Expression<Func<Car, object>>[] includes)
        {
            IQueryable<Car> query = dbSet;

            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return await query.ToListAsync();

        }


        public async Task<Car> GetById(object id, params Expression<Func<Car, object>>[] includes)
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

        public async Task<Car> Add(Car entity)
        {
            await dbSet.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(object id)
        {
            Car entityToDelete = await dbSet.FindAsync(id);
            Delete(entityToDelete);
        }

        public void Delete(Car entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public  async Task<Car> Update(Car entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entityToUpdate;
        }

        public bool Exist(object id)
        {
            return dbSet.Any(entity => entity.Id == (int)id);
        }
    }
}

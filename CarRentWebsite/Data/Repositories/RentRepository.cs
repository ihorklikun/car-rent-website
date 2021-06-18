using CarRentWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentWebsite.Data.Repositories
{
    public class RentRepository : IRepository<Rent>
    {
        internal ApplicationDbContext context;
        internal DbSet<Rent> dbSet;

        public RentRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Rent>();
        }

        public async Task<IEnumerable<Rent>> GetAll(params Expression<Func<Rent, object>>[] includes)
        {
            IQueryable<Rent> query = dbSet;

            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return await query.ToListAsync();

        }


        public async Task<Rent> GetById(object id, params Expression<Func<Rent, object>>[] includes)
        {
            IQueryable<Rent> query = dbSet;
            var entity = dbSet.Find(id);
            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return await query.FirstOrDefaultAsync(e => e.Id == (int)id);
        }

        public async Task<Rent> Add(Rent entity)
        {
            List<RentAdditionalOption> list = new List<RentAdditionalOption>();
            foreach (var additionalOption in entity.AdditionalOptions)
            {
                list.Add(context.RentAdditionalOptions.FirstOrDefault(x => x.Id == additionalOption.Id));
            }
            entity.AdditionalOptions.Clear();
            entity.AdditionalOptions = list;

            await dbSet.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(object id)
        {
            Rent entityToDelete = await dbSet.FindAsync(id);
            Delete(entityToDelete);
        }

        public void Delete(Rent entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public async Task<Rent> Update(Rent entityToUpdate)
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

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
    public class RentRepository : Repository<Rent>, IRepository<Rent>
    {
        public RentRepository(ApplicationDbContext context) : base(context) { }

        public override async Task<Rent> GetById(object id, params Expression<Func<Rent, object>>[] includes)
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
        public override async Task<Rent> Add(Rent entity)
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
    }
}

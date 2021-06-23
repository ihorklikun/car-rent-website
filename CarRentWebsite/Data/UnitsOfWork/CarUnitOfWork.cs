using CarRentWebsite.Data.Repositories;
using CarRentWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.Data.Repositories.Abstract;

namespace CarRentWebsite.Data.UnitsOfWork
{
    public class CarUnitOfWork : IDisposable
    {
        private readonly ApplicationDbContext _context;

        public IRepository<Car> CarRepository { get; }

        public CarUnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            CarRepository = new Repository<Car>(context);

        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save() => _context.SaveChanges();
    }
}

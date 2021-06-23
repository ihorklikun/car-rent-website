using CarRentWebsite.Data.Repositories;
using CarRentWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.Data.Services.Abstact;

namespace CarRentWebsite.Data.Services
{
    public class RentDataService : IDataService<Rent>
    {
        private readonly IRepository<Rent> _repository;

        public RentDataService(IRepository<Rent> repository)
        {
            _repository = repository;
        }

        public bool Exist(object id) => _repository.Exist(id);

        public async Task<Rent> Create(Rent entity)
        {
            return await _repository.Add(entity);
        }

        public async Task Delete(object id)
        {
            await _repository.Delete(id);
        }

        public async Task<IEnumerable<Rent>> Get()
        {
            var rents = await _repository.GetAll(x => x.RentStatus, x => x.Car);
            return rents;
        }

        public async Task<Rent> Get(object id)
        {
            var rent = await _repository.GetById(
                    id,
                    x => x.RentStatus,
                    x => x.AdditionalOptions,
                    x => x.Car,
                    x => x.Car.Brand,
                    x => x.Car.Fuel,
                    x => x.Car.Engine,
                    x => x.Car.Transmission,
                    x => x.Car.CarStatus,
                    x => x.Car.CarType,
                    x => x.Car.CarClass
                );
            return rent;
        }

        public async Task<Rent> Update(Rent entity)
        {
            return await _repository.Update(entity);
        }
    }
}

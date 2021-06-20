﻿using CarRentWebsite.Data.Repositories;
using CarRentWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Data.Services
{
    public class CarDataService : IDataService<Car>
    {
        private readonly IRepository<Car> _repository;

        public CarDataService(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<Car> Create(Car entity)
        {
            return await _repository.Add(entity);
        }

        public async Task Delete(object id)
        {
            await _repository.Delete(id);
        }

        public bool Exist(object id) => _repository.Exist(id);

        public async Task<IEnumerable<Car>> Get()
        {
            var cars = await _repository.GetAll(
                    x => x.Brand,
                    x => x.Fuel,
                    x => x.Engine,
                    x => x.Transmission,
                    x => x.CarStatus,
                    x => x.CarType,
                    x => x.CarClass
                );
            return cars;
        }

        public async Task<Car> Get(object id)
        {
            var car = await _repository.GetById(id,
                    x => x.Brand,
                    x => x.Fuel,
                    x => x.Engine,
                    x => x.Transmission,
                    x => x.CarStatus,
                    x => x.CarType,
                    x => x.CarClass,
                    x => x.PriceCoefficients,
                    x => x.Rents,
                    x => x.Reviews,
                    x => x.ConditionReports
                );
            return car;
        }

        public async Task<Car> Update(Car entity)
        {
            return await _repository.Update(entity);
        }
    }
}
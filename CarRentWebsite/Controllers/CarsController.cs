﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentWebsite.Data;
using CarRentWebsite.Models;
using CarRentWebsite.ViewModels;
using CarRentWebsite.ViewModels.CarViewModels;

namespace CarRentWebsite.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CarsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarViewModel>>> GetCars()
        {
            var cars = await _context.Cars
                .Include(x=>x.Brand)
                .Include(x => x.Fuel)
                .Include(x => x.Engine)
                .Include(x => x.Transmission)
                .Include(x => x.CarStatus)
                .Include(x => x.CarType)
                .Include(x => x.CarClass)
                .ToListAsync();

            var carsViewModel = _mapper.Map<IEnumerable<Car>, IEnumerable<CarViewModel>>(cars);

            return Ok(carsViewModel);
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarViewModel>> GetCar(int id)
        {
            var car = await _context.Cars
                .Include(x => x.Brand)
                .Include(x => x.CarClass)
                .Include(x => x.CarStatus)
                .Include(x => x.CarType)
                .Include(x => x.Engine)
                .Include(x => x.Transmission)
                .Include(x => x.Fuel)
                .Include(x => x.PriceCoefficients)
                .Include(x => x.Rents)
                .Include(x => x.Reviews)
                .Include(x => x.ConditionReports)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            var carViewModel = _mapper.Map<Car, CarViewModel>(car);
            
            return carViewModel;
        }

        // PUT: api/Cars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(int id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCar", new { id = car.Id }, car);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
    }
}
using System;
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
using CarRentWebsite.ViewModels.Car;
using CarRentWebsite.Data.Services;
using CarRentWebsite.Data.Services.Abstract;

namespace CarRentWebsite.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IDataService<Car> _service;

        public CarsController(IDataService<Car> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarViewModel>>> GetCars()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cars = await _service.Get();
            var carsViewModel = _mapper.Map<IEnumerable<Car>, IEnumerable<CarViewModel>>(cars);

            return Ok(carsViewModel);
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailsCarViewModel>> GetCar(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = await _service.Get(id);
            if (car == null)
            {
                return NotFound();
            }

            var carViewModel = _mapper.Map<Car, DetailsCarViewModel>(car);
            
            return Ok(carViewModel);
        }

        // PUT: api/Cars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<CarViewModel>> PutCar(int id, UpdateCarViewModel car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updateCar = _mapper.Map<UpdateCarViewModel, Car>(car);

            try
            {
                updateCar = await _service.Update(updateCar);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_service.Exist(x => x.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            var updatedCarViewModel = _mapper.Map<Car, CarViewModel>(updateCar);
            return Ok(updatedCarViewModel);
        }

        // POST: api/Cars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarViewModel>> PostCar(CreateCarViewModel car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createCar = _mapper.Map<CreateCarViewModel, Car>(car);
            var createdCar = await _service.Get((await _service.Create(createCar)).Id);
            var createdCarViewModel = _mapper.Map<Car, CarViewModel>(createdCar);

            return Ok(createdCarViewModel);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            
            if (!_service.Exist(x=>x.Id == id))
            {
                return NotFound();
            }
            await _service.Delete(id);
            return NoContent();
        }

        
    }
}

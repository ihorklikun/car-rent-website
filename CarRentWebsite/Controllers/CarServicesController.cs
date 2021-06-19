using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentWebsite.Data;
using CarRentWebsite.Models;

namespace CarRentWebsite.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CarServicesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CarServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CarServices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarService>>> GetCarServices()
        {
            return await _context.CarServices.ToListAsync();
        }

        // GET: api/CarServices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarService>> GetCarService(int id)
        {
            var carService = await _context.CarServices.FindAsync(id);

            if (carService == null)
            {
                return NotFound();
            }

            return carService;
        }

        // PUT: api/CarServices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarService(int id, CarService carService)
        {
            if (id != carService.Id)
            {
                return BadRequest();
            }

            _context.Entry(carService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarServiceExists(id))
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

        // POST: api/CarServices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarService>> PostCarService(CarService carService)
        {
            _context.CarServices.Add(carService);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarService", new { id = carService.Id }, carService);
        }

        // DELETE: api/CarServices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarService(int id)
        {
            var carService = await _context.CarServices.FindAsync(id);
            if (carService == null)
            {
                return NotFound();
            }

            _context.CarServices.Remove(carService);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarServiceExists(int id)
        {
            return _context.CarServices.Any(e => e.Id == id);
        }
    }
}

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
    [Route("api/[controller]")]
    [ApiController]
    public class CarStatusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CarStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CarStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarStatus>>> GetCarStatuses()
        {
            return await _context.CarStatuses.ToListAsync();
        }

        // GET: api/CarStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarStatus>> GetCarStatus(int id)
        {
            var carStatus = await _context.CarStatuses.FindAsync(id);

            if (carStatus == null)
            {
                return NotFound();
            }

            return carStatus;
        }

        // PUT: api/CarStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarStatus(int id, CarStatus carStatus)
        {
            if (id != carStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(carStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarStatusExists(id))
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

        // POST: api/CarStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarStatus>> PostCarStatus(CarStatus carStatus)
        {
            _context.CarStatuses.Add(carStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarStatus", new { id = carStatus.Id }, carStatus);
        }

        // DELETE: api/CarStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarStatus(int id)
        {
            var carStatus = await _context.CarStatuses.FindAsync(id);
            if (carStatus == null)
            {
                return NotFound();
            }

            _context.CarStatuses.Remove(carStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarStatusExists(int id)
        {
            return _context.CarStatuses.Any(e => e.Id == id);
        }
    }
}

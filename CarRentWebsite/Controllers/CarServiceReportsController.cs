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
    public class CarServiceReportsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CarServiceReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CarServiceReports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarServiceReport>>> GetCarServiceReports()
        {
            return await _context.CarServiceReports.ToListAsync();
        }

        // GET: api/CarServiceReports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarServiceReport>> GetCarServiceReport(int id)
        {
            var carServiceReport = await _context.CarServiceReports.FindAsync(id);

            if (carServiceReport == null)
            {
                return NotFound();
            }

            return carServiceReport;
        }

        // PUT: api/CarServiceReports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarServiceReport(int id, CarServiceReport carServiceReport)
        {
            if (id != carServiceReport.Id)
            {
                return BadRequest();
            }

            _context.Entry(carServiceReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarServiceReportExists(id))
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

        // POST: api/CarServiceReports
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarServiceReport>> PostCarServiceReport(CarServiceReport carServiceReport)
        {
            _context.CarServiceReports.Add(carServiceReport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarServiceReport", new { id = carServiceReport.Id }, carServiceReport);
        }

        // DELETE: api/CarServiceReports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarServiceReport(int id)
        {
            var carServiceReport = await _context.CarServiceReports.FindAsync(id);
            if (carServiceReport == null)
            {
                return NotFound();
            }

            _context.CarServiceReports.Remove(carServiceReport);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarServiceReportExists(int id)
        {
            return _context.CarServiceReports.Any(e => e.Id == id);
        }
    }
}

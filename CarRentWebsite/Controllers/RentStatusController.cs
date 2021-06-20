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
    public class RentStatusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RentStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RentStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RentStatus>>> GetRentStatuses()
        {
            return await _context.RentStatuses.ToListAsync();
        }

        // GET: api/RentStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RentStatus>> GetRentStatus(int id)
        {
            var rentStatus = await _context.RentStatuses.FindAsync(id);

            if (rentStatus == null)
            {
                return NotFound();
            }

            return rentStatus;
        }

        // PUT: api/RentStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRentStatus(int id, RentStatus rentStatus)
        {
            if (id != rentStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(rentStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentStatusExists(id))
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

        // POST: api/RentStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RentStatus>> PostRentStatus(RentStatus rentStatus)
        {
            _context.RentStatuses.Add(rentStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRentStatus", new { id = rentStatus.Id }, rentStatus);
        }

        // DELETE: api/RentStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRentStatus(int id)
        {
            var rentStatus = await _context.RentStatuses.FindAsync(id);
            if (rentStatus == null)
            {
                return NotFound();
            }

            _context.RentStatuses.Remove(rentStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RentStatusExists(int id)
        {
            return _context.RentStatuses.Any(e => e.Id == id);
        }
    }
}

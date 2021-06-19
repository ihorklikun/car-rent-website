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
    public class RentAdditionalOptionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RentAdditionalOptionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RentAdditionalOptions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RentAdditionalOption>>> GetRentAdditionalOptions()
        {
            return await _context.RentAdditionalOptions.ToListAsync();
        }

        // GET: api/RentAdditionalOptions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RentAdditionalOption>> GetRentAdditionalOption(int id)
        {
            var rentAdditionalOption = await _context.RentAdditionalOptions.FindAsync(id);

            if (rentAdditionalOption == null)
            {
                return NotFound();
            }

            return rentAdditionalOption;
        }

        // PUT: api/RentAdditionalOptions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRentAdditionalOption(int id, RentAdditionalOption rentAdditionalOption)
        {
            if (id != rentAdditionalOption.Id)
            {
                return BadRequest();
            }

            _context.Entry(rentAdditionalOption).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentAdditionalOptionExists(id))
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

        // POST: api/RentAdditionalOptions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RentAdditionalOption>> PostRentAdditionalOption(RentAdditionalOption rentAdditionalOption)
        {
            _context.RentAdditionalOptions.Add(rentAdditionalOption);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRentAdditionalOption", new { id = rentAdditionalOption.Id }, rentAdditionalOption);
        }

        // DELETE: api/RentAdditionalOptions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRentAdditionalOption(int id)
        {
            var rentAdditionalOption = await _context.RentAdditionalOptions.FindAsync(id);
            if (rentAdditionalOption == null)
            {
                return NotFound();
            }

            _context.RentAdditionalOptions.Remove(rentAdditionalOption);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RentAdditionalOptionExists(int id)
        {
            return _context.RentAdditionalOptions.Any(e => e.Id == id);
        }
    }
}

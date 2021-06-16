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
    public class ConditionMarksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConditionMarksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ConditionMarks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConditionMark>>> GetConditionMarks()
        {
            return await _context.ConditionMarks.ToListAsync();
        }

        // GET: api/ConditionMarks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConditionMark>> GetConditionMark(int id)
        {
            var conditionMark = await _context.ConditionMarks.FindAsync(id);

            if (conditionMark == null)
            {
                return NotFound();
            }

            return conditionMark;
        }

        // PUT: api/ConditionMarks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConditionMark(int id, ConditionMark conditionMark)
        {
            if (id != conditionMark.Id)
            {
                return BadRequest();
            }

            _context.Entry(conditionMark).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConditionMarkExists(id))
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

        // POST: api/ConditionMarks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConditionMark>> PostConditionMark(ConditionMark conditionMark)
        {
            _context.ConditionMarks.Add(conditionMark);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConditionMark", new { id = conditionMark.Id }, conditionMark);
        }

        // DELETE: api/ConditionMarks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConditionMark(int id)
        {
            var conditionMark = await _context.ConditionMarks.FindAsync(id);
            if (conditionMark == null)
            {
                return NotFound();
            }

            _context.ConditionMarks.Remove(conditionMark);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConditionMarkExists(int id)
        {
            return _context.ConditionMarks.Any(e => e.Id == id);
        }
    }
}

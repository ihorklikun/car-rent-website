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
    public class ConditionReportsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ConditionReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ConditionReports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConditionReport>>> GetConditionReports()
        {
            return await _context.ConditionReports.ToListAsync();
        }

        // GET: api/ConditionReports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConditionReport>> GetConditionReport(int id)
        {
            var conditionReport = await _context.ConditionReports.FindAsync(id);

            if (conditionReport == null)
            {
                return NotFound();
            }

            return conditionReport;
        }

        // PUT: api/ConditionReports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConditionReport(int id, ConditionReport conditionReport)
        {
            if (id != conditionReport.Id)
            {
                return BadRequest();
            }

            _context.Entry(conditionReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConditionReportExists(id))
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

        // POST: api/ConditionReports
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConditionReport>> PostConditionReport(ConditionReport conditionReport)
        {
            _context.ConditionReports.Add(conditionReport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConditionReport", new { id = conditionReport.Id }, conditionReport);
        }

        // DELETE: api/ConditionReports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConditionReport(int id)
        {
            var conditionReport = await _context.ConditionReports.FindAsync(id);
            if (conditionReport == null)
            {
                return NotFound();
            }

            _context.ConditionReports.Remove(conditionReport);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConditionReportExists(int id)
        {
            return _context.ConditionReports.Any(e => e.Id == id);
        }
    }
}

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

namespace CarRentWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FuelsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Fuels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FuelViewModel>>> GetFuels()
        {
            var fuels = await _context.Fuels.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<Fuel>, IEnumerable<FuelViewModel>>(fuels));
        }

        // GET: api/Fuels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fuel>> GetFuel(int id)
        {
            var fuel = await _context.Fuels.FindAsync(id);

            if (fuel == null)
            {
                return NotFound();
            }

            return fuel;
        }

        // PUT: api/Fuels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuel(int id, Fuel fuel)
        {
            if (id != fuel.Id)
            {
                return BadRequest();
            }

            _context.Entry(fuel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuelExists(id))
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

        // POST: api/Fuels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fuel>> PostFuel(Fuel fuel)
        {
            _context.Fuels.Add(fuel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFuel", new { id = fuel.Id }, fuel);
        }

        // DELETE: api/Fuels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFuel(int id)
        {
            var fuel = await _context.Fuels.FindAsync(id);
            if (fuel == null)
            {
                return NotFound();
            }

            _context.Fuels.Remove(fuel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FuelExists(int id)
        {
            return _context.Fuels.Any(e => e.Id == id);
        }
    }
}

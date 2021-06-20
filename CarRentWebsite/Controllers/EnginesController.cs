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
using CarRentWebsite.ViewModels.Engine;

namespace CarRentWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnginesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public EnginesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Engines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EngineViewModel>>> GetEngines()
        {
            var engines = await _context.Engines.ToListAsync();
            var enginesViewModel = _mapper.Map<IEnumerable<Engine>, IEnumerable<EngineViewModel>>(engines);
            return Ok(enginesViewModel);
        }

        // GET: api/Engines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Engine>> GetEngine(int id)
        {
            var engine = await _context.Engines.FindAsync(id);

            if (engine == null)
            {
                return NotFound();
            }

            return engine;
        }

        // PUT: api/Engines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEngine(int id, Engine engine)
        {
            if (id != engine.Id)
            {
                return BadRequest();
            }

            _context.Entry(engine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EngineExists(id))
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

        // POST: api/Engines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Engine>> PostEngine(Engine engine)
        {
            _context.Engines.Add(engine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEngine", new { id = engine.Id }, engine);
        }

        // DELETE: api/Engines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEngine(int id)
        {
            var engine = await _context.Engines.FindAsync(id);
            if (engine == null)
            {
                return NotFound();
            }

            _context.Engines.Remove(engine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EngineExists(int id)
        {
            return _context.Engines.Any(e => e.Id == id);
        }
    }
}

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
using CarRentWebsite.ViewModels.Rent;

namespace CarRentWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RentsController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Rents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RentViewModel>>> GetRents()
        {
            var rents = await _context.Rents
                .Include(x=>x.RentStatus)
                .Include(x=>x.Car)
                .ToListAsync();
            var rentViewModels = _mapper.Map<IEnumerable<Rent>, IEnumerable<RentViewModel>>(rents);

            return Ok(rentViewModels);
        }

        // GET: api/Rents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rent>> GetRent(int id)
        {
            var rent = await _context.Rents
                .Include(x => x.RentStatus)
                .Include(x=>x.AdditionalOptions)
                .Include(x => x.Car)
                .Include(x => x.Car.Brand)
                .Include(x => x.Car.Fuel)
                .Include(x => x.Car.Engine)
                .Include(x => x.Car.Transmission)
                .Include(x => x.Car.CarStatus)
                .Include(x => x.Car.CarType)
                .Include(x => x.Car.CarClass)
                .FirstOrDefaultAsync(x=>x.Id == id);

            var rentViewModel = _mapper.Map<Rent, RentViewModel>(rent);


            if (rent == null)
            {
                return NotFound();
            }

            return Ok(rentViewModel);
        }

        // PUT: api/Rents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRent(int id, Rent rent)
        {
            if (id != rent.Id)
            {
                return BadRequest();
            }

            _context.Entry(rent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentExists(id))
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

        // POST: api/Rents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RentViewModel>> PostRent(CreateRentViewModel rent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createRent = _mapper.Map<CreateRentViewModel, Rent>(rent);

            List<RentAdditionalOption> list = new List<RentAdditionalOption>();
            foreach (var additionalOption in createRent.AdditionalOptions)
            {
                list.Add(_context.RentAdditionalOptions.FirstOrDefault(x => x.Id == additionalOption.Id));
            }
            createRent.AdditionalOptions.Clear();
            createRent.AdditionalOptions = list;

            //_context.Entry(createRent.AdditionalOptions).State = EntityState.Unchanged;

            _context.Rents.Add(createRent);
            await _context.SaveChangesAsync();
            
            //addedRent = await _context.Rents
            //    .Include(x=>x.AdditionalOptions)
            //    .Include(x=>x.Car)
            //    .FirstOrDefaultAsync(x => x.Id == addedRent.Id);

            var createdRent = _mapper.Map<Rent, RentViewModel>(_context.Entry(createRent).Entity);

            return Ok(createdRent);
        }

        // DELETE: api/Rents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRent(int id)
        {
            var rent = await _context.Rents.FindAsync(id);
            if (rent == null)
            {
                return NotFound();
            }

            _context.Rents.Remove(rent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RentExists(int id)
        {
            return _context.Rents.Any(e => e.Id == id);
        }
    }
}

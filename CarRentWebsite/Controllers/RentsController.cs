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
using CarRentWebsite.Data.Services;
using CarRentWebsite.Data.Services.Abstact;

namespace CarRentWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDataService<Rent> _service;

        public RentsController(IMapper mapper, IDataService<Rent> service)
        {
            _mapper = mapper;
            _service = service;
        }

        // GET: api/Rents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RentViewModel>>> GetRents()
        {
            var rents = await _service.Get();
            var rentViewModels = _mapper.Map<IEnumerable<Rent>, IEnumerable<RentViewModel>>(rents);

            return Ok(rentViewModels);
        }

        // GET: api/Rents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rent>> GetRent(int id)
        {
            var rent = await _service.Get(id);
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


            try
            {
                await _service.Update(rent);
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
            var createdRent = await _service.Get((await _service.Create(createRent)).Id);
            var createdRentViewModel = _mapper.Map<Rent, RentViewModel>(createdRent);

            return Ok(createdRentViewModel);
        }

        // DELETE: api/Rents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRent(int id)
        {
            if (_service.Exist(id))
            {
                return NotFound();
            }
            await _service.Delete(id);
            return NoContent();
        }

        private bool RentExists(int id)
        {
            return _service.Exist(id);
        }
    }
}

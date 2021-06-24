using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRentWebsite.Data;
using CarRentWebsite.Data.Services.Abstract;
using CarRentWebsite.Models;
using CarRentWebsite.Models.Users;
using CarRentWebsite.ViewModels.Customer;
using CarRentWebsite.ViewModels.Rent;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace CarRentWebsite.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        //private readonly IDataService<ApplicationUser> _service;


        public CustomerController(IMapper mapper, ApplicationDbContext context/*, IDataService<ApplicationUser> service*/)
        {
            _mapper = mapper;
            _context = context;
            //_service = service;
        }

        // GET: api/user/5
        [HttpGet("rents/user/{id}")]
        public async Task<ActionResult<RentViewModel>> GetRent(string id)
        {
            var rents = await _context.Rents.Include(x=>x.Car.Location)
                .Include(x=>x.AdditionalOptions)
                .Include(x=>x.RentStatus)
                .Where(x=>x.CustomerId == id).ToListAsync();
            
            if (rents == null)
            {
                return NotFound();
            }

            var rentsViewModel = _mapper.Map<ICollection<Rent>, ICollection<RentViewModel>>(rents);

            return Ok(rentsViewModel);
        }
    }
}

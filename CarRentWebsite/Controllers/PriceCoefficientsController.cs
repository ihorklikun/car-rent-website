﻿using System;
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
    public class PriceCoefficientsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PriceCoefficientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PriceCoefficients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PriceCoefficient>>> GetPriceCoeficients()
        {
            return await _context.PriceCoeficients.ToListAsync();
        }

        // GET: api/PriceCoefficients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PriceCoefficient>> GetPriceCoefficient(int id)
        {
            var priceCoefficient = await _context.PriceCoeficients.FindAsync(id);

            if (priceCoefficient == null)
            {
                return NotFound();
            }

            return priceCoefficient;
        }

        // PUT: api/PriceCoefficients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPriceCoefficient(int id, PriceCoefficient priceCoefficient)
        {
            if (id != priceCoefficient.Id)
            {
                return BadRequest();
            }

            _context.Entry(priceCoefficient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PriceCoefficientExists(id))
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

        // POST: api/PriceCoefficients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PriceCoefficient>> PostPriceCoefficient(PriceCoefficient priceCoefficient)
        {
            _context.PriceCoeficients.Add(priceCoefficient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPriceCoefficient", new { id = priceCoefficient.Id }, priceCoefficient);
        }

        // DELETE: api/PriceCoefficients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePriceCoefficient(int id)
        {
            var priceCoefficient = await _context.PriceCoeficients.FindAsync(id);
            if (priceCoefficient == null)
            {
                return NotFound();
            }

            _context.PriceCoeficients.Remove(priceCoefficient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PriceCoefficientExists(int id)
        {
            return _context.PriceCoeficients.Any(e => e.Id == id);
        }
    }
}

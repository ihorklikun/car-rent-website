using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentWebsite.Data;
using CarRentWebsite.Models;
using CarRentWebsite.Data.Repositories.Abstract;
using AutoMapper;
using CarRentWebsite.ViewModels.Review;
using CarRentWebsite.Data.Repositories;

namespace CarRentWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IRepository<Review> _repository;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ReviewsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _repository = new Repository<Review>(context);
        }

        // GET: api/Reviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewViewModel>>> GetReviews()
        {
            var reviews = await _repository.GetAll(
                x => x.Car,
                x => x.Customer
            );
            var reviewViewModels = _mapper.Map< IEnumerable<Review>, IEnumerable<ReviewViewModel>>(reviews);
            return Ok(reviewViewModels);
        }

        // GET: api/Reviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReviewViewModel>> GetReview(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var reviews = await _repository.GetAll(
                x => x.Car,
                x => x.Customer
            );

            var review = reviews.FirstOrDefault(x => x.Id == id);

            if (review == null)
            {
                return NotFound();
            }

            var reviewViewModel = _mapper.Map<Review, ReviewViewModel>(review);
            
            return Ok(reviewViewModel);
        }

        // PUT: api/Reviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<ReviewViewModel>> PutReview(int id, UpdateReviewViewModel review)
        {
            if (id != review.Id)
            {
                return BadRequest();
            }

            var updateReview = _mapper.Map<UpdateReviewViewModel, Review>(review);
            try
            {
                var reviewToUpdate = await _context.Reviews.FirstOrDefaultAsync(x => x.Id == id);
                reviewToUpdate.CreateDate = updateReview.CreateDate;
                reviewToUpdate.Title = updateReview.Title;
                reviewToUpdate.Text = updateReview.Text;
                reviewToUpdate.Mark = updateReview.Mark;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            updateReview = await _repository.GetById(updateReview.Id);

            var updateReviewViewModel = _mapper.Map<Review, ReviewViewModel>(updateReview);
            return Ok(updateReviewViewModel);
        }

        // POST: api/Reviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReviewViewModel>> PostReview(CreateReviewViewModel review)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createReview = _mapper.Map<CreateReviewViewModel, Review>(review);
            var createdReview = await _repository.GetById((await _repository.Add(createReview)).Id);
            var createdReviewViewModel = _mapper.Map<Review, ReviewViewModel>(createdReview);

            return Ok(createdReviewViewModel);
        }

        // DELETE: api/Reviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            if (!ReviewExists(id))
            {
                return NoContent();
            }
            await _repository.Delete(id);

            return NoContent();
        }

        private bool ReviewExists(int id)
        {
            return _repository.Exist(e => e.Id == id);
        }
    }
}

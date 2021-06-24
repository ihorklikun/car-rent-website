using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.Data;
using CarRentWebsite.Data.Repositories.Abstract;
using CarRentWebsite.Data.Services.Abstract;
using CarRentWebsite.Models;
using CarRentWebsite.Models.Users;
using CarRentWebsite.Options;
using CarRentWebsite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentWebsite.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context, IAuthService authService, IUserRepository userRepository)
        {
            this._authService = authService;
            _userRepository = userRepository;
            _context = context;
        }

        [HttpPost("login")]
        public ActionResult<AuthData> Post([FromBody] LoginViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = _context.ApplicationUsers.FirstOrDefault(u => u.Email == model.Email);

            if (user == null)
            {
                return BadRequest(new { email = "no user with this email" });
            }

            var passwordValid = _authService.VerifyPassword(model.Password, user.Password);
            if (!passwordValid)
            {
                return BadRequest(new { password = "invalid password" });
            }

            var authData = _authService.GetAuthData(user.Id);
            authData.Name = user.Name;
            authData.Surname = user.Surname;

            return authData;
        }

        [HttpPost("register")]
        public ActionResult<AuthData> Post([FromBody] RegisterViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var emailUniq = _userRepository.IsEmailUniq(model.Email);
            if (!emailUniq) return BadRequest(new { email = "user with this email already exists" });
           
            var id = Guid.NewGuid().ToString();
            var user = new Customer
            {
                Id = id,
                Email = model.Email,
                Password = _authService.HashPassword(model.Password),
                RoleId = 1
            };
            _userRepository.Add(user);
            //_userRepository.Commit();

            return _authService.GetAuthData(id);
        }

    }
}

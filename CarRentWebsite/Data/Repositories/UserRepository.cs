using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.Data.Repositories.Abstract;
using CarRentWebsite.Models;

namespace CarRentWebsite.Data.Repositories
{
    public class UserRepository: Repository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) { }

        public bool IsEmailUniq(string email)
        {
            return !this.Exist(u => u.Email == email);
        }

    }
}

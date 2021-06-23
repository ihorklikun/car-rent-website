using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.Models;

namespace CarRentWebsite.Data.Repositories.Abstract
{
    public interface IUserRepository: IRepository<ApplicationUser>
    {
        bool IsEmailUniq(string email);
    }
}

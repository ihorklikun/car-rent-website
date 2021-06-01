using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Rents = new HashSet<Rent>();
            ConditionReports = new HashSet<ConditionReport>();
            Reviews = new HashSet<Review>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Rent> Rents { get; set; }
        public ICollection<ConditionReport>? ConditionReports { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}

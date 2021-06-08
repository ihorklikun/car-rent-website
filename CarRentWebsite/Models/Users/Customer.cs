using System.Collections.Generic;

namespace CarRentWebsite.Models.Users
{
    public class Customer: ApplicationUser
    {
       
        public int Age { get; set; }
        public ICollection<Rent> Rents { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
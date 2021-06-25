using System.Collections.Generic;

namespace CarRentWebsite.Models.Users
{
    public class Customer: ApplicationUser
    {
        public Customer()
        {
            Rents = new HashSet<Rent>();
        }

        public ICollection<Rent> Rents { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
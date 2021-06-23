using System.Collections.Generic;

namespace CarRentWebsite.Models.Users
{
    public class Customer: ApplicationUser
    {
        public string CustomerInfo { get; set; }

        public ICollection<Rent> Rents { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class Customer: ApplicationUser
    {

        //public int ApplicationUserId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }

        public string CustomerInfo { get; set; }

        public ICollection<Rent> Rents { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
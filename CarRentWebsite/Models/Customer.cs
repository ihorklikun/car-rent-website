using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Rent> Rents { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
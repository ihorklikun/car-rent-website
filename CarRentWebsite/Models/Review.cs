using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Mark { get; set; }
        public DateTime CreateDate { get; set; }

        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}

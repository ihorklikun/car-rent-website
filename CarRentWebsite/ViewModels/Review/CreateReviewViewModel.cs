using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.ViewModels.Review
{
    public class CreateReviewViewModel
    {

        public string Title { get; set; }
        public string Text { get; set; }
        public int Mark { get; set; }
        public DateTime CreateDate { get; set; }

        public int CarId { get; set; }

        public string CustomerId { get; set; }
    }
}

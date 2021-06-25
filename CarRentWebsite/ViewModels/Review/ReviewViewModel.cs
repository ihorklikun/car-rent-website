using CarRentWebsite.ViewModels.Car;
using CarRentWebsite.ViewModels.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.ViewModels.Review
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Mark { get; set; }
        public DateTime CreateDate { get; set; }
        public CarViewModel Car { get; set; }
        public CustomerRewiewViewModel Customer { get; set; }
    }
}

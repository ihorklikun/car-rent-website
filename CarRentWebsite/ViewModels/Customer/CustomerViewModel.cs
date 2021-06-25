using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.ViewModels.Rent;

namespace CarRentWebsite.ViewModels.Customer
{
    public class CustomerViewModel
    {
        public ICollection<RentViewModel> Rents { get; set; }
        //public ICollection<Review> Reviews { get; set; }

    }
}

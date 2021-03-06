using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.ViewModels.Rent;

namespace CarRentWebsite.ViewModels.Customer
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            Rents = new HashSet<RentViewModel>();
        }

        public ICollection<RentViewModel> Rents { get; set; }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CustomerInfo { get; set; }
    }
}

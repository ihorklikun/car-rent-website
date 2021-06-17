using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.ViewModels.AdditionalOption;
using CarRentWebsite.ViewModels.Car;
using CarRentWebsite.ViewModels.Customer;
using CarRentWebsite.ViewModels.RentStatus;

namespace CarRentWebsite.ViewModels.Rent
{
    public class CreateRentViewModel
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }

        public int RentStatusId { get; set; }

        public string CustomerId { get; set; }

        //public ManagerViewModel Manager { get; set; }

        public int CarId { get; set; }
        public ICollection<CreateRentAdditionalOptionViewModel> AdditionalOptions { get; set; }

    }
}

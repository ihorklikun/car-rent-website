using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.Models;
using CarRentWebsite.ViewModels.AdditionalOption;
using CarRentWebsite.ViewModels.CarViewModels;
using CarRentWebsite.ViewModels.Customer;

namespace CarRentWebsite.ViewModels.RentViewModels
{
    public class RentViewModel
    {
        public int Id { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        
        public RentStatusViewModel.RentStatusViewModel RentStatus { get; set; }

        //public CustomerViewModel Customer { get; set; }

        //public ManagerViewModel Manager { get; set; }
        
        public CarViewModel Car { get; set; }

        public ICollection<RentAdditionalOptionViewModel> AdditionalOptions { get; set; }


    }
}

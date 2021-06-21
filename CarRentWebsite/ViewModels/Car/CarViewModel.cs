using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CarRentWebsite.ViewModels.CarPrice;
using CarRentWebsite.ViewModels.Engine;
using CarRentWebsite.ViewModels.Transmission;

namespace CarRentWebsite.ViewModels.Car
{
    public class CarViewModel
    {
        public CarViewModel()
        {
            CarPrices = new HashSet<CarPriceViewModel>();
        }

        public int Id { get; set; }

        public string RegisterNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime RegisterDate { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int SeatsCount { get; set; }
        public int TrunkSize { get; set; }
        
        public BrandViewModel Brand { get; set; }
        public LocationViewModel Location{ get; set; }
        public FuelViewModel Fuel { get; set; }
        public EngineViewModel Engine { get; set; }
        public TransmissionViewModel Transmission { get; set; }
        public CarStatusViewModel CarStatus { get; set; }
        public CarTypeViewModel CarType { get; set; }
        public CarClassViewModel CarClass { get; set; }
        public ICollection<CarPriceViewModel> CarPrices { get; set; }
    }
}

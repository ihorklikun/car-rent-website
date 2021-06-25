using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using CarRentWebsite.ViewModels.Engine;
using CarRentWebsite.ViewModels.Review;
using CarRentWebsite.ViewModels.Transmission;
using Newtonsoft.Json;

namespace CarRentWebsite.ViewModels.Car
{
    public class CarViewModel
    {
        public CarViewModel()
        {
            Reviews = new HashSet<ReviewViewModel>();

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
        public string Model { get; set; }
        public int KilometersDriven { get; set; }


        public double AverageMark 
        {
            get
            {
                if (Reviews.Count <= 0)
                {
                    return 0d;
                }
                var average = Reviews.Average(x => x.Mark);
                average = Math.Truncate(average * 10) / 10;
                return average;
            } 
        }
        public BrandViewModel Brand { get; set; }
        public FuelViewModel Fuel { get; set; }
        public LocationViewModel Location { get; set; }
        public EngineViewModel Engine { get; set; }
        public TransmissionViewModel Transmission { get; set; }
        public CarStatusViewModel CarStatus { get; set; }
        public CarTypeViewModel CarType { get; set; }
        public CarClassViewModel CarClass { get; set; }
        [JsonIgnore]
        public ICollection<ReviewViewModel> Reviews { get; set; }
      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class Car
    {

        public Car()
        {
            Rents = new HashSet<Rent>();
            ConditionReports = new HashSet<ConditionReport>();
            Reviews = new HashSet<Review>();
            PriceCoefficients = new HashSet<PriceCoefficient>();
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

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }

        public int EngineId { get; set; }
        public Engine Engine { get; set; }

        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set; }

        public int CarStatusId { get; set; }
        public CarStatus CarStatus { get; set; }

        public int CarTypeId { get; set; }
        public CarType CarType { get; set; }

        public int CarClassId { get; set; }
        public CarClass CarClass { get; set; }

        public string Model { get; set; }


        //public int LocationId { get; set; }
        //public Location Location { get; set; }


        public ICollection<Rent> Rents { get; set; }
        public ICollection<ConditionReport> ConditionReports { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PriceCoefficient> PriceCoefficients { get; set; }
    }
}

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

        public string RegisterNunber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime RegisterDate { get; set; }

        public string? Description { get; set; }

        public string ImageURL { get; set; }

        public int SeatsCount { get; set; }

        public int TrunkSize { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public int FuelId { get; set; }
        public virtual Fuel Fuel { get; set; }

        public int EngineId { get; set; }
        public virtual Engine Engine { get; set; }

        public int TransmissionId { get; set; }
        public virtual Transmission Transmission { get; set; }

        public int CarStatusId { get; set; }
        public virtual CarStatus CarStatus { get; set; }

        public int CarTypeId { get; set; }
        public virtual CarType CarType { get; set; }

        public int CarClassId { get; set; }
        public virtual CarClass CarClass { get; set; }

        public int LocationId { get; set; }
        public virtual Location Location { get; set; }


        public virtual ICollection<Rent> Rents { get; set; }
        public virtual ICollection<ConditionReport> ConditionReports { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<PriceCoefficient> PriceCoefficients { get; set; }
    }
}

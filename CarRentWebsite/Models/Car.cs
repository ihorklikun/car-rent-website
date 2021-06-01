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
            PriceCoeficients = new HashSet<PriceCoeficient>();
        }

        

        public int Id { get; set; }

        public string Brand { get; set; }

        public string RegisterNunber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime RegisterDate { get; set; }

        public string? Description { get; set; }

        public int SeatsCount { get; set; }
        
        public int TrunkSize { get; set; }

        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }

        public int EngineId { get; set; }
        public Engine Engine { get; set; }
        
        public int TransmitionId { get; set; }
        public Transmition Transmition { get; set; }
        
        public int StatusId { get; set; }
        public Status Status { get; set; }
        
        public int CarTypeId { get; set; }
        public CarType CarType { get; set; }
        
        public int CarClassId { get; set; }
        public CarClass CarClass { get; set; }
        
        public int LocationId { get; set; }
        public Location Location { get; set; }


        public ICollection<Rent> Rents { get; set; }
        public ICollection<ConditionReport> ConditionReports { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public ICollection<PriceCoeficient> PriceCoeficients { get; set; }

    }
}

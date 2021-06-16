using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CarRentWebsite.ViewModels.EngineViewModels;

namespace CarRentWebsite.ViewModels
{
    public class CarViewModel
    {
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
        public BrandViewModel Brand { get; set; }

        public int FuelId { get; set; }
        public FuelViewModel Fuel { get; set; }

        public int EngineId { get; set; }
        public EngineViewModel Engine { get; set; }

        public int TransmissionId { get; set; }
        public TransmissionViewModel.TransmissionViewModel Transmission { get; set; }

        public int CarStatusId { get; set; }
        public CarStatusViewModel CarStatus { get; set; }

        public int CarTypeId { get; set; }
        public CarTypeViewModel CarType { get; set; }

        public int CarClassId { get; set; }
        public CarClassViewModel CarClass { get; set; }

        public int LocationId { get; set; }
        public virtual LocationViewModel Location { get; set; }
    }
}

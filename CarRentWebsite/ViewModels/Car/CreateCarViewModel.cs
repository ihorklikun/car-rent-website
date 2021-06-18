using System;
using CarRentWebsite.ViewModels.Engine;
using CarRentWebsite.ViewModels.Transmission;
using System.ComponentModel.DataAnnotations;

namespace CarRentWebsite.ViewModels.Car
{
    public class CreateCarViewModel
    {


        public string RegisterNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime RegisterDate { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int SeatsCount { get; set; }
        public int TrunkSize { get; set; }

        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int EngineId { get; set; }
        public int TransmissionId { get; set; }
        public int CarStatusId { get; set; }
        public int CarTypeId { get; set; }
        public int CarClassId { get; set; }
    }
}

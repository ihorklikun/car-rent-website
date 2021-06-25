using CarRentWebsite.ViewModels.City;
using CarRentWebsite.ViewModels.Country;
using NetTopologySuite.Geometries;

namespace CarRentWebsite.ViewModels
{
    public class LocationViewModel
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public CityViewModel City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
    }
}
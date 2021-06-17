using CarRentWebsite.ViewModels.CityViewModels;
using CarRentWebsite.ViewModels.CountryViewModels;
using NetTopologySuite.Geometries;

namespace CarRentWebsite.ViewModels
{
    public class LocationViewModel
    {
        public int Id { get; set; }
        public Point Coordinate { get; set; }
        public int CountryId { get; set; }
        public CountryViewModel Country { get; set; }
        public int CityId { get; set; }
        public CityViewModel City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
    }
}
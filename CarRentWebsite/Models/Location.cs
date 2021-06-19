using NetTopologySuite.Geometries;

namespace CarRentWebsite.Models
{
    public class Location
    {
        public int Id { get; set; }
        
        public LocationPoint Coordinate { get; set; }
        
        public int CountryId { get; set; }

        public Country Country { get; set; }
        
        public int CityId { get; set; }
        
        public City City { get; set; }
        
        public string Street { get; set; }
        
        public string Building { get; set; }
    }
}
using NetTopologySuite.Geometries;

namespace CarRentWebsite.Models
{
    public class Location
    {
        public int Id { get; set; }
        
        public Point Coordinate { get; set; }
        
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        
        public int CityId { get; set; }
        
        public virtual City City { get; set; }
        
        public string Street { get; set; }
        
        public string Building { get; set; }
    }
}
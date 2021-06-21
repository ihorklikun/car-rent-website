using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class Location
    {
        public Location()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        
        public int CityId { get; set; }
        
        public City City { get; set; }
        
        public string Street { get; set; }
        
        public string Building { get; set; }

        public ICollection<Car> Cars { get; set; }

    }
}
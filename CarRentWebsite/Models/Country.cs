using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class Country
    {
        public Country()
        {
            Locations = new HashSet<Location>();
        }
        public int Id { get; set; }

        public string Name { get; set; }
        
        public ICollection<Location> Locations { get; set; }
    }
}
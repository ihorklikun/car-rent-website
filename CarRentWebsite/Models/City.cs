using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class City
    {
        public City()
        {
            //Locations = new HashSet<Location>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        //public ICollection<Location> Locations { get; set; }
    }
}
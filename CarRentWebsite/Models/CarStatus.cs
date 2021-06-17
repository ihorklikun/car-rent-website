using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class CarStatus
    {
        public CarStatus()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        public string Name { get; set; }
        
        public ICollection<Car> Cars { get; set; }
    }
}
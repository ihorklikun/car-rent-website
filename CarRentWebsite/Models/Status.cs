using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class Status
    {
        public Status()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        public string Name { get; set; }
        
        public ICollection<Car> Cars { get; set; }
    }
}
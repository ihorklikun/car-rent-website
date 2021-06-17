using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class Engine
    {
        public Engine()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int FuelCapacity { get; set; }

        public int Power { get; set; }

        public int Torque { get; set; }

        public string WinCode { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
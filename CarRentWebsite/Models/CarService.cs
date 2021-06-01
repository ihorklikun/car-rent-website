using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class CarService
    {
        public CarService()
        {
            CarServiceReports = new List<CarServiceReport>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CarServiceReport> CarServiceReports { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class CarPrice
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public Car Car  { get; set; }

        public int DaysCount { get; set; }

        public double Price { get; set; }
    }
}

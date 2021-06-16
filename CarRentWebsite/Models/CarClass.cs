﻿using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class CarClass
    {
        public CarClass()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
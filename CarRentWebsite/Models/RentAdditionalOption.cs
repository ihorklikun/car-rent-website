using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class RentAdditionalOption
    {
        public RentAdditionalOption()
        {
            Rents = new HashSet<Rent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public ICollection<Rent> Rents { get; set; }
    }
}

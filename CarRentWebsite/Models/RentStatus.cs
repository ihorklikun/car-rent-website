using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class RentStatus
    {

        public RentStatus()
        {
            Rents = new HashSet<Rent>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Rent> Rents { get; set; }
    }
}

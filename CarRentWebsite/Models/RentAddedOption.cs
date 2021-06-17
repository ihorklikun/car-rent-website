using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class RentAddedOption
    {
        public int Id { get; set; }

        public int RentId { get; set; }
        public Rent Rent { get; set; }

        public int RentAdditionalOptionId { get; set; }
        public RentAdditionalOption RentAdditionalOption { get; set; }
    }
}

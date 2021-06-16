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
        public virtual Rent Rent { get; set; }

        public int RentAdditionalOptionId { get; set; }
        public virtual RentAdditionalOption RentAdditionalOption { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class Rent
    {
        public Rent()
        {
            AdditionalOptions = new HashSet<RentAdditionalOption>();
        }
        public int Id { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }

        public int RentStatusId { get; set; }
        public virtual RentStatus RentStatus { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int ManagerId { get; set; }
        public virtual Manager Manager { get; set; }

        public int CarId { get; set; }
        public virtual Car Car { get; set; }


        public virtual ICollection<RentAdditionalOption> AdditionalOptions { get; set; }

    }

}

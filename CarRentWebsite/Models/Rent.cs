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
        public RentStatus RentStatus { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }

        public int ManagerId { get; set; }
        public User Manager { get; set; }

        public ICollection<RentAdditionalOption> AdditionalOptions { get; set; }

    }

}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        //public int? CustomerId { get; set; }
        //public int? ManagerId { get; set; }
        //public int? ServiceWorkerId { get; set; }
        //public Customer Customer { get; set; }
        //public Manager Manager { get; set; }
        //public ServiceWorker ServiceWorker { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace CarRentWebsite.Models
{
    public class ApplicationUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        //public int? CustomerId { get; set; }
        //public int? ManagerId { get; set; }
        //public int? ServiceWorkerId { get; set; }
        //public Customer Customer { get; set; }
        //public Manager Manager { get; set; }
        //public ServiceWorker ServiceWorker { get; set; }
    }
}

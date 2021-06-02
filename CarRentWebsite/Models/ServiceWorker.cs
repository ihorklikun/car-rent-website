using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class ServiceWorker
    {
        public int Id { get; set; }

        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<CarServiceReport> CarServiceReports { get; set; }
    }
}
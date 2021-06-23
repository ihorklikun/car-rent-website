using System.Collections.Generic;

namespace CarRentWebsite.Models.Users
{
    public class ServiceWorker: ApplicationUser
    {
        public string ServiceWorkerInfo { get; set; }
        public ICollection<CarServiceReport> CarServiceReports { get; set; }
    }
}
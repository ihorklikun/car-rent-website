using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class Manager: ApplicationUser
    {
        //public int Id { get; set; }

        //public int ApplicationUserId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }

        public string ManagerInfo { get; set; }

        public ICollection<ConditionReport> ConditionReports { get; set; }
        public ICollection<Rent> Rents { get; set; }
    }
}
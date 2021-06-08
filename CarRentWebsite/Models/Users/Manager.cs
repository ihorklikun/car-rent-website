using System.Collections.Generic;

namespace CarRentWebsite.Models.Users
{
    public class Manager : ApplicationUser
    {

        public string ManagerInfo { get; set; }

        public ICollection<ConditionReport> ConditionReports { get; set; }
        public ICollection<Rent> Rents { get; set; }

    }
}
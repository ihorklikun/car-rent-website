using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class Manager
    {
        public int Id { get; set; }

        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<ConditionReport>? ConditionReports { get; set; }
    }
}
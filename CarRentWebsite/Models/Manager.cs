using System.Collections.Generic;

namespace CarRentWebsite.Models
{
    public class Manager
    {
        public int Id { get; set; }

        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<ConditionReport>? ConditionReports { get; set; }
    }
}
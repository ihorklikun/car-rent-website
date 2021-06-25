using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class ConditionMark
    {
        public ConditionMark()
        {
            LpcConditionReports = new HashSet<ConditionReport>();
            InteriorConditionReports = new HashSet<ConditionReport>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ConditionReport> LpcConditionReports { get; set; }
        public ICollection<ConditionReport> InteriorConditionReports { get; set; }
    }
}

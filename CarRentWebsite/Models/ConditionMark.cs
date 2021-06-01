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
            ConditionReports = new HashSet<ConditionReport>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ConditionReport> ConditionReports { get; set; }

    }
}

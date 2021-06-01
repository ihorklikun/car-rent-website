using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class ConditionReport
    {
        public ConditionReport()
        {
            CarServiceReports = new HashSet<CarServiceReport>();
        }


        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int FuelVolume { get; set; }
        public int CarMileage { get; set; }
        public bool IsCritical { get; set; }
        public string Description { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

        public int UserId { get; set; }
        public ApplicationUser User { get; set; }


        public int InteriorConditionId { get; set; }
        public ConditionMark InteriorCondition { get; set; }

        public int LpcConditionId { get; set; }
        public ConditionMark LpcCondition { get; set; }

        public ICollection<CarServiceReport> CarServiceReports { get; set; }
    }
}

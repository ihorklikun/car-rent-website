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
        public virtual Car Car { get; set; }

        public int ManagerId { get; set; }
        public virtual Manager Manager { get; set; }


        public int InteriorConditionId { get; set; }
        public virtual ConditionMark InteriorCondition { get; set; }

        //public int LpcConditionId { get; set; }
        //public virtual ConditionMark LpcCondition { get; set; }

        public virtual ICollection<CarServiceReport> CarServiceReports { get; set; }
    }
}

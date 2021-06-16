using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.Models
{
    public class CarServiceReport
    {
        public int Id { get; set; }
        public bool IsComplete { get; set; }

        public int ConditionReportId { get; set; }
        public virtual ConditionReport ConditionReport { get; set; }

        public int CarServiceId { get; set; }
        public virtual CarService CarService { get; set; }

        public int ServiceWorkerId { get; set; }
        public virtual ServiceWorker ServiceWorker { get; set; }
    }
}

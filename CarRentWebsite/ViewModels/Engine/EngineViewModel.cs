using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebsite.ViewModels.Engine
{ 
    public class EngineViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FuelCapacity { get; set; }
        public int Power { get; set; }
        public int Torque { get; set; }
        public string WinCode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MechAppProject.Models
{
    public class CarModel
    {
        public string CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ProductionYear { get; set; }
        public string EngineType { get; set; }
    }
}
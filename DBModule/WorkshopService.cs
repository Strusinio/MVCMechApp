//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MechAppProject.DBModule
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkshopService
    {
        public int ServiceId { get; set; }
        public int WorkshopId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int DurationInHrs { get; set; }
        public string Description { get; set; }
        public int DurationInMinutes { get; set; }
        public int PriceDecimal { get; set; }
    
        public virtual Workshop Workshop { get; set; }
    }
}

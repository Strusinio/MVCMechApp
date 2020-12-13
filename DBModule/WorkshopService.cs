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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkshopService()
        {
            this.ServiceEvents = new HashSet<ServiceEvent>();
        }
    
        public int ServiceId { get; set; }
        public int WorkshopId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int DurationInHrs { get; set; }
        public string Description { get; set; }
        public int DurationInMinutes { get; set; }
        public int PriceDecimal { get; set; }
    
        public virtual Workshop Workshop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceEvent> ServiceEvents { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MechAppProject.Models
{
    public class AddEventModel
    {
        [DisplayName("Wybierz datę")]
        public DateTime ServiceDate { get; set; }
        public SelectListItem ServiceHours { get; set; }
        [DisplayName("Wybierz godzinę")]
        public SelectList ServiceHourSelectList { get; set; }
        public SelectListItem WorkshopService { get; set; }
        [DisplayName("Wybierz usługę")]
        public SelectList WorkshopServicesSelectList { get; set; }
        public SelectListItem CustomerCar { get; set; }
        [DisplayName("Wybierz samochód")]
        public SelectList CustomerCarsSelectList { get; set; }
        public List<CalendarEventModel> CalendarEvents { get; set; }
    }

    public class CalendarEventModel
    {
        public string EvenTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
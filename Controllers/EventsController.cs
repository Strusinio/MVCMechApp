using MechAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MechAppProject.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult AddEvent(int workshopId)
        {
            var viewModel = new AddEventModel()
            {
                CustomerCarsSelectList = new SelectList(new List<SelectListItem>() {
                    new SelectListItem() { Text = "Audi A5", Value = "1" },
                    new SelectListItem() { Text = "Audi A4", Value = "2" }
                }, "Value", "Text"),
                ServiceHourSelectList = new SelectList(new List<SelectListItem>() {
                    new SelectListItem() { Text = "8:00", Value = "8:00" },
                    new SelectListItem() { Text = "8:15", Value = "8:15" }
                }, "Value", "Text"),
                WorkshopServicesSelectList = new SelectList(new List<SelectListItem>() {
                    new SelectListItem() { Text = "Wymiana kół", Value = "1" },
                    new SelectListItem() { Text = "Wymiana parownika", Value = "2" }
                }, "Value", "Text")
            };

            return View(viewModel);
        }
    }
}
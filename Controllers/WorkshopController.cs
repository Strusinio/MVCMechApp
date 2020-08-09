using MechAppProject.DBModule;
using MechAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MechAppProject.Controllers
{
    public class WorkshopController : Controller
    {
        // GET: Workshop
        public ActionResult Index()
        {
            var model = new List<WorkshopModel>();

            using (var db = new MechAppProjectEntities())
            {
                var workshops = db.Workshops.ToList();

                foreach (var workshop in workshops)
                {
                    var workshopModel = new WorkshopModel()
                    {
                        WorkshopId = workshop.WorkshopId,
                        City = workshop.City,
                        Email = workshop.Email,
                        PhoneNbr = workshop.PhoneNbr,
                        Street = workshop.Street,
                        StreetNbr = workshop.StreetNbr,
                        WorkshopName = workshop.WorkshopName,
                        ZipCode = workshop.ZipCode
                    };

                    model.Add(workshopModel);
                }
            }

            return View(model);
        }
    }
}
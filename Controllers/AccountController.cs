using MechAppProject.DBModule;
using MechAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MechAppProject.Controllers
{
    public class AccountController : Controller
    {
        //////////////////////////////Customer Part/////////////////////////////////////////////
        MechAppProjectEntities objMechAppProjectEntities = new MechAppProjectEntities();

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            CustomerModel objCustomerModel = new CustomerModel();
            return View(objCustomerModel);
        }
        [HttpPost]
        public ActionResult Register(CustomerModel objCustomerModel)
        {
            if (ModelState.IsValid)
            {

                Customer objCustomer = new Customer();
                objCustomer.Login = objCustomerModel.Login;
                if (objMechAppProjectEntities.Customers.Any(x => x.Login == objCustomer.Login))
                {
                    ViewBag.DuplicateMessageLogin = "Ten Login jest już zajęty!!";
                    return View("Register", objCustomerModel);
                }
                objCustomer.Password = objCustomerModel.Password;
                objCustomer.Email = objCustomerModel.Email;
                if (objMechAppProjectEntities.Customers.Any(x => x.Email == objCustomer.Email))
                {
                    ViewBag.DuplicateMessageEmail = "Ten Email jest już zajęty!!";
                    return View("Register", objCustomerModel);
                }

                objCustomer.Name = objCustomerModel.Name;
                objCustomer.Surname = objCustomerModel.Surname;
                objCustomer.City = objCustomerModel.City;
                objCustomer.Street = objCustomerModel.Street;
                objCustomer.StreetNbr = objCustomerModel.StreetNbr;
                objCustomer.ZipCode = objCustomerModel.ZipCode;
                objCustomer.PhoneNbr = objCustomerModel.PhoneNbr;
                objMechAppProjectEntities.Customers.Add(objCustomer);
                objMechAppProjectEntities.SaveChanges();
                ModelState.Clear();
                ViewBag.SuccessMessage = "Użytkownik dodany poprawnie";
                return RedirectToAction("Index", "Home");
            }

            return View();

        }
        public ActionResult Login()
        {
            WorkshopLoginModel objCustmerLoginModel = new WorkshopLoginModel();
            return View(objCustmerLoginModel);
        }

        [HttpPost]
        public ActionResult Login(WorkshopLoginModel objCustmerLoginModel)
        {
            if (ModelState.IsValid)
            {
                if (objMechAppProjectEntities.Customers.Where(m => m.Login == objCustmerLoginModel.Login && m.Password == objCustmerLoginModel.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Login i haslo nie są poprawne");
                    return View("Login");
                }
                else
                {
                    Session["Login"] = objCustmerLoginModel.Login;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return View("Login");
        }
        //////////////////////////////Workshop Part/////////////////////////////////////////////
        public ActionResult RegisterWorkshop()
        {
            WorkshopModel objWorkshopModel = new WorkshopModel();
            return View(objWorkshopModel);
        }

        [HttpPost]
        public ActionResult RegisterWorkshop(WorkshopModel objWorkshopModel)
        {
            if (ModelState.IsValid)
            {

                Workshop objWorkshop = new Workshop();
                objWorkshop.Login = objWorkshopModel.Login;
                if (objMechAppProjectEntities.Customers.Any(x => x.Login == objWorkshopModel.Login))
                {
                    ViewBag.DuplicateMessageLogin = "Ten Login jest już zajęty!!";
                    return View("Register", objWorkshopModel);
                }
                objWorkshop.Password = objWorkshopModel.Password;
                objWorkshop.Email = objWorkshopModel.Email;
                if (objMechAppProjectEntities.Customers.Any(x => x.Email == objWorkshop.Email))
                {
                    ViewBag.DuplicateMessageEmail = "Ten Email jest już zajęty!!";
                    return View("Register", objWorkshopModel);
                }

                objWorkshop.WorkshopName = objWorkshopModel.WorkshopName;
                objWorkshop.OwerName = objWorkshopModel.OwnerName;
                objWorkshop.City = objWorkshopModel.City;
                objWorkshop.Street = objWorkshopModel.Street;
                objWorkshop.StreetNbr = objWorkshopModel.StreetNbr;
                objWorkshop.ZipCode = objWorkshopModel.ZipCode;
                objWorkshop.PhoneNbr = objWorkshopModel.PhoneNbr;
                objMechAppProjectEntities.Workshops.Add(objWorkshop);
                objMechAppProjectEntities.SaveChanges();
                ModelState.Clear();
                ViewBag.SuccessMessage = "Warsztat dodany poprawnie";
                return RedirectToAction("Index", "Home");
            }

            return View();

        }
        public ActionResult LoginWorkshop()
        {
            WorkshopLoginModel objWorkshopLoginModel = new WorkshopLoginModel();
            return View(objWorkshopLoginModel);
        }
        [HttpPost]
        public ActionResult LoginWorkshop(WorkshopLoginModel objWorkshopLoginModel)
        {
            if (ModelState.IsValid)
            {
                if (objMechAppProjectEntities.Workshops.Where(m => m.Login == objWorkshopLoginModel.Login && m.Password == objWorkshopLoginModel.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Login i haslo nie są poprawne");
                    return View("LoginWorkshop");
                }
                else
                {
                    Session["LoginWorkshop"] = objWorkshopLoginModel.Login;
                    return RedirectToAction("IndexWorkshop", "Home");
                }
            }
            return View();
        }
        public ActionResult LogoutWorkshop()
        {
            Session.Abandon();
            return View("Login");
        }
    }
}
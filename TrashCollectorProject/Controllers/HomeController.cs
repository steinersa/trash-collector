using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollectorProject.Models;

namespace TrashCollectorProject.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var id = User.Identity.GetUserId();
            string role = db.Users.Where(x => id == x.Id).Select(x => x.UserRole).SingleOrDefault();
            if (role == "Customer")
            {
                return RedirectToAction("Index", "Customers");
            }
            else if (role == "Employee")
            {
                return RedirectToAction("Index", "Employees");
            }
            else
            {
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
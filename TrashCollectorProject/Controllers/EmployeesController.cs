using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollectorProject.Models;

namespace TrashCollectorProject.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Employees
        public ActionResult Index()
        {
            var userResult = User.Identity.GetUserId();
            var currentEmployee = db.Employees.Where(x => userResult == x.ApplicationId).SingleOrDefault();
            var thisDay = DateTime.Today.ToLongDateString();
            if (thisDay.Contains("Sunday"))
            {
                var todaysPickups = db.Customers.Include(x => x.Day).Where(x => x.Day.Name == "sunday" && x.Zip == currentEmployee.Zip).ToList();
                return View(todaysPickups);
            }
            else if (thisDay.Contains("Monday"))
            {
                var todaysPickups = db.Customers.Include(x => x.Day).Where(x => x.Day.Name == "monday" && x.Zip == currentEmployee.Zip).ToList();
                return View(todaysPickups);
            }
            else if (thisDay.Contains("Tuesday"))
            {
                var todaysPickups = db.Customers.Include(x => x.Day).Where(x => x.Day.Name == "tuesday" && x.Zip == currentEmployee.Zip).ToList();
                return View(todaysPickups);
            }
            else if (thisDay.Contains("Wednesday"))
            {
                var todaysPickups = db.Customers.Include(x => x.Day).Where(x => x.Day.Name == "wednesday" && x.Zip == currentEmployee.Zip).ToList();
                return View(todaysPickups);
            }
            else if (thisDay.Contains("Thursday"))
            {
                var todaysPickups = db.Customers.Include(x => x.Day).Where(x => x.Day.Name == "thursday" && x.Zip == currentEmployee.Zip).ToList();
                return View(todaysPickups);
            }
            else if (thisDay.Contains("Friday"))
            {
                var todaysPickups = db.Customers.Include(x => x.Day).Where(x => x.Day.Name == "friday" && x.Zip == currentEmployee.Zip).ToList();
                return View(todaysPickups);
            }
            else if (thisDay.Contains("Saturday"))
            {
                var todaysPickups = db.Customers.Include(x => x.Day).Where(x => x.Day.Name == "saturday" && x.Zip == currentEmployee.Zip).ToList();
                return View(todaysPickups);
            }
            return View();
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Zip")] Employee employee)
        {
            employee.ApplicationId = User.Identity.GetUserId();
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Zip")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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

        public decimal CalculateQuote(Table table)
        {
            decimal baseQuote = 50m;

            // Age-based calculation
            int age = DateTime.Now.Year - table.DateOfBirth.Year;
            if (table.DateOfBirth > DateTime.Now.AddYears(-age)) age--; // Adjust for leap years
            if (age <= 18)
            {
                baseQuote += 100m;
            }
            else if (age >= 19 && age <= 25)
            {
                baseQuote += 50m;
            }
            else if (age >= 26)
            {
                baseQuote += 25m;
            }

            // Car year-based calculation
            if (table.CarYear < 2000)
            {
                baseQuote += 25m;
            }
            else if (table.CarYear > 2015)
            {
                baseQuote += 25m;
            }

            // Car make and model-based calculation
            if (table.CarMake.ToLower() == "porsche")
            {
                baseQuote += 25m;
                if (table.CarModel.ToLower() == "911 carrera")
                {
                    baseQuote += 25m;
                }
            }

            // Speeding tickets calculation
            baseQuote += table.SpeedingTickets * 10m;

            // DUI calculation
            if (table.DUI)
            {
                baseQuote *= 1.25m;
            }

            // Coverage type calculation
            if (table.CoverageType)
            {
                baseQuote *= 1.5m;
            }

            return baseQuote;
        }

        public ActionResult Admin()
        {
            var insurees = db.Tables.Select(t => new
            {
                t.FirstName,
                t.LastName,
                t.EmailAddress,
                t.Quote
            }).ToList();

            var viewModel = insurees.Select(t => new Table
            {
                FirstName = t.FirstName,
                LastName = t.LastName,
                EmailAddress = t.EmailAddress,
                Quote = t.Quote
            });

            return View(viewModel);
        }
    }
}

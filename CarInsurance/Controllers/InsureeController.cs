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
            return View(db.Insurees.ToList());
        }

        // GET: Admin page
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,DUI,SpeedingTickets,CoverageType,Quote,CarModel")] Insuree insuree)
        {
            decimal baseRate = 50.00m;
            decimal ageFee = 0.00m;
            decimal carYearFee = 0.00m;
            decimal carMakeFee = 0.00m;
            decimal speedingFee = 0.00m; 

            var insureeAge = Convert.ToInt32((DateTime.Now - insuree.DateOfBirth).TotalDays / 365);
            if (insureeAge <= 18)
            {
                ageFee = 100.00m;
            }
            if (insureeAge >= 19 && insureeAge <= 25)
            {
                ageFee = 50.00m;
            }
            if (insureeAge >= 26)
            {
                ageFee = 25.00m;
            }

            if (insuree.CarYear < 2000)
            {
                carYearFee = 25.00m;
            }
            if (insuree.CarYear > 2015)
            {
                carYearFee = 25.00m;
            }

            if (insuree.CarMake == "Porsche")
            {
                carMakeFee = carMakeFee + 25.00m;
            }
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                carMakeFee = carMakeFee + 25.00m;
            }
            if (insuree.SpeedingTickets > 0)
            {
                speedingFee = ((insuree.SpeedingTickets) * 10.00m);
            }
            
            var preDUIsubTotal = baseRate + ageFee + carYearFee + carMakeFee + speedingFee;

            var postDUIsurCharge = preDUIsubTotal / 4;
            var postDUIsubTotal = preDUIsubTotal;
            if (insuree.DUI)
            {
                postDUIsubTotal = preDUIsubTotal + postDUIsurCharge;
            }
            

            var fullCoverageCharge = postDUIsubTotal / 2;
            var finalQuote = postDUIsubTotal;
            if (insuree.CoverageType)
            {
                finalQuote = postDUIsubTotal + fullCoverageCharge;
            }
            insuree.Quote = finalQuote;




            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,DUI,SpeedingTickets,CoverageType,Quote,CarModel")] Insuree insuree)
        {
            decimal baseRate = 50.00m;
            decimal ageFee = 0.00m;
            decimal carYearFee = 0.00m;
            decimal carMakeFee = 0.00m;
            decimal speedingFee = ((insuree.SpeedingTickets) * 10.00m);

            var insureeAge = Convert.ToInt32((DateTime.Now - insuree.DateOfBirth).TotalDays / 365);
            if (insureeAge <= 18)
            {
                ageFee = 100.00m;
            }
            if (insureeAge >= 19 && insureeAge <= 25)
            {
                ageFee = 50.00m;
            }
            if (insureeAge >= 26)
            {
                ageFee = 25.00m;
            }

            if (insuree.CarYear < 2000)
            {
                carYearFee = 25.00m;
            }
            if (insuree.CarYear > 2015)
            {
                carYearFee = 25.00m;
            }

            if (insuree.CarMake == "Porsche")
            {
                carMakeFee = carMakeFee + 25.00m;
            }
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                carMakeFee = carMakeFee + 25.00m;
            }
            var preDUIsubTotal = baseRate + ageFee + carYearFee + carMakeFee + speedingFee;

            var postDUIsurCharge = preDUIsubTotal / 4;
            var postDUIsubTotal = preDUIsubTotal;
            if (insuree.DUI)
            {
                postDUIsubTotal = preDUIsubTotal + postDUIsurCharge;
            }


            var fullCoverageCharge = postDUIsubTotal / 2;
            var finalQuote = postDUIsubTotal;
            if (insuree.CoverageType)
            {
                finalQuote = postDUIsubTotal + fullCoverageCharge;
            }
            insuree.Quote = finalQuote;

            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

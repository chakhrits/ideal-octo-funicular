using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Parkingup2you.Models;

namespace Parkingup2you.Controllers
{
    public class ParkingsController : Controller
    {
        private Parkingup2youContext db = new Parkingup2youContext();

        // GET: Parkings
        public ActionResult Index(string movieGenre, string SearchString)
        {
            var Parking = from m in db.Parkings select m;

            if (!String.IsNullOrEmpty(SearchString))
            {
                if (movieGenre == "1")
                {

                    Parking = Parking.Where(s => s.Block.Contains(SearchString));
                }
                else if (movieGenre == "2")
                {
                    Parking = Parking.Where(s => s.Status.Contains(SearchString));
                }

            }

            return View(Parking);
            //return View(db.Parkings.ToList());
        }

        // GET: Parkings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parking parking = db.Parkings.Find(id);
            if (parking == null)
            {
                return HttpNotFound();
            }
            return View(parking);
        }

        // GET: Parkings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parkings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idBlock,Block,Status")] Parking parking)
        {
            if (ModelState.IsValid)
            {
                db.Parkings.Add(parking);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parking);
        }

        // GET: Parkings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parking parking = db.Parkings.Find(id);
            if (parking == null)
            {
                return HttpNotFound();
            }
            return View(parking);
        }

        // POST: Parkings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idBlock,Block,Status")] Parking parking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parking);
        }

        // GET: Parkings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parking parking = db.Parkings.Find(id);
            if (parking == null)
            {
                return HttpNotFound();
            }
            return View(parking);
        }

        // POST: Parkings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Parking parking = db.Parkings.Find(id);
            db.Parkings.Remove(parking);
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

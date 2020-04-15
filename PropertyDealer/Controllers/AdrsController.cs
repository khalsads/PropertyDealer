using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PropertyDealer.DB;
using PropertyDealer.Models;

namespace PropertyDealer.Controllers
{
    public class AdrsController : Controller
    {
        private PropertyDealerContext db = new PropertyDealerContext();

        // GET: Adrs
        public ActionResult Index()
        {
            return View(db.Adrs.ToList());
        }

        // GET: Adrs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adrs adrs = db.Adrs.Find(id);
            if (adrs == null)
            {
                return HttpNotFound();
            }
            return View(adrs);
        }

        // GET: Adrs/Create
        public ActionResult Create()
        {
            ViewBag.CityName = new SelectList(db.Cities, "CityName", "CityName");
            ViewBag.ProvinceName = new SelectList(db.Provinces, "ProvinceName", "ProvinceName");
            ViewBag.CountryName = new SelectList(db.Countries, "CountryName", "CountryName");
            return View();
        }

        // POST: Adrs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdrsId,AdrsStreet,PostalCode,CityName,ProvinceName,CountryName")] Adrs adrs)
        {
            if (ModelState.IsValid)
            {
                db.Adrs.Add(adrs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adrs);
        }

        // GET: Adrs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adrs adrs = db.Adrs.Find(id);
            ViewBag.CityName = new SelectList(db.Cities, "CityName", "CityName");
            ViewBag.ProvinceName = new SelectList(db.Provinces, "ProvinceName", "ProvinceName");
            ViewBag.CountryName = new SelectList(db.Countries, "CountryName", "CountryName");
            if (adrs == null)
            {
                return HttpNotFound();
            }
            return View(adrs);
        }

        // POST: Adrs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdrsId,AdrsStreet,PostalCode,CityName,ProvinceName,CountryName")] Adrs adrs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adrs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adrs);
        }

        // GET: Adrs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adrs adrs = db.Adrs.Find(id);
            if (adrs == null)
            {
                return HttpNotFound();
            }
            return View(adrs);
        }

        // POST: Adrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adrs adrs = db.Adrs.Find(id);
            db.Adrs.Remove(adrs);
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

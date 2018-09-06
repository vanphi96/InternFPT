using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model;
using Service;

namespace Day1.Controllers
{
    public class CityController : Controller
    {
        private ICityService cityService = new CityService();

        // GET: cities
        public ActionResult Index()
        {
            
            return View(cityService.GetAll());
        }

        // GET: cities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            city city = cityService.GetByID(id.Value);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(city);
        }

        // GET: cities/Create
        public ActionResult Create()
        {
            ViewBag.country_id = new SelectList(cityService.GetAll(), "country_id", "country1");
            return View();
        }

        // POST: cities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "city_id,city1,country_id,last_update")] city city)
        {
            if (ModelState.IsValid)
            {
                cityService.Create(city);
                return RedirectToAction("Index");
            }

            ViewBag.country_id = new SelectList(cityService.GetAll(), "country_id", "country1", city.country_id);
            return View(city);
        }

        // GET: cities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            city city = cityService.GetByID(id.Value);
            if (city == null)
            {
                return HttpNotFound();
            }
            ViewBag.country_id = new SelectList(cityService.GetAll(), "country_id", "country1", city.country_id);
            return View(city);
        }

        // POST: cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "city_id,city1,country_id,last_update")] city city)
        {
            if (ModelState.IsValid)
            {
                cityService.Update(city);
                return RedirectToAction("Index");
            }
            ViewBag.country_id = new SelectList(cityService.GetAll(), "country_id", "country1", city.country_id);
            return View(city);
        }

        // GET: cities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            city city = cityService.GetByID(id.Value);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(city);
        }

        // POST: cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cityService.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                
            }
            base.Dispose(disposing);
        }
    }
}

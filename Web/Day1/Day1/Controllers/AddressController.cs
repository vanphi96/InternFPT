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
    public class AddressController : Controller
    {
        private IAddressService addressService = new AddressService();
        private ICityService cityService = new CityService();

        // GET: addresses
        public ActionResult Index()
        {
           
            return View(addressService.GetAll());
        }

        // GET: addresses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            address address = addressService.GetByID(id.Value);
            if (address == null)
            {
                return HttpNotFound();
            }
            return View(address);
        }

        // GET: addresses/Create
        public ActionResult Create()
        {
            ViewBag.city_id = new SelectList(addressService.GetAll(), "city_id", "city1");
            return View();
        }

        // POST: addresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "address_id,address1,address2,district,city_id,postal_code,phone,last_update")] address address)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (ModelState.IsValid)
            {
                addressService.Create(address);
                return RedirectToAction("Index");
            }

            ViewBag.city_id = new SelectList(cityService.GetAll(), "city_id", "city1", address.city_id);
            return View(address);
        }

        // GET: addresses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            address address = addressService.GetByID(id.Value);
            if (address == null)
            {
                return HttpNotFound();
            }
            ViewBag.city_id = new SelectList(cityService.GetAll(), "city_id", "city1", address.city_id);
            return View(address);
        }

        // POST: addresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "address_id,address1,address2,district,city_id,postal_code,phone,last_update")] address address)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (ModelState.IsValid)
            {
                addressService.Update(address);
                return RedirectToAction("Index");
            }
            ViewBag.city_id = new SelectList(cityService.GetAll(), "city_id", "city1", address.city_id);
            return View(address);
        }

        // GET: addresses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            address address = addressService.GetByID(id.Value);
            if (address == null)
            {
                return HttpNotFound();
            }
            return View(address);
        }

        // POST: addresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            addressService.Delete(id);
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

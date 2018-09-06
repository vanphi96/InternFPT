using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model;
using PagedList;
using Service;
using Service.Interface;

namespace Day1.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryService categoryService = new CategoryService();

        // GET: Admin/Categories
        public ActionResult Index()
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            return View(categoryService.GetAll());
        }

        // GET: Admin/Categories/Details/5
        public ActionResult Details(byte? id)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            category category = categoryService.GetByID(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // GET: Admin/Categories/Create
        public ActionResult Create()
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "category_id,name,last_update")] category category)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (ModelState.IsValid)
            {
                category.last_update = DateTime.Now;
                categoryService.Create(category);
                return RedirectToAction("Index");
            }

            return View(category);
        }

        // GET: Admin/Categories/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            category category = categoryService.GetByID(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "category_id,name,last_update")] category category)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (ModelState.IsValid)
            {
                category.last_update = DateTime.Now;
                categoryService.Update(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Admin/Categories/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            category category = categoryService.GetByID(id.Value);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            categoryService.Delete(id);
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

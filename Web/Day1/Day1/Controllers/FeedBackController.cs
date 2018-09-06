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
using Service.Interface;

namespace Day1.Controllers
{
    public class FeedBackController : Controller
    {
        private ICommentService commentService = new CommentService();
        private ICustomerService customerService = new CustomerService();
        private IFilmService filmService = new FilmService();

        // GET: FeedBack
        public ActionResult Index()
        {
            return Redirect("/Account/Login");
        }

        // GET: FeedBack/Details/5
        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //comment comment = db.comments.Find(id);
            //if (comment == null)
            //{
            //    return HttpNotFound();
            //}
            return Redirect("/Account/Login");
        }

        // GET: FeedBack/Create
        public ActionResult Create()
        {
            //ViewBag.customer_id = new SelectList(db.customers, "customer_id", "first_name");
            //ViewBag.film_id = new SelectList(db.films, "film_id", "title");
            // return View();
            return Redirect("/Account/Login");
        }

        // POST: FeedBack/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "id,customer_id,film_id,datetime,rating,content")] comment comment)
        {
            if (ModelState.IsValid)
            {                
                //comment.customer = customerService.GetByID(comment.customer_id);
                //comment.film = filmService.GetByID(comment.film_id);
                commentService.Create(comment);
                return Redirect("/Film/Details/"+comment.film_id);
            }

            //ViewBag.customer_id = new SelectList(db.customers, "customer_id", "first_name", comment.customer_id);
            //ViewBag.film_id = new SelectList(db.films, "film_id", "title", comment.film_id);
            //return View(comment);
            return Redirect("/Film/Index");
        }

        // GET: FeedBack/Edit/5
        public ActionResult Edit(int? id)
        {
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    comment comment = db.comments.Find(id);
        //    if (comment == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.customer_id = new SelectList(db.customers, "customer_id", "first_name", comment.customer_id);
        //    ViewBag.film_id = new SelectList(db.films, "film_id", "title", comment.film_id);
        //    return View(comment);
            return Redirect("/Film/Index");
        }

        // POST: FeedBack/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,customer_id,film_id,datetime,rating,content")] comment comment)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(comment).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //ViewBag.customer_id = new SelectList(db.customers, "customer_id", "first_name", comment.customer_id);
            //ViewBag.film_id = new SelectList(db.films, "film_id", "title", comment.film_id);
            //return View(comment);
            return Redirect("/Film/Index");
        }

        // GET: FeedBack/Delete/5
        public ActionResult Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //comment comment = db.comments.Find(id);
            //if (comment == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(comment);
            return Redirect("/Film/Index");
        }

        // POST: FeedBack/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //comment comment = db.comments.Find(id);
            //db.comments.Remove(comment);
            //db.SaveChanges();
            //return RedirectToAction("Index");
            return Redirect("/Film/Index");
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

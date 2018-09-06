using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model;
using Service;
using PagedList;
using Service.Interface;

namespace Day1.Controllers
{
    public class FilmController : Controller
    {
        private IFilmService filmService = new FilmService();
        private ILanguageService languageService = new LanguageService();
        private const int PAGE_SIZE = 8;
        private ICommentService commentService = new CommentService();
        private sakilaDB db = new sakilaDB();
        private film filmDetails = new film();
        public comment CreateComment(comment comment, film film, customer customer)
        {
            comment.datetime = DateTime.Now;
            comment.film = film;
            comment.customer = customer;
            comment.film_id = film.film_id;
            comment.customer_id = customer.customer_id;
            commentService.Create(comment);
            return comment;

        }
        // GET: Film
        public ActionResult Index(string name, int? page)
        {

            if (string.IsNullOrEmpty(name))
            {

                return View(filmService.GetAll().OrderBy(q => q.film_id).ToPagedList(page ?? 1, 4));
            }
            else
            {
                return View(filmService.FindFilm(name).OrderBy(q => q.film_id).ToPagedList(page ?? 1, 12));
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details([Bind(Include = "customer_id,film_id,datetime,text")]comment comment)
        {
            if (!string.IsNullOrEmpty(comment.content))
            {
                if (Session["loggeduser"] != null)
                {
                    customer customer = (customer)Session["loggeduser"];
                    CreateComment(comment, filmDetails, customer);
                }
            }
            return View(filmDetails);
        }

        // GET: Film/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            film film = filmService.GetByID(id.Value);
            if (film == null)
            {
                return HttpNotFound();
            }
            filmDetails = film;
            return View(film);
        }

        // GET: Film/Create
        public ActionResult Create()
        {
            ViewBag.language_id = new SelectList(languageService.GetAll(), "language_id", "name");
            ViewBag.original_language_id = new SelectList(languageService.GetAll(), "language_id", "name");
            return View();
        }

        // POST: Film/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "film_id,title,description,release_year,language_id,original_language_id,rental_duration,rental_rate,length,replacement_cost,rating,special_features,last_update,image,url")] film film)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];
                    if (file != null && file.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Image/"), filename);
                        film.image = filename;
                        file.SaveAs(path);
                        filmService.Create(film);
                    }
                }
                return RedirectToAction("Index");
            }
            ViewBag.language_id = new SelectList(languageService.GetAll(), "language_id", "name", film.language_id);
            ViewBag.original_language_id = new SelectList(languageService.GetAll(), "language_id", "name", film.original_language_id);
            filmService.Create(film);
            
            return View(film);
        }

        // GET: Film/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            film film = filmService.GetByID(id.Value);
            if (film == null)
            {
                return HttpNotFound();
            }
            ViewBag.language_id = new SelectList(languageService.GetAll(), "language_id", "name", film.language_id);
            ViewBag.original_language_id = new SelectList(languageService.GetAll(), "language_id", "name", film.original_language_id);
            return View(film);
        }

        // POST: Film/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "film_id,title,description,release_year,language_id,original_language_id,rental_duration,rental_rate,length,replacement_cost,rating,special_features,last_update,image,url")] film film)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];
                    if (file != null && file.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Image/"), filename);
                        film.image = filename;
                        file.SaveAs(path);
                        filmService.Update(film);
                    }
                    return RedirectToAction("Index");
                }

            }
            
            ViewBag.language_id = new SelectList(languageService.GetAll(), "language_id", "name", film.language_id);
            ViewBag.original_language_id = new SelectList(languageService.GetAll(), "language_id", "name", film.original_language_id);

            return View(film);
        }

        // GET: Film/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            film film = filmService.GetByID(id.Value);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Film/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            filmService.Delete(id);
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

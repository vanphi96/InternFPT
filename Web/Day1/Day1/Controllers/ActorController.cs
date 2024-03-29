﻿using System;
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
namespace Day1.Controllers
{
    public class ActorController : Controller
    {
        private IActorService actorService = new ActorService();

        // GET: Actor
        public ActionResult Index(string name, int? page)
        {
            if (string.IsNullOrEmpty(name))
            {
                return View(actorService.GetAll().OrderBy(q => q.actor_id).ToPagedList(page ?? 1, 12));
            }
            var actor = actorService.FindActor(name);
            return View(actor.OrderBy(q => q.actor_id).ToPagedList(page ?? 1, 12));

        }

        // GET: Actor/Details/5
        public ActionResult Details(int? id)
        {
            //if (Session["loggedadmin"] == null)
            //{
            //    return Redirect("/Account/Login");
            //}
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            actor actor = actorService.GetByID(id.Value);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // GET: Actor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "actor_id,first_name,last_name,last_update")] actor actor)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];
                    if (file != null && file.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Image/actor"), filename);
                        actor.image = filename;
                        file.SaveAs(path);
                    }
                }
            }
            return View(actor);
        }

        // GET: Actor/Edit/5
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
            actor actor = actorService.GetByID(id.Value);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // POST: Actor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "actor_id,first_name,last_name,last_update")] actor actor)
        {
            if (Session["loggedadmin"] == null)
            {
                return Redirect("/Account/Login");
            }
            if (ModelState.IsValid)
            {
               if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];
                    if (file != null && file.ContentLength > 0)
                    {
                        var filename = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Image/actor/"), filename);
                        actor.image = filename;
                        file.SaveAs(path);
                        actorService.Update(actor);
                    }
                }
                return RedirectToAction("Index");
            }
            return View(actor);
        }

        // GET: Actor/Delete/5
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
            actor actor = actorService.GetByID(id.Value);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // POST: Actor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            actorService.Delete(id);
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

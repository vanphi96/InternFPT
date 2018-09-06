using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Repository;
using Service;
using Service.Interface;

namespace Day1.Controllers
{
    public class AccountController : Controller
    {
        IAcountService acountService = new AcountService();
        // GET: Account
        public ActionResult Login(AccountModel model)
        {

            Object people = null;
            var existed = acountService.CheckLogin(ref model, ref people);
            if (existed)
            {
                if (model.Admin)
                {
                    Session["loggedadmin"] = (staff)people;
                    // return Redirect("/Film");
                    return RedirectToAction("films", "Admin", new { Areas = "Areas" });
                }
                else
                {
                    Session["loggeduser"] = (customer)people; ;
                     return Redirect("/Film");
                   
                }
              
            }
            else
            {
                ViewBag.ErrorMsg = "Error!!!!";
                return View();
            }
        }

        public ActionResult LogOff()
        {
            Session["loggeduser"] = null;
            Session["loggedadmin"] = null;
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}
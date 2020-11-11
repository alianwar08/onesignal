using Backend.OneSignal;
using Backend.OneSignal.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using OneSignal.Models;

namespace OneSignal.Controllers
{
    public class OnesignalController : Controller
    {

        private void AddErrors(string error)
        {
            ModelState.AddModelError("", error);
        }

        public ActionResult Index()
        {
            onesignal.SyncApplications();

            var db = new Backend.EF.onesignalDB2();
            var appDB = (from n in db.apps
                         select n).ToArray();
            var m = new OneSignal.Models.AppsIndexViewModel()
            {
                apps = appDB
            };
            return View(m);
        }

        [HttpGet]
        public ActionResult CreateApp()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateApp(CreateAppViewModel model)
        {
            if (ModelState.IsValid)
            {
                App_Update_Add app = new App_Update_Add()
                {
                    name = model.Name
                };
                onesignal.CreateApplications(app);
                AddErrors("App created");
            }

            return RedirectToAction("Index", "Onesignal");
            // If we got this far, something failed, redisplay form
            //return View("~/Views/Onesignal/Index.cshtml", model);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult EditApp(string id)
        {
            var db = new Backend.EF.onesignalDB2();
            var appDB = (from n in db.apps
                         where n.id == id
                         select n).FirstOrDefault();
            var m = new OneSignal.Models.CreateAppViewModel()
            {
                Name = appDB.name
            };
            return View(m);


            return RedirectToAction("Index", "Onesignal");
            // If we got this far, something failed, redisplay form
            //return View("~/Views/Onesignal/Index.cshtml", model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult EditApp(CreateAppViewModel model)
        {
            if (ModelState.IsValid)
            {
                App_Update_Add app = new App_Update_Add()
                {
                    name = model.Name,
                    id = model.Id
                };
                onesignal.UpdateApplications(app);
                AddErrors("App Edited");
            }

            return RedirectToAction("Index", "Onesignal");
            // If we got this far, something failed, redisplay form
            //return View("~/Views/Onesignal/Index.cshtml", model);
        }

    }
}
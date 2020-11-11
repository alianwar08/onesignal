using Backend.OneSignal;
using Backend.OneSignal.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneSignal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //App_Update_Add app = new App_Update_Add()
            //{
            //    name = "Test app 1"
            //};
            //onesignal.CreateApplications(app);

            //app = new App_Update_Add()
            //{
            //    name = "Test app 2"
            //};
            //onesignal.CreateApplications(app);


            //onesignal.SyncApplications();


            //var db = new Backend.EF.onesignalDB2();
            //var appDB = (from n in db.apps
            //       where n.name == "Test app 2"
            //       select n).FirstOrDefault();
            //app.name = "Test app 2 updated";
            //app.id = appDB.id;
            //onesignal.UpdateApplications(app);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
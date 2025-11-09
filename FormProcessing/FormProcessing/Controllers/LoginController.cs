using FormProcessing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormProcessing.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Login l = new Login();
            return View(l);
        }
        [HttpPost]
        public ActionResult Index(Login login)
        {
            if (ModelState.IsValid) { //validation
                return RedirectToAction("Index","Home");
            }
            return View(login);
        }
        //[HttpPost]
        //public ActionResult Index(string Username, string Password)
        //{
        //    var name = Username;
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Index(FormCollection fc)
        //{
        //    var name = fc["Username"];
        //    return View();
        //}
        [HttpGet]
        public ActionResult Registration() {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Registration(Student s) {
            if (ModelState.IsValid) {
                TempData["Msg"] = "Registration Successful";
                return RedirectToAction("Index");
            }
            return View(s);
        }
    }

    

}
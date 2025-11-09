using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        Fall25_BEntities db = new Fall25_BEntities();
        // GET: Student
        public ActionResult Index()
        {
            var s = new Student() { 
                Name = "S1",
                Email = "s.a@g.c",
                Address ="Dhaka"
            };
            db.Students.Add(s);
            db.SaveChanges();
            return View();
        }
        public ActionResult List() {
            var data = db.Students.ToList();
            return View(data);
        }
    }
}
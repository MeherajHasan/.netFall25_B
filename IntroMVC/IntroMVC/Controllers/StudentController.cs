

using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IntroMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student[] students = new Student[10];
            for (int i = 1; i <= 10; i++) { 
                students[i-1] = new Student() { 
                    Id = i,
                    Name = "S"+i,
                    Address = "Dhaka",
                    Cgpa = 0
                };
            }

            return View(students);
        }
        public ActionResult Details() {
            var s1 = new Student();
            s1.Name = "Rahim";
            s1.Address = "Dhaka";
            s1.Cgpa = 3.45f;
            s1.Id = 2;

            //ViewBag.Name = "Tanvirr";
            //ViewBag.Id = 123;
            //ViewBag.Address = "Dhaka";


            return View(s1);
        }
    }
}
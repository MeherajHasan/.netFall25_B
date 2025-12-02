using IntroEF.DTOs;
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

        public static Student Convert(StudentDTO s) { 
            return new Student()
            {
                Name = s.Name,
                Email = s.Email,
                DeptId = s.DeptId,
                Address = s.Address
            };
        }
        public static StudentDTO Convert(Student s)
        {
            return new StudentDTO()
            {
                Name = s.Name,
                Email = s.Email,
                DeptId = s.DeptId,
                Address = s.Address
            };
        }
        public List<StudentDTO> Convert(List<Student> list) {
            var data = new List<StudentDTO>();
            foreach (var item in list)
            {
                data.Add(Convert(item));
            }
            return data;
        }

        // GET: Student
        [HttpGet]
        public ActionResult Create() {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(StudentDTO s)
        {
            var st = Convert(s);
            
            db.Students.Add(st);
            db.SaveChanges();
            TempData["Msg"] = "Data " + s.Name + " Created";
            return RedirectToAction("List");
        }
        public ActionResult List(string search) {
            if (search != null) { 
                var list = (from s in db.Students
                           where s.Name.Contains(search)
                           || s.Email.Contains(search)
                           select s).ToList();
                return View(list);
            }
            var data = db.Students.ToList();
            return View(Convert(data));
        }
        public ActionResult Details(int id) {
            var data = db.Students.Find(id); //finds with primary key

            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(int id) {
            var data = db.Students.Find(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Student s) {
            var dbObj = db.Students.Find(s.Id);
            //s.Cgpa = dbObj.Cgpa;
            //db.Students.Remove(dbObj);
            //db.SaveChanges();
            db.Entry(dbObj).CurrentValues.SetValues(s);
            /*dbObj.Email = s.Email;
            dbObj.Name = s.Name;
            dbObj.Address = s.Address;*/
            db.SaveChanges(); 
            TempData["Msg"] = "Student Updated";
            return RedirectToAction("List");
           
        }

    }
}
using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class StudentRepo : IRepository<Student>
    {
        UMSContext db;
        public StudentRepo(UMSContext db)
        {
            this.db = db;
        }

        public bool Create(Student s) { 
            db.Students.Add(s);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get() { 
            //var data = new List<Student>();
            //for (int i = 1; i <= 10; i++) { 
            //    data.Add(new Student() { 
            //        Id = i,
            //        Name = "S"+i
            //    });
            //}

            return db.Students.ToList();
            
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}

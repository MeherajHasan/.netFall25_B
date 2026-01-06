using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DepartmentRepo : IRepository<Department>, IDepartmentFeature
    {
        UMSContext db;
        public DepartmentRepo(UMSContext db)
        {
            this.db = db;
        }

        public bool Create(Department obj)
        {
            db.Departments.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Departments.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Department> Get()
        {
            return db.Departments.ToList();
        }

        public Department Get(int id)
        {
            return db.Departments.Find(id);
        }

        public bool Update(Department obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;    
        }
        public Department GetWithStudents(int id)
        {
            var data = (from d in db.Departments.Include(dp=> dp.Students)
                       where d.Id == id
                       select d).SingleOrDefault();
            return data;
        }
        public List<Department> GetAllWithStudents()
        {
            return db.Departments.Include(d=>d.Students).ToList();
        }

        public Department GetByName(string name)
        {
            var d = from dept in db.Departments
                    where dept.Name.Contains(name)
                    select dept;
            return d.SingleOrDefault();
        }

        public Department GetByNameWithStudents(string name)
        {
            var d = from dept in db.Departments.Include(dpt=>dpt.Students)
                    where dept.Name.Contains(name)
                    select dept;
            return d.SingleOrDefault();
        }

        public Department WithHighestStudents()
        {
            var d = (from dpt in db.Departments.Include(dept=> dept.Students)
                    orderby dpt.Students.Count() descending
                    select dpt).First();
            return d;
        }
    }
}

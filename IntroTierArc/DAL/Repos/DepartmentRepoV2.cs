using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DepartmentRepoV2 : IRepository<Department>
    {
        public bool Create(Department obj)
        {
            throw new NotImplementedException();
        }

        public void CreateDepartment(Department d) { 
            
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> Get()
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Department obj)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(Department d) { 
            
        }
    }
}

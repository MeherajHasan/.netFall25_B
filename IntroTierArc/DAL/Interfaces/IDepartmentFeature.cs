using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDepartmentFeature
    {
        Department GetWithStudents(int id);
        List<Department> GetAllWithStudents();
        Department GetByName(string name);
        Department GetByNameWithStudents(string name);
        Department WithHighestStudents();

    }
}

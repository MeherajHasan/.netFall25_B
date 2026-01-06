using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DepartmentService
    {
        DataAccessFactoy factory;
        public DepartmentService(DataAccessFactoy factory)
        {
            this.factory = factory;
        }

        public List<DepartmentDTO> Get()
        {
            List<Department> data = factory.DepartmentData().Get();
            //convert to DTO
            var ret = MapperConfig.GetMapper().Map<List<DepartmentDTO>>(data);
            return ret;
        }
        public DepartmentDTO Get(int id)
        {
            var data = factory.DepartmentData().Get(id);
            var ret = MapperConfig.GetMapper().Map<DepartmentDTO>(data);
            return ret;
        }
        public bool Create(DepartmentDTO Department)
        {
            Department s = MapperConfig.GetMapper().Map<Department>(Department);
            return factory.DepartmentData().Create(s);
        }
        public bool Update(DepartmentDTO Department)
        {
            Department s = MapperConfig.GetMapper().Map<Department>(Department);
            return factory.DepartmentData().Update(s);
        }
        public bool Delete(int id)
        {
            return factory.DepartmentData().Delete(id);
        }
        public List<DepartmentStudentDTO> GetWithStudents()
        {
            var data = factory.DepartmentFeature().GetAllWithStudents();
            var ret = MapperConfig.GetMapper().Map<List<DepartmentStudentDTO>>(data);
            return ret;

        }
        public DepartmentStudentDTO GetWithStudent(int id) { 
            var data = factory.DepartmentFeature().GetWithStudents(id);
            var ret = MapperConfig.GetMapper().Map<DepartmentStudentDTO>(data);
            return ret;

        }
        public DepartmentStudentDTO GetWithHighestStudents() { 
            var data = factory.DepartmentFeature().WithHighestStudents();
            return MapperConfig.GetMapper().Map<DepartmentStudentDTO>(data);
            
        }
    }
}

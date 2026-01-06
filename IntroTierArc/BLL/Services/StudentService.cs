using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        StudentRepo repo;
        public StudentService(StudentRepo repo  )
        {
            this.repo = repo;
        }
      
        public List<StudentDTO> Get() {
            List<Student> data = repo.Get();
            //convert to DTO
            var ret = MapperConfig.GetMapper().Map<List<StudentDTO>>(data);
            return ret;
        }
        public StudentDTO Get(int id) {
            var data = repo.Get(id);
            var ret = MapperConfig.GetMapper().Map<StudentDTO>(data);
            return ret;
        }
        public bool Create(StudentDTO student) { 
            Student s = MapperConfig.GetMapper().Map<Student>(student);
            return repo.Create(s);
        }
        public bool Update(StudentDTO student) {
            Student s = MapperConfig.GetMapper().Map<Student>(student);
            return repo.Update(s);
        }
        public bool Delete(int id) { 
            return repo.Delete(id);
        }
    }
}

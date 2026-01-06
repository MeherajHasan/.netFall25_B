using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CourseService
    {
        Repository<Course> repo;
        public CourseService(Repository<Course> repo) { 
            this.repo = repo;
        }
    }
}

using AutoMapper;
using EFCFWEBAPI.DTOs;
using EFCFWEBAPI.EF;
using EFCFWEBAPI.EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCFWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        UmSContext db;
        public DepartmentController(UmSContext db)
        {
            this.db = db;
        }
        Mapper GetMapper() {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DepartmentDTO,Department>().ReverseMap();
            });
            return new Mapper(config);
        }

        [HttpGet("all")]
        public ActionResult All() {
            var data = db.Departments.ToList();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id) {
            var data = db.Departments.Find(id);
            return Ok(data);
        }
        [HttpPost("create")]
        public IActionResult Create(DepartmentDTO d) {
            var dept = GetMapper().Map<Department>(d);
            db.Departments.Add(dept);
            db.SaveChanges();
            return Ok(dept);
        }
    }
}

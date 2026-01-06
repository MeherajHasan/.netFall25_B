using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppLayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        DepartmentService service;
        public DepartmentController(DepartmentService service)
        {
            this.service = service;
        }

        [HttpGet("all")]
        public IActionResult All()
        {

            var data = service.Get();
            return Ok(data);
            //response as JSON

        }
        [HttpPost("create")]
        public IActionResult Create(DepartmentDTO s)
        {
            var res = service.Create(s);
            return Ok(res);
        }
        [HttpGet("all/students")]
        public IActionResult AllWithStudents() { 
            var data = service.GetWithStudents();
            return Ok(data);
        }
        [HttpGet("highest/students")]
        public IActionResult HighestStudents()
        {
            var data = service.GetWithHighestStudents();
            return Ok(data);
        }
    }
}

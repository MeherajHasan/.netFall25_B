using DBCoreWEBAPI.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBCoreWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        readonly Fall25AContext db;
        //resolving dependency injection
        public DepartmentController(Fall25AContext db) { 
            this.db = db;
        }
        [HttpGet("all")]
        public IActionResult All() { 
            var data = db.Departments.ToList();
            return Ok(data);
        }

    }
}

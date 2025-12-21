using EFDBFTest.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFDBFTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        TestDbContext db;
        public StudentController(TestDbContext db)
        {
            this.db = db;
        }
    }
}

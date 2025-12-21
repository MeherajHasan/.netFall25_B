using EFCFWEBAPI.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCFWEBAPI.EF
{
    public class UmSContext : DbContext
    {
        public UmSContext(DbContextOptions<UmSContext> options)
        : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

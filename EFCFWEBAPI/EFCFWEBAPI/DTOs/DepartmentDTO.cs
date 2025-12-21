using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCFWEBAPI.DTOs
{
    public class DepartmentDTO
    {
        public int DeptId { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCFWEBAPI.EF.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}

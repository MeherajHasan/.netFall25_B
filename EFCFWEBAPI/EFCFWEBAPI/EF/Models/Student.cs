using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCFWEBAPI.EF.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string Name { get; set; }
        [ForeignKey("Dept")]
        public int DId { get; set; }
        public virtual Department Dept { get; set; }
    }
}

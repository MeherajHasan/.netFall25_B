using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCFWEBAPI.EF.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Name { get; set; }
        [ForeignKey("Dept")]
        public int DId { get; set; }
        public virtual Department Dept { get; set; }
    }
}

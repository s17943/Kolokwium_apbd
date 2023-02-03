using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium_APBD1.Models
{
    public class TaskType
    {
        [Key]
        public int IdTaskType { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Name { get; set; }

    }
}

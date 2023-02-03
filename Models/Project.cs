using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium_APBD1.Models
{
    public class Project
    {
        [Key]
        public int IdProject { get; set; }
        [ForeignKey("TeamMember")]
        public int IdTeam { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public ICollection<MyTask> Tasks { get; set; }

    }
}

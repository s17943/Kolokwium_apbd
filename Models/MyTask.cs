using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium_APBD1.Models
{
    public class MyTask
    {
        [Key]
        public int IdTask { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey("TeamMember")]
        public int IdTeam { get; set; }
        [ForeignKey("TaskType")]
        public int IdTaskType { get; set; }
        [ForeignKey("TeamMember")]
        public int IdAssignedTo { get; set; }
        [ForeignKey("TeamMember")]
        public int IdCreator { get; set; }
        
    }
}

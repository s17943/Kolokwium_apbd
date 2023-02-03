using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium_APBD1.Models
{
    public class TeamMember
    {
        [Key]
        public int IdTeamMember { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string LastName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Email { get; set; }

    }
}

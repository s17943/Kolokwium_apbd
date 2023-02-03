using Kolokwium_APBD1.Models;

namespace Kolokwium_APBD1.DTO
{
    public class ProjectDTO
    {
        public int IdProject { get; set; }
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public ICollection<MyTask> Tasks { get; set; }
    }
}

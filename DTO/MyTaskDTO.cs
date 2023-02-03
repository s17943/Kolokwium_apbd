namespace Kolokwium_APBD1.DTO
{
    public class MytaskDTO
    {
        public int IdTask { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int IdTeam { get; set; }
        public int IdTaskType { get; set; }
        public int IdAssignedTo { get; set; }
        public int IdCreator { get; set; }
    }
}

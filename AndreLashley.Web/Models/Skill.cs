namespace AndreLashley.Web.Models
{
    public class Skill
    {
        public Guid SkillId { get; set; } = Guid.CreateVersion7();
        public string Title { get; set; } = string.Empty;
        public int PercentUtilized { get; set; }
    }
}

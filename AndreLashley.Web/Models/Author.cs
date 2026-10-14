namespace AndreLashley.Web.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public required string DisplayName { get; set; }
        public required string Slug { get; set; }

        public string? Bio { get; set; }

        // public ICollection<Entry> Entries { get; set; } = [];
    }
}

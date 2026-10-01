namespace AndreLashley.Web.Models
{
    public class PortfolioItem
    {
        public string Title { get; set; } = string.Empty;
        public string? Subtitle { get; set; }
        public string? Body { get; set; }
        public string? MainImage { get; set; }
        public string? ThumbImage { get; set; }
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAtUtc { get; set; }
    }
}

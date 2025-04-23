namespace JobListingAPI.Models
{
    public class JobListingDto
    {
        public string Title { get; set; } = "";
        public string Company { get; set; } = "";
        public string Location { get; set; } = "";
        public string Description { get; set; } = "";
        public string salary { get; set; } = "";
        public string JobType { get; set; } = "";
        public string ContactEmail { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}

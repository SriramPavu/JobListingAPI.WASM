using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.HttpResults;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace JobListingAPI.Models
{
    public class JobListingDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = "";
        [Required]
        [StringLength(100)]
        public string Company { get; set; } = "";
        [Required]
        [StringLength(100)]
        public string Location { get; set; } = "";
        [Required]
        [StringLength(100)]
        public string Description { get; set; } = "";
        [Required]
        public string salary { get; set; } = "";
        public string JobType { get; set; } = "";
        public string ContactEmail { get; set; } = "";
        public DateTime CreatedAt { get; set; } 
    }
}

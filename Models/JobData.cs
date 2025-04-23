using System.ComponentModel.DataAnnotations;

namespace JobListingsApp.WASM.Models
{
    public class JobData
    {
        public int JobId { get; set; }
       
        public string Title { get; set; } = "";
       
        public string Company { get; set; } = "";
       
        public string Location { get; set; } = "";
     
        public string Description { get; set; } = "";
        
        public decimal? salary { get; set; }
       
        public string JobType { get; set; } = "";
     
        public string ContactEmail { get; set; } = "";
      
        public DateTime CreatedAt { get; set; }
       
    }
}

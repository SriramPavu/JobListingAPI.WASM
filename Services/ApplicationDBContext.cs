using JobListingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JobListingAPI.Services
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<JobListingDetails> jobListingDetails { get; set; }
    }
}

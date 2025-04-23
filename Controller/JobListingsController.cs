using JobListingAPI.Models;
using JobListingAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobListingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobListingsController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public JobListingsController(ApplicationDBContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        [HttpGet]
        public ActionResult<List<JobListingDetails>> GetListingDetails()
        {
            try
            {
                var items = _dbContext.jobListingDetails
                                      .OrderBy(c => c.JobId)
                                      .ToList();

                return Ok(items);             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Data is not reflected from database");
            }
        }
    }
}

using JobListingsApp.WASM.Models;
using System.Net.Http.Json;

namespace JobListingsApp.WASM.Services
{
    public class JobServices
    {
        private readonly HttpClient _http;
        private readonly string _apiUrl;

        public JobServices(HttpClient http, IConfiguration configuration)
        {
            _http = http;
            _apiUrl = configuration["ApiUrl"]; // Read API URL from configuration
        }

        public async Task<List<JobData>> GetJobsAsync()
        {
            try
            {
                var jobs = await _http.GetFromJsonAsync<List<JobData>>(_apiUrl);
                return jobs ?? new List<JobData>();
            }
            catch (Exception)
            {
                // You can log the error here, for now, just return an empty list
                return new List<JobData>();
            }
        }
    }
}

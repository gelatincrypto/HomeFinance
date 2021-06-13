using System.Text.Json;
using System.Threading.Tasks;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.Services.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HomeFinance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportManager _manager;

        public ReportController(IReportManager manager)
        {
            _manager = manager;
        }

        // GET: api/Report/{date}
        [HttpGet("{date}")]
        public async Task<IActionResult> Get(string date, [FromQuery] PagingParameters pagingParameters)
        {
            var report = await _manager.GetReportAsync(date, pagingParameters);
            var metadata = new
            {
                report.TotalCount,
                report.PageSize,
                report.CurrentPage,
                report.TotalPages,
                report.HasNext,
                report.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));

            return Ok(report);
        }

        // GET: api/Report/{date}/total
        [HttpGet("{date}/total")]
        public async Task<IActionResult> Get(string date)
        {
            var report = await _manager.GetSumAsync(date);

            return Ok(report);
        }

        // GET: api/Report/{startDate}/{endDate}
        [HttpGet("{startDate}/{endDate}")]
        public async Task<IActionResult> Get(string startDate, string endDate, [FromQuery] PagingParameters pagingParameters)
        {
            var report = await _manager.GetReportAsync(startDate, endDate, pagingParameters);
            var metadata = new
            {
                report.TotalCount,
                report.PageSize,
                report.CurrentPage,
                report.TotalPages,
                report.HasNext,
                report.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));

            return Ok(report);
        }

        // GET: api/Report/{startDate}/{endDate}/total
        [HttpGet("{startDate}/{endDate}/total")]
        public async Task<IActionResult> Get(string startDate, string endDate)
        {
            var report = await _manager.GetSumAsync(startDate, endDate);

            return Ok(report);
        }
    }

    
}
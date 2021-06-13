using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using HomeFinance.Api.Commands;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.Services.Business.DTO;
using HomeFinance.Services.Business.Interfaces;
using HybridModelBinding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeFinance.Api.Controllers
{
    [Route("api/operations")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly IOperationManager _manager;
        private readonly IMapper _mapper;
        private readonly ILogger<Startup> _logger;

        public OperationController(IOperationManager manager, IMapper mapper, ILogger<Startup> logger)
        {
            _manager = manager;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/Operations
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PagingParameters pagingParameters)
        {
            var operations = await _manager.GetAllAsync(pagingParameters);
            var metadata = new
            {
                operations.TotalCount,
                operations.PageSize,
                operations.CurrentPage,
                operations.TotalPages,
                operations.HasNext,
                operations.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));

            return Ok(operations);
        }

        // GET: api/categories/{id}
        [HttpGet("{id:long}")]
        public async Task<IActionResult> Get(long id)
        {
            return Ok(await _manager.GetAsync(id));
        }

        // POST: api/Operations
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateOperationCommand value)
        {
            var operation = _mapper.Map<OperationDTO>(value);
            await _manager.CreateAsync(operation);
            return Created("","");
        }

        // PUT: api/Operations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromHybrid] UpdateOperationCommand value)
        {
            var operation = _mapper.Map<OperationDTO>(value);
            var updateResult = await _manager.UpdateAsync(value.Id, operation);
            if (updateResult)
                return NoContent();
            _logger.LogInformation("Attempt to update a non-existent operation.");
            return BadRequest("There is no object with such id");
        }

        // DELETE: api/Operations/5
        [HttpDelete("{id:long}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _manager.DeleteAsync(id);
            return NoContent();
        }
    }
}

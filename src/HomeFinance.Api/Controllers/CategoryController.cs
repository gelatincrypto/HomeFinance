using System.Threading.Tasks;
using AutoMapper;
using HomeFinance.Api.Commands;
using HomeFinance.Services.Business.DTO;
using HomeFinance.Services.Business.Interfaces;
using HybridModelBinding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeFinance.Api.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _manager;
        private readonly ILogger<Startup> _logger;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryManager manager, IMapper mapper, ILogger<Startup> logger)
        {
            _manager = manager;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/categories
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _manager.GetAllAsync();

            return Ok(categories);
        }

        // GET: api/categories/{id}
        [HttpGet("{id:long}")]
        public async Task<IActionResult> Get(long id)
        {
            return Ok(await _manager.GetAsync(id));
        }

        // POST: api/categories
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCategoryCommand value)
        {
            var category = _mapper.Map<CategoryDTO>(value);
            if (await _manager.CreateAsync(category))
                return Created("", "");
            _logger.LogInformation("Attempt to create category with existed name");
            return BadRequest("Category with same name already exist.");
        }

        // PUT: api/categories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromHybrid] UpdateCategoryCommand value)
        {
            var category = _mapper.Map<CategoryDTO>(value);
            await _manager.UpdateAsync(value.Id, category);
            return NoContent();
        }

        // DELETE: api/categories/5
        [HttpDelete("{id:long}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _manager.DeleteAsync(id);
            return NoContent();
        }
    }
}

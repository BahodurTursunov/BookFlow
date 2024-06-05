using BookFlow.Models;
using BookFlow.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookFlow.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController(ICategoryService service) : ControllerBase
    {
        readonly ICategoryService _service = service;

        [HttpGet("AllItems")]
        public IQueryable<Category> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetById")]
        public async Task<Category> Get(int id)
        {
            return await _service.GetById(id);
        }

        [HttpPost("Create")]
        public async Task<Category> Create(Category item)
        {
            return await _service.Create(item);
        }
        [HttpPut("Update")]
        public async Task<bool> Put([FromQuery] int id, [FromBody] Category item)
        {
            return await _service.Update(id, item);
        }

        [HttpDelete("Delete")]
        public async Task<bool> Delete([FromQuery] int id)
        {
            return await _service.Delete(id);
        }
    }
}

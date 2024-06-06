using AutoMapper;
using BookFlow.Infrastructure;
using BookFlow.Models;
using BookFlow.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookFlow.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController(IBookService service, BookFlowContext context, IMapper mapper) : ControllerBase
    {
        readonly BookFlowContext _context = context;
        readonly IBookService _service = service;
        readonly IMapper _mapper = mapper;

        [HttpGet("AllItems")]
        public IQueryable<Book> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetById")]
        public async Task<Book> Get(int id)
        {
            return await _service.GetById(id);
        }

        [HttpPost("Create")]
        public async Task<Book> Create([FromBody] Book item)
        {
            return await _service.Create(item);

        }
        [HttpPut("Update")]
        public async Task<bool> Put([FromQuery] int id, [FromBody] Book item)
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

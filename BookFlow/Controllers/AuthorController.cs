﻿using BookFlow.Models;
using BookFlow.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookFlow.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController(IAuthorService service) : ControllerBase
    {
        readonly IAuthorService _service = service;

        [HttpGet("AllItems")]
        public IQueryable<Author> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("GetById")]
        public async Task<Author> Get(int id)
        {
            return await _service.GetById(id);
        }

        [HttpPost("Create")]
        public async Task<Author> Create(Author item)
        {
            return await _service.Create(item);
        }
        [HttpPut("Update")]
        public async Task<bool> Put([FromQuery] int id, [FromBody] Author item)
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


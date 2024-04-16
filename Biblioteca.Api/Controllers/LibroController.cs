using AutoMapper;
using Biblioteca.Api.Context;
using Biblioteca.Api.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Biblioteca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public LibroController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<Libro>
        [HttpGet]
        public IActionResult Get()
        {
            var libros = _context
                .Libros
                .Include(x => x.Autor)
                .ToList();

            var dto = _mapper.Map<List<LibroDTO>>(libros);
            return Ok(libros);
        }

        // GET api/<Libro>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Libro>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Libro>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Libro>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

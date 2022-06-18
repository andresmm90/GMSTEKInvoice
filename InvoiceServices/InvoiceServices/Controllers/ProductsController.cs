using InvoiceServices.Context;
using InvoiceServices.Entities;
using InvoiceServices.Repositories.Implements;
using InvoiceServices.Services.Implements;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InvoiceServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly InvoiceDBContext _context;

        public ProductsController(InvoiceDBContext context)
        {
            _context = context;
        }

        // GET: api/<ClientsController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            var clientService = new ProductService(new ProductRepository(_context));
            return await clientService.GetAll();
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            var clientService = new ProductService(new ProductRepository(_context));
            return await clientService.GetById(id);
        }

        // POST api/<ClientsController>
        [HttpPost]
        public async Task<Product> Post([FromBody] Product value)
        {
            var clientService = new ProductService(new ProductRepository(_context));
            return await clientService.Insert(value);
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public async Task<Product> Put(int id, [FromBody] Product value)
        {
            var clientService = new ProductService(new ProductRepository(_context));
            return await clientService.Update(value);
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public async void DeleteAsync(int id)
        {
            var clientService = new ProductService(new ProductRepository(_context));
            await clientService.Delete(id);
        }
    }
}

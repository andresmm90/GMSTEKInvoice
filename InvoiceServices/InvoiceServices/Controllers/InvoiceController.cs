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
    public class InvoiceController : ControllerBase
    {
        private readonly InvoiceDBContext _context;

        public InvoiceController(InvoiceDBContext context)
        {
            _context = context;
        }


        // GET: api/<ClientsController>
        [HttpGet]
        public async Task<IEnumerable<Invoice>> Get()
        {
            var invoiceService = new InvoiceService(new InvoiceRepository(_context));
            return await invoiceService.GetAll();
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public async Task<Invoice> Get(int id)
        {
            var invoiceService = new InvoiceService(new InvoiceRepository(_context));
            return await invoiceService.GetById(id);
        }

        // POST api/<ClientsController>
        [HttpPost]
        public async Task<Invoice> Post([FromBody] Invoice value)
        {
            var invoiceService = new InvoiceService(new InvoiceRepository(_context));
            return await invoiceService.Insert(value);
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public async Task<Invoice> Put(int id, [FromBody] Invoice value)
        {
            var invoiceService = new InvoiceService(new InvoiceRepository(_context));
            return await invoiceService.Update(value);
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public async void DeleteAsync(int id)
        {
            var invoiceService = new InvoiceService(new InvoiceRepository(_context));
            await invoiceService.Delete(id);
        }
    }
}

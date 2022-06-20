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
    public class InvoiceDetailsController : ControllerBase
    {
        private readonly InvoiceDBContext _context;

        public InvoiceDetailsController(InvoiceDBContext context)
        {
            _context = context;
        }


        // GET: api/<ClientsController>
        [HttpGet]
        public async Task<IEnumerable<InvoiceDetail>> Get()
        {
            var invoiceDetailService = new InvoiceDetailService(new InvoiceDetailRepository(_context));
            return await invoiceDetailService.GetAll();
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public async Task<InvoiceDetail> Get(int id)
        {
            var invoiceDetailService = new InvoiceDetailService(new InvoiceDetailRepository(_context));
            return await invoiceDetailService.GetById(id);
        }

        [HttpGet("GetByInvoiceId/{id}")]
        public IEnumerable<InvoiceDetail> GetByName(int id)
        {
            var invoiceDetailService = new InvoiceDetailService(new InvoiceDetailRepository(_context));
            return invoiceDetailService.GetByInvoiceId(id);
        }


        // POST api/<ClientsController>
        [HttpPost]
        public async Task<InvoiceDetail> Post([FromBody] InvoiceDetail value)
        {
            var invoiceDetailService = new InvoiceDetailService(new InvoiceDetailRepository(_context));
            return await invoiceDetailService.Insert(value);
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public async Task<InvoiceDetail> Put(int id, [FromBody] InvoiceDetail value)
        {
            var invoiceDetailService = new InvoiceDetailService(new InvoiceDetailRepository(_context));
            return await invoiceDetailService.Update(value);
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public async Task<InvoiceDetail> DeleteAsync(int id)
        {
            var invoiceDetailService = new InvoiceDetailService(new InvoiceDetailRepository(_context));
            return await invoiceDetailService.Delete(id);
        }
    }
}

using InvoiceServices.Entities;
using InvoiceServices.Repositories;

namespace InvoiceServices.Services.Implements
{
    public class InvoiceService : GenericService<Invoice>, IInvoiceService
    {
        private readonly IInvoiceRepository repository;
        public InvoiceService(IInvoiceRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}

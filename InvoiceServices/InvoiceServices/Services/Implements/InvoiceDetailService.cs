using InvoiceServices.Entities;
using InvoiceServices.Repositories;

namespace InvoiceServices.Services.Implements
{
    public class InvoiceDetailService : GenericService<InvoiceDetail>, IInvoiceDetailService
    {
        private readonly IInvoiceDetailRepository repository;
        public InvoiceDetailService(IInvoiceDetailRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}

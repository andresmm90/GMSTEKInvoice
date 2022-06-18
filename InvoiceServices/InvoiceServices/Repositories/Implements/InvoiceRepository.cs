using InvoiceServices.Context;
using InvoiceServices.Entities;

namespace InvoiceServices.Repositories.Implements
{
    public class InvoiceRepository:GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(InvoiceDBContext context):base(context)
        {

        }
    }
}

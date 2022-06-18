using InvoiceServices.Context;
using InvoiceServices.Entities;

namespace InvoiceServices.Repositories.Implements
{
    public class InvoiceDetailRepository:GenericRepository<InvoiceDetail>, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(InvoiceDBContext context):base(context)
        {

        }
    }
}

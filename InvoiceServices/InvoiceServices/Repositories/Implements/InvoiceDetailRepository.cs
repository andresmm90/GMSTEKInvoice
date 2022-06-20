using InvoiceServices.Context;
using InvoiceServices.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceServices.Repositories.Implements
{
    public class InvoiceDetailRepository:GenericRepository<InvoiceDetail>, IInvoiceDetailRepository
    {
        private readonly InvoiceDBContext _context;
        public InvoiceDetailRepository(InvoiceDBContext context):base(context)
        {
            this._context = context;
        }

        public  IEnumerable<InvoiceDetail> GetByInvoiceId(int id)
        {
            return _context.InvoiceDetails.Where(b => b.InvoiceId == id);
        }
    }
}

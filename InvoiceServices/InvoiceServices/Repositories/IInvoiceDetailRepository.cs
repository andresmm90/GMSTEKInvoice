using InvoiceServices.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoiceServices.Repositories
{
    public interface IInvoiceDetailRepository : IGenericRepository<InvoiceDetail>
    {
        IEnumerable<InvoiceDetail> GetByInvoiceId(int id);
    }
}

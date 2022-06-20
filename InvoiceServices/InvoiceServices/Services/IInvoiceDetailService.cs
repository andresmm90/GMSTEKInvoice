using InvoiceServices.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoiceServices.Services
{
    interface IInvoiceDetailService : IGenericService<IEnumerable<InvoiceDetail>>
    {
        IEnumerable<InvoiceDetail> GetByInvoiceId(int id);
    }
}

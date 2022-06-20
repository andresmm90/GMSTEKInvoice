using InvoiceServices.Entities;
using InvoiceServices.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoiceServices.Services.Implements
{
    public class InvoiceDetailService : GenericService<InvoiceDetail>, IInvoiceDetailService
    {
        private readonly IInvoiceDetailRepository repository;
        public InvoiceDetailService(IInvoiceDetailRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public IEnumerable<InvoiceDetail> GetByInvoiceId(int id)
        {
            return repository.GetByInvoiceId(id);
        }

        public Task<IEnumerable<InvoiceDetail>> Insert(IEnumerable<InvoiceDetail> entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<InvoiceDetail>> Update(IEnumerable<InvoiceDetail> entity)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<InvoiceDetail>> IGenericService<IEnumerable<InvoiceDetail>>.Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<IEnumerable<InvoiceDetail>>> IGenericService<IEnumerable<InvoiceDetail>>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<InvoiceDetail>> IGenericService<IEnumerable<InvoiceDetail>>.GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}

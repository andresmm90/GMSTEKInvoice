using InvoiceServices.Entities;
using InvoiceServices.Repositories;

namespace InvoiceServices.Services.Implements
{
    public class ClientService : GenericService<Client>, IClientService
    {
        private readonly IClientRepository repository;
        public ClientService(IClientRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}

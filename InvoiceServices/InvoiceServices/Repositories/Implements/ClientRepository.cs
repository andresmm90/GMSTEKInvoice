using InvoiceServices.Context;
using InvoiceServices.Entities;

namespace InvoiceServices.Repositories.Implements
{
    public class ClientRepository:GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(InvoiceDBContext context):base(context)
        {

        }
    }
}

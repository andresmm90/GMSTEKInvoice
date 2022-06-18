using InvoiceServices.Context;
using InvoiceServices.Entities;

namespace InvoiceServices.Repositories.Implements
{
    public class ProductRepository:GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(InvoiceDBContext context):base(context)
        {

        }
    }
}

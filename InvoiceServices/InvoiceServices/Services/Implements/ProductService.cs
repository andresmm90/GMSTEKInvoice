using InvoiceServices.Entities;
using InvoiceServices.Repositories;

namespace InvoiceServices.Services.Implements
{
    public class ProductService :GenericService<Product>, IProductService
    {
        private readonly IProductRepository repository;
        public ProductService(IProductRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}

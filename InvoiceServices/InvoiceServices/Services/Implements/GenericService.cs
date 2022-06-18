using InvoiceServices.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoiceServices.Services.Implements
{
    public class GenericService<T> : IGenericService<T> where T:class
    {
        private readonly IGenericRepository<T> repository;

        public GenericService(IGenericRepository<T> repository)
        {
            this.repository = repository;
        }
        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<T> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<T> Insert(T entity)
        {
            return await repository.Insert(entity);
        }

        public async Task<T> Update(T entity)
        {
            return await repository.Update(entity);
        }
    }
}

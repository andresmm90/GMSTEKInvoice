using InvoiceServices.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoiceServices.Repositories.Implements
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        private readonly InvoiceDBContext context;
        public GenericRepository(InvoiceDBContext context)
        {
            this.context = context;
        }
        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                throw new Exception("Entity not found");                
            }
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();           
        }

        public async Task<T> GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<T> Insert(T entity)
        {
            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            context.Entry(entity).State =EntityState.Modified;            
            await context.SaveChangesAsync();
            return entity;
        }
    }
}

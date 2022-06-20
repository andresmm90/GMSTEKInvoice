using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvoiceServices.Services
{
    public interface IGenericService<T> where T:class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}

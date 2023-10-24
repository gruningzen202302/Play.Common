using System;
using System.Collections.Generic;
using System.Threading.Tasks;
public interface IRepository<T> where T: IEntity 
{
    Task Create(T entity);
    Task<IReadOnlyCollection<T>> GetAll();
    Task<T> Get(Guid id);
    Task Remove(Guid id);
    Task Update(T entity);

}

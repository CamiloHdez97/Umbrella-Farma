using System.Linq.Expressions;
using Dominio.Interfaces.Pager;

namespace Domain.Interfaces.Generics;
public interface IGenericRepository<T> where T : class{        

    Task<T> FindFirst(Expression<Func<T, bool>> expression);

    Task<IEnumerable<T>> GetAllAsync();  
    Task<IEnumerable<T>> GetAllAsync(IParam param);    
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression);    
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression , IParam param);    

    void Add(T entity);
    void AddRange(IEnumerable<T> entities);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
    void Update(T entity);
}

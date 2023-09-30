using System.Linq.Expressions;
using Domain.Entities;
using Dominio.Interfaces.Pager;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories.Generics;
public abstract class GenericRepository<T> where T : class{
    //sobrescribir si va a aplicar el search en la paginacion
    protected virtual bool PaginateExpression(T entity, string Search)=> true;

    protected readonly DbSet<T> _Entities;
    private readonly DataContext _context;

    public GenericRepository(DataContext context)
    {
        _context = context;
        _Entities = _context.Set<T>();
    }

    public async virtual Task<T> FindFirst(Expression<Func<T, bool>> expression)
    {
        if (expression != null){

            var res = await _Entities.Where(expression).ToListAsync();
            return res.First();
        }
        return await _Entities.FirstAsync();
    }


    public async virtual void Add(T entity) => await _Entities.AddAsync(entity);
    public async virtual void AddRange(IEnumerable<T> entities) => await _Entities.AddRangeAsync(entities);
    public virtual void Remove(T entity) => _Entities.Remove(entity);
    public virtual void RemoveRange(IEnumerable<T> entities) => _Entities.RemoveRange(entities);
    public virtual void Update(T entity) => _Entities.Update(entity);

    public virtual async Task<IEnumerable<T>> GetAllAsync() => await GetAll();
    public virtual async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression) => await GetAll(expression);

    protected virtual async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities.Where(expression).ToListAsync();
        }
        return await _Entities.ToListAsync();
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync(IParam param) => await GetAllPaginated(param);
    public virtual async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, IParam param) => await GetAllPaginated(param, expression);
    private async Task<IEnumerable<T>> GetAllPaginated(IParam param, Expression<Func<T, bool>> expression = null){
        return (await GetAll(expression))
                .Where(x => PaginateExpression(x,param.Search))
                .Skip((param.PageIndex - 1) * param.PageSize)
                .Take(param.PageSize)
                .ToList();

    }

    
}
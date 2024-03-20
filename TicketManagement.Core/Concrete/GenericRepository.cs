using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TicketManagement.Core.Entities;
using TicketManagement.Core.Abstract;
using TicketManagement.Core.Concrete.EntityFramework.Context;


namespace TicketManagement.Core.Concrete;

public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey>
    where TEntity : BaseEntity<TKey>

{
    private readonly TicketContext _context;

    public GenericRepository(TicketContext ticketContext)
    {
        _context = ticketContext;
    }

    /********************************************************************************************************************/
    public bool Add(TEntity entity, Guid userId)
    {
        throw new NotImplementedException();
    }

    public bool AddRange(IEnumerable<TEntity> entities, Guid userId)
    {
        throw new NotImplementedException();
    }

    public bool Update(TEntity entity, Guid userId)
    {
        throw new NotImplementedException();
    }

    public bool Remove(TEntity entity, Guid userId)
    {
        throw new NotImplementedException();
    }

    public int GetCount(bool includeDeleted = false)
    {
        throw new NotImplementedException();
    }

    /********************************************************************************************************************/
    public async Task<bool> AddAsync(TEntity entity, Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateAsync(TEntity entity, Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> RemoveAsync(TEntity entity, Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> RemoveRangeAsync(List<TEntity> entities, Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> RemoveAsyncById(TKey id, Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<int> GetCountAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity> GetByIdAsync(TKey id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<TEntity>> GetListAsync()
    {
        throw new NotImplementedException();
    }

    /********************************************************************************************************************/
    public TEntity? GetById(TKey id, bool useTracking = false, bool isDeleted = false)
    {
        throw new NotImplementedException();
    }

    public TEntity Find(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TEntity> GetList()
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
    {
        throw new NotImplementedException();
    }
}
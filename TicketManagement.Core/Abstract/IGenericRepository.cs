using System.Linq.Expressions;
using TicketManagement.Core.Entities;

namespace TicketManagement.Core.Abstract;

 public interface IGenericRepository<TEntity, in TKey> where TEntity : BaseEntity<TKey>
    {
        /********************************************************************************************************************/
        bool Add(TEntity entity, Guid userId);

        bool AddRange(IEnumerable<TEntity> entities, Guid userId);

        bool Update(TEntity entity, Guid userId);

        bool Remove(TEntity entity, Guid userId);

        int GetCount(bool includeDeleted);
        /********************************************************************************************************************/

        Task<bool> AddAsync(TEntity entity, Guid userId);

        Task<bool> UpdateAsync(TEntity entity, Guid userId);

        Task<bool> RemoveAsync(TEntity entity, Guid userId);

        Task<bool> RemoveRangeAsync(List<TEntity> entities, Guid userId);

        Task<bool> RemoveAsyncById(TKey id, Guid userId);

        Task<int> GetCountAsync();

        Task<TEntity> GetByIdAsync(TKey id);

        Task<IEnumerable<TEntity>> GetListAsync();
        /********************************************************************************************************************/
        TEntity? GetById(TKey id, bool useTracking = false, bool isDeleted = false);

        TEntity Find(Expression<Func<TEntity, bool>> expression);

        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> expression);

        IEnumerable<TEntity> GetList();
        
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression); 
    }
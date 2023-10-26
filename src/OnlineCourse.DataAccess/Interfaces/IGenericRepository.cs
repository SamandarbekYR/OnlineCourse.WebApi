using OnlineCourse.Domain.Entities;
using System.Linq.Expressions;

namespace OnlineCourse.DataAccess.Interfaces
{
    public interface IGenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
        public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
        public Task<TEntity?> LastOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
    }
}
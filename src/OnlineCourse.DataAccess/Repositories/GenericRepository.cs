using Microsoft.EntityFrameworkCore;
using OnlineCourse.DataAccess.DbContexts;
using OnlineCourse.DataAccess.Interfaces;
using OnlineCourse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.DataAccess.Repositories
{
    public class GenericRepository<TEntity> : Repository<TEntity>, IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        public GenericRepository(AppDbContext appDb) : base(appDb)
        {
        }

        public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
     => await _dbSet.FirstOrDefaultAsync(expression);
        public IQueryable<TEntity> GetAll()
            => _dbSet;
        public Task<TEntity?> LastOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
            => _dbSet.LastOrDefaultAsync(expression);
        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
            => _dbSet.Where(expression);
    }
}

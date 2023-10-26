using Microsoft.EntityFrameworkCore;
using OnlineCourse.DataAccess.DbContexts;
using OnlineCourse.DataAccess.Interfaces;
using OnlineCourse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public DbSet<TEntity> _dbSet;

        public Repository(AppDbContext appDb)
        {
            this._dbSet = appDb.Set<TEntity>();
        }
        public void Add(TEntity entity) => this._dbSet.Add(entity);
        public async Task<long> CountAsync() => await _dbSet.CountAsync();
        public void Delete(Guid id)
        {
            TEntity entity = this._dbSet.Find(id)!;
            if (entity != null)
            {
                this._dbSet.Remove(entity);
            }
        }
        public IQueryable<TEntity> GetAll() => _dbSet;
        public async Task<TEntity?> GetByIdAsync(Guid id) => await _dbSet.FindAsync(id);
        public void Update(Guid id, TEntity entity)
        {
            entity.Id = id;
            this._dbSet.Update(entity);
        }
    }
}

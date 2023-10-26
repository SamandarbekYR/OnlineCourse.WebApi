using OnlineCourse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        public IQueryable<TEntity> GetAll();
        public Task<long> CountAsync();
        public void Add(TEntity entity);
        public void Update(Guid id, TEntity entity);
        public void Delete(Guid id);
        public Task<TEntity?> GetByIdAsync(Guid id);
    }
}

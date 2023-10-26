using OnlineCourse.DataAccess.DbContexts;
using OnlineCourse.DataAccess.Interfaces;
using OnlineCourse.DataAccess.Interfaces.Courses;
using OnlineCourse.DataAccess.Interfaces.Users;
using OnlineCourse.DataAccess.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private AppDbContext _dbSet;

        public IUser User { get; }
        public IUserRole UserRole { get; }
        public ICourse Course { get; }
        public ICourseVideo CourseVideo { get; }
        public IPurchasedCourse PurchasedCourse { get; }

        public UnitOfWork(AppDbContext appDb)
        {
          this._dbSet = appDb;



        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

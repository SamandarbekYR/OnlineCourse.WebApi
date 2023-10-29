using OnlineCourse.DataAccess.DbContexts;
using OnlineCourse.DataAccess.Interfaces;
using OnlineCourse.DataAccess.Interfaces.Courses;
using OnlineCourse.DataAccess.Interfaces.Users;
using OnlineCourse.DataAccess.Repositories.Courses;
using OnlineCourse.DataAccess.Repositories.Users;

namespace OnlineCourse.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
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

            this.User = new UserRepository(appDb);
            this.UserRole = new UserRoleRepository(appDb);
            this.Course = new CourseRepository(appDb);
            this.CourseVideo = new CourseVideoRepository(appDb);
            this.PurchasedCourse = new PurchasedCourseRepository(appDb);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return this._dbSet.SaveChanges();
        }
    }
}

using OnlineCourse.DataAccess.Interfaces.Courses;
using OnlineCourse.DataAccess.Interfaces.Users;

namespace OnlineCourse.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        public IUser User { get; }
        public IUserRole UserRole { get; }
        public ICourse Course { get; }
        public ICourseVideo CourseVideo { get; }
        public IPurchasedCourse PurchasedCourse { get; }

        public int SaveChanges();
    }
}

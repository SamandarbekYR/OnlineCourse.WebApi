using OnlineCourse.DataAccess.Interfaces.Courses;
using OnlineCourse.DataAccess.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        public IUser User { get; }
        public IUserRole UserRole { get; }
        public ICourse Course { get; }
        public ICourseVideo CourseVideo { get; }
        public IPurchasedCourse PurchasedCourse { get; }

        public int SaveChanges ();
    }
}

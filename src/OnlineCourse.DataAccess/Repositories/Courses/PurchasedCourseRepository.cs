using OnlineCourse.DataAccess.DbContexts;
using OnlineCourse.DataAccess.Interfaces.Courses;
using OnlineCourse.Domain.Entities.Courses;

namespace OnlineCourse.DataAccess.Repositories.Courses
{
    public class PurchasedCourseRepository : GenericRepository<PurchasedCourse>, IPurchasedCourse
    {
        public PurchasedCourseRepository(AppDbContext appDb) : base(appDb)
        { }
    }
}

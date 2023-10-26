using OnlineCourse.DataAccess.DbContexts;
using OnlineCourse.DataAccess.Interfaces.Courses;
using OnlineCourse.Domain.Entities.Courses;

namespace OnlineCourse.DataAccess.Repositories.Courses
{
    public class CourseRepository : GenericRepository<Course>, ICourse
    {
        public CourseRepository(AppDbContext appDb) : base(appDb)
        {
        }
    }
}

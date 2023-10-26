using OnlineCourse.DataAccess.DbContexts;
using OnlineCourse.DataAccess.Interfaces.Courses;
using OnlineCourse.Domain.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.DataAccess.Repositories.Courses
{
    public class CourseVideoRepository : GenericRepository<CourseVideo>, ICourseVideo
    {
        public CourseVideoRepository(AppDbContext appDb) : base(appDb)
        { }
    }
}

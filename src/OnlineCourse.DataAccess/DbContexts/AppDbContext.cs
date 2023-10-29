using Microsoft.EntityFrameworkCore;
using OnlineCourse.DataAccess.Repositories.Users;
using OnlineCourse.Domain.Entities.Courses;
using OnlineCourse.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.DataAccess.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<CourseVideo> CourseVideos { get; set; }
        DbSet<PurchasedCourse> Purchases { get; set;} 
    }
}

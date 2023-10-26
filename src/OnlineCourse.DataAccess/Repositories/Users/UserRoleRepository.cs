using OnlineCourse.DataAccess.DbContexts;
using OnlineCourse.DataAccess.Interfaces.Users;
using OnlineCourse.Domain.Entities.Users;

namespace OnlineCourse.DataAccess.Repositories.Users
{
    public class UserRoleRepository : GenericRepository<UserRole>, IUserRole
    {
        public UserRoleRepository(AppDbContext appDb) : base(appDb)
        { }
    }
}

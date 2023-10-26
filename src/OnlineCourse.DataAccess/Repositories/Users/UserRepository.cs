using OnlineCourse.DataAccess.DbContexts;
using OnlineCourse.DataAccess.Interfaces.Users;
using OnlineCourse.Domain.Entities.Users;

namespace OnlineCourse.DataAccess.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUser
    {
        public UserRepository(AppDbContext appDb) : base(appDb)
        { }
    }
}

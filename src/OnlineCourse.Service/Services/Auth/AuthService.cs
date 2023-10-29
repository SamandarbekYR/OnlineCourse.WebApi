using OnlineCourse.Service.Dtos.Auth;
using OnlineCourse.Service.Interfaces.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Service.Services.Auth
{
    public class AuthService : IAuthService
    {
        public Task<(bool Result, string Token)> LoginAsync(LoginDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<(bool Result, int CachedMinutes)> RegisterAsync(RegisterDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<(bool Result, string Token)> VerifyRegisterAsync(string phoneNumber, int code)
        {
            throw new NotImplementedException();
        }
    }
}

using OnlineCourse.Service.Dtos.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Service.Interfaces.Auth
{
    public interface IAuthService
    {
        public Task<(bool Result, int CachedMinutes)> RegisterAsync(RegisterDto dto);
        public Task<(bool Result, string Token)> LoginAsync(LoginDto dto);
        public Task<(bool Result, string Token)> VerifyRegisterAsync(string phoneNumber, int code);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Service.Dtos.Auth
{
    public class RegisterDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Gmail { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}

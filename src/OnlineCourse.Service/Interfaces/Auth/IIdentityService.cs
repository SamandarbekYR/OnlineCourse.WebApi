using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Service.Interfaces.Auth
{
    public interface IIdentityService
    {
        public long Id { get; }
        public string RoleName { get; }
        public string FirstName { get; }
        public string gmail { get; }
    }
}

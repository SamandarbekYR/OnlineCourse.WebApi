using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Service.Helpers
{
    public static class CodeGenerate
    {
        public static int Code()
        {
            Random random= new Random();

            return random.Next(1000,9999);
        }
    }
}

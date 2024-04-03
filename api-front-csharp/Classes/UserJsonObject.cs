using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_front_csharp.Classes
{
    class UserJsonObject
    {
        public List<User> Users { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_front_csharp.Classes
{
    class CustomerJsonObject
    {
        public List<Customer> Customers { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
    }
}

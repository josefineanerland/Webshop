using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webshop.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Adress { get; set; }
        public string ZipcodeAndCity { get; set; }
        public string Identity { get; set; }

    }
}

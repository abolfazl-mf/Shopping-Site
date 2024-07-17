using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product__easy_learn_.Models
{
    public class RegisterModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordTwo { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

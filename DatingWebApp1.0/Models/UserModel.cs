using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatingWebApp1._0.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string About { get; set; }
        public string Password { get; set; }
        public string City { get; set; }

    }
}
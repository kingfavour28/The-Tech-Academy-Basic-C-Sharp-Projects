using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    public class User
    {
        public int id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.MVC.ViewModel
{
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
    }
}

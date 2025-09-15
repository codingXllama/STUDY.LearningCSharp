using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    public abstract class Person
    {
        private string Name { get; set; }
        private string Password { get; set; }
        private string Email { get; set; }
        private string Phone { get; set; }

        public abstract string LogIn();
    }
}

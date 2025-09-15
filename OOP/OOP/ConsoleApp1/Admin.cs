using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DEMO
{
    public class Admin : Person
    {
       public override string LogIn()
        {
            return  "LogIn";
        }

        public string LogOut()
        {
            return "LogOut";
        }
       
    }
}

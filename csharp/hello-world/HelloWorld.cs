using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.hello_world
{
    class HelloWorld
    {
        public static string Hello(string name)
        {
            if(name == null)
            {
                return "Hello, World!";
            }
            else
            {
                return "Hello, " + name + "!";
            }
        }
    }
}

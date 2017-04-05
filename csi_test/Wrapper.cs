using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi_test
{
    public class Wrapper
    {
        public static void HelloWorld(string username = "World")
        {
            Console.WriteLine($"Hello, {username}");
        }
    }
}

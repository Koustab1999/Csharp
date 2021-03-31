using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class ImplicitTypeDemo
    {
        static void Main()
        {
            int b = 100; // explicity typed variable
            var a = 100;  //  typed variable
            var name ="Koustab"; 
            var arr = new[] { 11, 22, 33 };

            Console.WriteLine(a);
            Console.WriteLine(name);
            Console.WriteLine(arr);
        }
    }
}

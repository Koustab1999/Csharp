using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class OutDemo
    {
        static void Main(string[] args)
        {
            int x, y;
            Multiplication(out x, out y);
            Console.WriteLine("x Value: {0}", x);
            Console.WriteLine("y Value: {0}", y);



            Console.ReadKey();
        }
        //  The out parameter in c# is also useful to return more than one values from the methods.
        public static void Multiplication(out int a, out int b)
        {
            a = 10;
            b = 5;



            a *= a;
            b *= b;



        }
    }
}

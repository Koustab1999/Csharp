using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssemblyTest
{
    class GCExapmle
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("GC Maximum Generation :" + GC.MaxGeneration);
            Console.ReadKey();
        }
    }
}

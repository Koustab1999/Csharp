using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class ForDemo
    {
        public static void Main(String [] args)
        {
            for(int k=1;k<=5;k++)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", k);

            }
            // multiple initialization & iterator expressions

            for(int i=0,j=0; i+j<=5; i++,j++)
            {
                Console.WriteLine("i = {0} and j = {1}", i, j);
            }

            // for loop without initialization & iterator statements
            int m = 1;
            for(; m<=5; )
            {
                Console.WriteLine("C# For Loop: Iteration {0}", m);
                m++;

            }

            // infinite loops
            /* for(; ; )
             {
                 Console.WriteLine("Infinite Loop");
             }*/
            Console.ReadKey();
        }
    }
}

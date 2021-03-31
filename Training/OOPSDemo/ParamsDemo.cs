using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class ParamsDemo
    {
        static void Main(string[] args)

        {

            // ParamsMethod(1, 2, 3, 4, 5, 6);
            ParamsMethod(1, 2, 30);
        }

        public static void ParamsMethod(params int[] arr)

        {
            int sum =0;
        

            for (int i = 0; i < arr.Length; i++)

            {
                sum = sum + arr[i];

            }

            Console.WriteLine("The Sum of Arguments: "+sum);

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }
    }
}

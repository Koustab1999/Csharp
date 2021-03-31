using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOpsDemo
{
    class SqrtPreCalculated
    {
        public const int MAX_VALUE = 10000;



        //static field 
        private static int[] sqrtValues;



        //static constructor
        static SqrtPreCalculated()
        {
            sqrtValues = new int[MAX_VALUE + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }
        // static method
        public static int GetSqrt(int value)
        {
            return sqrtValues[value];
        }
        // The Main() method is always static
        static void Main()
        {
            Console.WriteLine(GetSqrt(4));
            Console.ReadKey();
        }
    }
}


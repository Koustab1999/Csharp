using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class MultiArray
    {
        static void Main()
        {
            int[,] a = new int[3,3];  // declaring multi dimension array
            // initialisation

            a[0, 0] = 100;    // store 100 in 1 row,1 column
            a[0, 1] = 200;
            a[0, 2] = 300;
            a[1, 1] = 400;
            a[2, 2] = 500;

            //traverse

            for(int i=0;i<3;i++)    // row index
            {
                for(int j=0;j<3;j++)  //col index
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            // declare & intialise array
            int[,] b = { { 11, 22, 33 }, { 1, 2, 3 }, { 99, 88, 77 } };
           
            // traverse
            for (int i = 0; i < 3; i++)    // row index
            {
                for (int j = 0; j < 3; j++)  //col index
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}

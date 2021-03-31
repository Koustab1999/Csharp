using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate int operation(int x, int y);
    class Program
    {
       static int Addition(int a ,int b)
        {
            return a + b;

        }
        static void Main(string[] args)
        {
            operation obj = new operation(Program.Addition);
            Console.WriteLine("Addition is ={0}", obj(23, 27));


            int result = obj.Invoke(50, 25);
            Console.WriteLine("Addition is ={0}", result);

            Console.ReadLine();
        }
    }
}

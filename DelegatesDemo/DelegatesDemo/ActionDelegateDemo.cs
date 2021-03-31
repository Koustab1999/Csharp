using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class ActionDelegateDemo
    {
        public static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        static void Main()
        {
            Action<int> a = ConsolePrint; // 1st way

            Action<int> b = new Action<int>(ConsolePrint); // 2st way

            a.Invoke(100);
            b.Invoke(20);
            Console.Read();
        }
    }
}
/* public delegate void Print(int val); with out action delegate

static void ConsolePrint(int i)
{
    Console.WriteLine(i);
}

static void Main(string[] args)
{           
    Print prnt = ConsolePrint;
    prnt(10);
}*/

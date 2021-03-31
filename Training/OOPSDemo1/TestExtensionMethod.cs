using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSDemo1;
namespace OOPSDemo1
{
    class TestExtensionMethod
    {
        static void Main()
        {
            int i = 10;
            string myWord = "Learning C# Extension Methods is Fun";
            bool result = i.IsGreaterThan(100); // invoking extension method
            Console.WriteLine(result);


            int myWordCount = myWord.GetWordCount(); // invoking extension method
            Console.WriteLine("String :" + myWord);
            Console.WriteLine("No. of Words :" + myWordCount);
           
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpBasics
{
    class CommandLineDemo2
    {
        static void Main(String [] args)
        {
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            int c = int.Parse(args[2]);

            int sum = a + b + c;
            float avg =(float) sum / 3;
            Console.WriteLine("The sum of three numbers is : " +sum);
            Console.WriteLine("The Average of three numbers is : {0:0.00}" , avg);
            Console.WriteLine("The Average of three numbers is : {0:0.###}", avg);
           // Console.WriteLine("The Average of three numbers is :{0:c} ", avg);
            //Console.WriteLine(string.Format(new CultureInfo("hi-IN"), "{0:c} ", avg));
       //    // Console.WriteLine(avg.ToString("C", CultureInfo.GetCultureInfo("en-INR")));
            Console.WriteLine(string.Format(new CultureInfo("en-INR"), "{0:c}", avg));



            Console.ReadKey();
        }
    }

}

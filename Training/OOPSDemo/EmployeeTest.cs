using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOPSDemo
{
    class EmplyeeTest
    {
        public static void Main(String[] args)
        {
            Employee e1 = new Employee();
            e1.input();
            decimal np = e1.CalculateSalary();
            e1.display();
            Console.WriteLine("Net Salary  :" + np);
            Console.WriteLine("======================================");
            Console.ReadKey();
        }
    }
}

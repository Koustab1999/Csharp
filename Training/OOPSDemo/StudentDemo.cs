using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class StudentDemo
    {
        static void Main()
        {
            Student s1 = new Student(101, "Mary");

            // s1.Name = "Steve";
            // s1.Rollno = 100;
            s1.Course = "Computer Science"; // accessing write only property
            Console.WriteLine(s1.Rollno + " " + s1.Name);
            // Console.WriteLine(s1.Course);// compiler error - trying to access write only properties
            s1.display();
            s1.City = "Hyderabad";  // store value in auto-imlimented property
            Console.WriteLine(s1.City);
            Console.ReadKey();
        }
    }
}

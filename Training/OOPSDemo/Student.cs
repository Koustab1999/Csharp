using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{ // Read Only or Write Only Properties
    class Student
    {
        private int rollno;
        private string name;
        private string course;
        private string city;

        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

        public int Rollno { get => rollno; } /* read only properties (get)*/
        public string Name { get => name; } /* read only properties (get)*/
        public string Course

        {
            set { course = value; }
        } /* Write only property*/

        /* Auto Implemented Properties; */
        public string City { get; set; }

        public void display()

        {
            Console.WriteLine(course);
        }
    }
}
